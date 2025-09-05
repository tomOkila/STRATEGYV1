using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STRATEGY.WEBAPI.Migrations
{
    /// <inheritdoc />
    public partial class AdditionalTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pillars",
                columns: table => new
                {
                    PillarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PillarName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PillarRecorder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pillars", x => x.PillarID);
                });

            migrationBuilder.CreateTable(
                name: "StrategicObjectives",
                columns: table => new
                {
                    SOId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TargetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PillarId = table.Column<int>(type: "int", nullable: false),
                    GoalScoreDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GoalScorerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StrategicObjectives", x => x.SOId);
                    table.ForeignKey(
                        name: "FK_StrategicObjectives_Pillars_PillarId",
                        column: x => x.PillarId,
                        principalTable: "Pillars",
                        principalColumn: "PillarID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetailedSO",
                columns: table => new
                {
                    DetailedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetailedTargetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetailedTargetHistory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetailedScorerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SOId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailedSO", x => x.DetailedId);
                    table.ForeignKey(
                        name: "FK_DetailedSO_StrategicObjectives_SOId",
                        column: x => x.SOId,
                        principalTable: "StrategicObjectives",
                        principalColumn: "SOId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProgramSchedules",
                columns: table => new
                {
                    ProgramScheduleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProgramRegistrarName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetailedId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramSchedules", x => x.ProgramScheduleId);
                    table.ForeignKey(
                        name: "FK_ProgramSchedules_DetailedSO_DetailedId",
                        column: x => x.DetailedId,
                        principalTable: "DetailedSO",
                        principalColumn: "DetailedId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetailedSO_SOId",
                table: "DetailedSO",
                column: "SOId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramSchedules_DetailedId",
                table: "ProgramSchedules",
                column: "DetailedId");

            migrationBuilder.CreateIndex(
                name: "IX_StrategicObjectives_PillarId",
                table: "StrategicObjectives",
                column: "PillarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProgramSchedules");

            migrationBuilder.DropTable(
                name: "DetailedSO");

            migrationBuilder.DropTable(
                name: "StrategicObjectives");

            migrationBuilder.DropTable(
                name: "Pillars");
        }
    }
}
