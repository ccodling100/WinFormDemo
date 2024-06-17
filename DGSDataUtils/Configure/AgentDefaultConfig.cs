using DGSDataUtils.Entities.ProMgrEntities;
using Microsoft.EntityFrameworkCore;

namespace DGSDataUtils.Configure
{
    public static class AgentDefaultConfig
    {
        /// <summary>
        /// Builds the default agent configuration for the database.
        /// </summary>
        /// <param name="builder">The ModelBuilder object used to configure the database context.</param>
        public static void BuildAgentDefault(this ModelBuilder builder)
        {
            builder.Entity<DtoAgentDefault>(entity =>
            {
                entity.HasKey(e => e.IdAgent);
                entity.Property(e => e.IdAgent).ValueGeneratedNever();
                entity.ToTable("IBET_AgentDefaults");
                entity.HasIndex(e => e.IdRaceProfile, "IX_IBET_AgentDefaults_IdRaceProfile");
                entity.Property(e => e.IdRaceProfile).IsRequired(false);
                //entity.HasOne(d => d.IdRaceProfileNavigation).WithOne(p => p.IbetAgentDefault).HasForeignKey<DtoAgentDefault>(d => d.IdRaceProfile);
            });
        }
    }
}