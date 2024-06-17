using DGSDataUtils.Entities.ProMgrEntities;
using Microsoft.EntityFrameworkCore;

namespace DGSDataUtils.Configure
{
    public static class RaceProfileConfig
    {
        /// <summary>
        /// Builds the race profile table and its configuration in the database.
        /// </summary>
        /// <param name="builder">The ModelBuilder object used to configure the database context.</param>
        public static void BuildRaceProfile(this ModelBuilder builder)
    {
        builder.Entity<DtoRaceProfile>(entity =>
        {
            entity.HasKey(e => e.IdRaceProfile);
            entity.Property(e => e.IdRaceProfile).ValueGeneratedNever();
            entity.ToTable("IBET_RaceProfiles");
            entity.Property(e => e.GlobalMaxAmount).HasColumnType("money");
        });
    }
    }
}