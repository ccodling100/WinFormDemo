using DGSDataUtils.Entities.ProMgrEntities;
using Microsoft.EntityFrameworkCore;

namespace DGSDataUtils.Configure;

public static class TrackLimitPercentagesConfig
{
    /// <summary>
    /// Builds the configuration for the TrackLimitPercentages entity in the database.
    /// </summary>
    /// <param name="builder">The ModelBuilder object used to configure the database context.</param>
    public static void BuildTrackLimitPercentages(this ModelBuilder builder)
    {
        builder.Entity<TrackLimitPercentages>().ToTable(nameof(TrackLimitPercentages), t => t.ExcludeFromMigrations());
    }
}