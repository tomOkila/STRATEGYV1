using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STRATEGY.WEBAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddStrategicPlanTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StrategicPlans",
                columns: table => new
                {
                    StrategicPlanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StrategicPlanName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PillarID = table.Column<int>(type: "int", nullable: false),
                    SOId = table.Column<int>(type: "int", nullable: false),
                    DetailedId = table.Column<int>(type: "int", nullable: false),
                    ProgramScheduleId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StrategicPlans", x => x.StrategicPlanID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StrategicPlans");
        }
    }
}
