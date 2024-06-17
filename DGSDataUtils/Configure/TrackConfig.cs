using DGSDataUtils.Entities.ProMgrEntities;
using Microsoft.EntityFrameworkCore;

namespace DGSDataUtils.Configure
{
    public static class TrackConfig
    {
        /// <summary>
        /// Builds the Track entity and its configuration in the database.
        /// </summary>
        /// <param name="builder">The ModelBuilder object used to configure the database context.</param>
        public static void BuildTrack(this ModelBuilder builder)
    {
        builder.Entity<DtoTrack>(entity =>
        {
            entity.HasKey(e => e.IdTrack);
            entity.Property(e => e.IdTrack).ValueGeneratedNever();
            entity.Property(e => e.TrackCode).HasMaxLength(3);
            entity.ToTable("IBET_Track");
        });
    }
    }
}