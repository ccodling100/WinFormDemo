using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DGSDataUtils.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IBET_AgentDefaults",
                columns: table => new
                {
                    IdAgent = table.Column<int>(type: "int", nullable: false),
                    IdRaceProfile = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IBET_AgentDefaults", x => x.IdAgent);
                });

            migrationBuilder.CreateTable(
                name: "IBET_BetTypes",
                columns: table => new
                {
                    IdBetType = table.Column<int>(type: "int", nullable: false),
                    BetName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IBET_BetTypes", x => x.IdBetType);
                });

            migrationBuilder.CreateTable(
                name: "IBET_ProfileMaps",
                columns: table => new
                {
                    IdProfileMap = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdSportProfile = table.Column<int>(type: "int", nullable: false),
                    IdPlayer = table.Column<int>(type: "int", nullable: true),
                    IdRaceProfile = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IBET_ProfileMaps", x => x.IdProfileMap);
                });

            migrationBuilder.CreateTable(
                name: "IBET_Track",
                columns: table => new
                {
                    IdTrack = table.Column<int>(type: "int", nullable: false),
                    TrackName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrackCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IBET_Track", x => x.IdTrack);
                });

            migrationBuilder.CreateTable(
                name: "IBET_RaceProfiles",
                columns: table => new
                {
                    IdRaceProfile = table.Column<int>(type: "int", nullable: false),
                    ProfileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HorseGlobalMax = table.Column<int>(type: "int", nullable: false),
                    GlobalMaxTime = table.Column<int>(type: "int", nullable: false),
                    GlobalMaxAmount = table.Column<decimal>(type: "money", nullable: false),
                    DefaultPerRaceMaxWin = table.Column<decimal>(type: "money", nullable: false),
                    IbetAgentDefaultIdAgent = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IBET_RaceProfiles", x => x.IdRaceProfile);
                    table.ForeignKey(
                        name: "FK_IBET_RaceProfiles_IBET_AgentDefaults_IbetAgentDefaultIdAgent",
                        column: x => x.IbetAgentDefaultIdAgent,
                        principalTable: "IBET_AgentDefaults",
                        principalColumn: "IdAgent");
                });

            migrationBuilder.CreateTable(
                name: "IBET_TrackLimits",
                columns: table => new
                {
                    IdRaceProfile = table.Column<int>(type: "int", nullable: false),
                    IdTrack = table.Column<int>(type: "int", nullable: false),
                    IdBetType = table.Column<int>(type: "int", nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    PerRaceMaxWin = table.Column<decimal>(type: "money", nullable: false),
                    MinBet = table.Column<decimal>(type: "money", nullable: false),
                    MaxBet = table.Column<decimal>(type: "money", nullable: false),
                    PerBetMaxWin = table.Column<decimal>(type: "money", nullable: false),
                    MaxPayoutOdds = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IBET_TrackLimits", x => new { x.IdTrack, x.IdRaceProfile, x.IdBetType });
                    table.ForeignKey(
                        name: "FK_IBET_TrackLimits_IBET_BetTypes_IdBetType",
                        column: x => x.IdBetType,
                        principalTable: "IBET_BetTypes",
                        principalColumn: "IdBetType",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IBET_TrackLimits_IBET_RaceProfiles_IdRaceProfile",
                        column: x => x.IdRaceProfile,
                        principalTable: "IBET_RaceProfiles",
                        principalColumn: "IdRaceProfile",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IBET_TrackLimits_IBET_Track_IdTrack",
                        column: x => x.IdTrack,
                        principalTable: "IBET_Track",
                        principalColumn: "IdTrack",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IBET_AgentDefaults_IdRaceProfile",
                table: "IBET_AgentDefaults",
                column: "IdRaceProfile");

            migrationBuilder.CreateIndex(
                name: "IX_IBET_RaceProfiles_IbetAgentDefaultIdAgent",
                table: "IBET_RaceProfiles",
                column: "IbetAgentDefaultIdAgent");

            migrationBuilder.CreateIndex(
                name: "IX_IBET_TrackLimits_IdBetType",
                table: "IBET_TrackLimits",
                column: "IdBetType");

            migrationBuilder.CreateIndex(
                name: "IX_IBET_TrackLimits_IdRaceProfile",
                table: "IBET_TrackLimits",
                column: "IdRaceProfile");

            migrationBuilder.CreateIndex(
                name: "IX_IBET_TrackLimits_IdTrack",
                table: "IBET_TrackLimits",
                column: "IdTrack");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IBET_ProfileMaps");

            migrationBuilder.DropTable(
                name: "IBET_TrackLimits");

            migrationBuilder.DropTable(
                name: "IBET_BetTypes");

            migrationBuilder.DropTable(
                name: "IBET_RaceProfiles");

            migrationBuilder.DropTable(
                name: "IBET_Track");

            migrationBuilder.DropTable(
                name: "IBET_AgentDefaults");
        }
    }
}
