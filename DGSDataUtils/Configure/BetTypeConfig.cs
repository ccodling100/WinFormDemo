using DGSDataUtils.Entities.ProMgrEntities;
using Microsoft.EntityFrameworkCore;

namespace DGSDataUtils.Configure
{
    public static class BetTypeConfig
    {
        /// <summary>
        /// Builds the BetType entity and its configuration in the database.
        /// </summary>
        /// <param name="builder">The ModelBuilder object used to configure the database context.</param>
        public static void BuildBetType(this ModelBuilder builder)
    {
        builder.Entity<DtoBetType>(entity =>
        {
            entity.HasKey(e => e.IdBetType);
            entity.Property(e => e.IdBetType).ValueGeneratedNever();
            entity.Property(e => e.BetName).IsRequired(false);
            entity.ToTable("IBET_BetTypes");
        });
    }
    }
}