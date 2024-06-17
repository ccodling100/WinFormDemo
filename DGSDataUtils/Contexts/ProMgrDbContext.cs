using DGSDataUtils.Configure;
using DGSDataUtils.Entities.ProMgrEntities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DGSDataUtils.Contexts
{
    public class ProMgrDbContext : DbContext
    {
        private readonly string _connectionString = String.Empty;

        #region Constructors

        public ProMgrDbContext()
        {
            _connectionString = "Server=192.168.0.27;Database=ProMgrData;User Id=sa;Password=devuser3212!;Persist Security Info=False;Encrypt=False";
        }

        public ProMgrDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        #endregion

        #region DbSets

        public virtual DbSet<DtoAgentDefault> AgentDefaults => Set<DtoAgentDefault>();
        public virtual DbSet<DtoBetType> BetTypes => Set<DtoBetType>();
        public virtual DbSet<DtoProfileMap> ProfileMaps => Set<DtoProfileMap>();
        public virtual DbSet<DtoRaceProfile> RaceProfiles => Set<DtoRaceProfile>();
        public virtual DbSet<DtoTrack> Tracks => Set<DtoTrack>();
        public virtual DbSet<DtoTrackLimit> TrackLimits => Set<DtoTrackLimit>();
        public virtual DbSet<TrackLimitPercentages> TrackLimitPercentages => Set<TrackLimitPercentages>();

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.BuildAgentDefault();
            builder.BuildBetType();
            builder.BuildProfileMap();
            builder.BuildRaceProfile();
            builder.BuildTrack();
            builder.BuildTrackLimit();
            builder.BuildTrackLimitPercentages();
        }

        public IEnumerable<TrackLimitPercentages> GetAllTrackLimitPercentages(int idProfile)
        {
            // Create a SQL command to execute the stored procedure
            var commandText = "EXECUTE IBET_GetAllPercentages @inputIdRaceProfile";
            var idProfileParameter = new SqlParameter("@inputIdRaceProfile", idProfile);
            
            var resultSet = TrackLimitPercentages.FromSqlRaw(commandText, idProfileParameter);

            return resultSet;
        }
    }
}