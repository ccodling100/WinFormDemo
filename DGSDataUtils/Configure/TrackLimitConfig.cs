using DGSDataUtils.Entities.ProMgrEntities;
using Microsoft.EntityFrameworkCore;

namespace DGSDataUtils.Configure
{
    public static class TrackLimitConfig
    {
        /// <summary>
        /// Builds the configuration for the TrackLimit entity in the ProMgrDbContext.
        /// </summary>
        /// <param name="builder">The ModelBuilder instance.</param>
        public static void BuildTrackLimit(this ModelBuilder builder)
    {
        builder.Entity<DtoTrackLimit>(entity =>
        {
            entity.HasKey(e => new {e.IdTrack, e.IdRaceProfile, e.IdBetType});
            entity.HasIndex(e => e.IdTrack).IsUnique(false);
            entity.Property(e => e.IdTrack).ValueGeneratedNever();
            entity.Property(e => e.MaxBet).HasColumnType("money");
            entity.Property(e => e.MinBet).HasColumnType("money");
            entity.Property(e => e.PerBetMaxWin).HasColumnType("money");
            entity.Property(e => e.PerRaceMaxWin).HasColumnType("money");
            // entity.HasOne(d => d.IdBetTypeNavigation).WithMany(p => p.IbetTrackLimits)
            //     .HasForeignKey(d => d.IdBetType)
            //     .HasConstraintName("FK_IBET_TrackLimits_IBET_BetType_IdTrack");
            entity.HasOne(d => d.IdTrackNavigation).WithOne(p => p.IbetTrackLimit).HasForeignKey<DtoTrackLimit>(d => d.IdTrack);
            entity.ToTable("IBET_TrackLimits");
        });
    }
    }
}