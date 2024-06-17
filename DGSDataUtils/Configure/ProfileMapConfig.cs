using DGSDataUtils.Entities.ProMgrEntities;
using Microsoft.EntityFrameworkCore;

namespace DGSDataUtils.Configure
{
    public static class ProfileMapConfig
    {
        /// <summary>
        /// Builds the profile map entity and its configuration in the database.
        /// </summary>
        /// <param name="builder">The ModelBuilder object used to configure the database context.</param>
        public static void BuildProfileMap(this ModelBuilder builder)
    {
        builder.Entity<DtoProfileMap>(entity =>
        {
            entity.HasKey(e => e.IdProfileMap);
            entity.ToTable("IBET_ProfileMaps");
            //entity.HasIndex(e => e.IdRaceProfile, "IX_IBET_ProfileMaps_IdRaceProfile");
            //entity.HasOne(d => d.IdRaceProfileNavigation).WithOne(p => p.IbetProfileMap).HasForeignKey<DtoProfileMap>(d => d.IdRaceProfile);
        });
    }
    }
}