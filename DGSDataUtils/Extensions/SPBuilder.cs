using DGSDataUtils.Extensions;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DGSImportToolConsole.Migrations;

public partial class CreateStoredProcs : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateProcedure("CalculateMaxBetPercentages","dbo",@"StoredProcs\CalculateMaxBetPercentages.sql");
        migrationBuilder.CreateProcedure("CalculateMaxPayoutOddsPercentages","dbo",@"StoredProcs\CalculateMaxPayoutOddsPercentages.sql");
        migrationBuilder.CreateProcedure("CalculateMinBetPercentages","dbo",@"StoredProcs\CalculateMinBetPercentages.sql");
        migrationBuilder.CreateProcedure("CalculatePerBetMaxWinPercentages","dbo",@"StoredProcs\CalculatePerBetMaxWinPercentages.sql");
        migrationBuilder.CreateProcedure("CalculatePerRaceMaxWinPercentages","dbo",@"StoredProcs\CalculatePerRaceMaxWinPercentages.sql");
        migrationBuilder.CreateProcedure("GetAllPercentages","dbo",@"StoredProcs\GetAllPercentages.sql");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {

    }
}