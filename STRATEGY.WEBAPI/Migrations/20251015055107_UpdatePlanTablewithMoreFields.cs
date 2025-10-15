using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STRATEGY.WEBAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePlanTablewithMoreFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ActImpSteps",
                table: "Plans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "ActualCost",
                table: "Plans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "ActualPerformance",
                table: "Plans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CompletionDate",
                table: "Plans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "EntityResponsible",
                table: "Plans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "EstimatedCost",
                table: "Plans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Evidence",
                table: "Plans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExeActivityAnalysis",
                table: "Plans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ImpStartDate",
                table: "Plans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "InitiativeStatus",
                table: "Plans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "KeyPerfIndicatorsEvaluation",
                table: "Plans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PartParties",
                table: "Plans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "ProposedCost",
                table: "Plans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "SectionComment",
                table: "Plans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StraKeyPerfIndicators",
                table: "Plans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SupervisorReview",
                table: "Plans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TargetGroup",
                table: "Plans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Targeted",
                table: "Plans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TeamComment",
                table: "Plans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WitnessDetail",
                table: "Plans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 15, 8, 51, 7, 685, DateTimeKind.Local).AddTicks(6084), new DateTime(2025, 10, 15, 8, 51, 7, 685, DateTimeKind.Local).AddTicks(6085) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 15, 8, 51, 7, 685, DateTimeKind.Local).AddTicks(5904), new DateTime(2025, 10, 15, 8, 51, 7, 685, DateTimeKind.Local).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 15, 8, 51, 7, 685, DateTimeKind.Local).AddTicks(5923), new DateTime(2025, 10, 15, 8, 51, 7, 685, DateTimeKind.Local).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 15, 8, 51, 7, 685, DateTimeKind.Local).AddTicks(5925), new DateTime(2025, 10, 15, 8, 51, 7, 685, DateTimeKind.Local).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 15, 8, 51, 7, 685, DateTimeKind.Local).AddTicks(6057), new DateTime(2025, 10, 15, 8, 51, 7, 685, DateTimeKind.Local).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 15, 8, 51, 7, 685, DateTimeKind.Local).AddTicks(6060), new DateTime(2025, 10, 15, 8, 51, 7, 685, DateTimeKind.Local).AddTicks(6061) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 15, 8, 51, 7, 685, DateTimeKind.Local).AddTicks(6062), new DateTime(2025, 10, 15, 8, 51, 7, 685, DateTimeKind.Local).AddTicks(6062) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActImpSteps",
                table: "Plans");

            migrationBuilder.DropColumn(
                name: "ActualCost",
                table: "Plans");

            migrationBuilder.DropColumn(
                name: "ActualPerformance",
                table: "Plans");

            migrationBuilder.DropColumn(
                name: "CompletionDate",
                table: "Plans");

            migrationBuilder.DropColumn(
                name: "EntityResponsible",
                table: "Plans");

            migrationBuilder.DropColumn(
                name: "EstimatedCost",
                table: "Plans");

            migrationBuilder.DropColumn(
                name: "Evidence",
                table: "Plans");

            migrationBuilder.DropColumn(
                name: "ExeActivityAnalysis",
                table: "Plans");

            migrationBuilder.DropColumn(
                name: "ImpStartDate",
                table: "Plans");

            migrationBuilder.DropColumn(
                name: "InitiativeStatus",
                table: "Plans");

            migrationBuilder.DropColumn(
                name: "KeyPerfIndicatorsEvaluation",
                table: "Plans");

            migrationBuilder.DropColumn(
                name: "PartParties",
                table: "Plans");

            migrationBuilder.DropColumn(
                name: "ProposedCost",
                table: "Plans");

            migrationBuilder.DropColumn(
                name: "SectionComment",
                table: "Plans");

            migrationBuilder.DropColumn(
                name: "StraKeyPerfIndicators",
                table: "Plans");

            migrationBuilder.DropColumn(
                name: "SupervisorReview",
                table: "Plans");

            migrationBuilder.DropColumn(
                name: "TargetGroup",
                table: "Plans");

            migrationBuilder.DropColumn(
                name: "Targeted",
                table: "Plans");

            migrationBuilder.DropColumn(
                name: "TeamComment",
                table: "Plans");

            migrationBuilder.DropColumn(
                name: "WitnessDetail",
                table: "Plans");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 13, 10, 59, 28, 127, DateTimeKind.Local).AddTicks(9817), new DateTime(2025, 10, 13, 10, 59, 28, 127, DateTimeKind.Local).AddTicks(9818) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 13, 10, 59, 28, 127, DateTimeKind.Local).AddTicks(9631), new DateTime(2025, 10, 13, 10, 59, 28, 127, DateTimeKind.Local).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 13, 10, 59, 28, 127, DateTimeKind.Local).AddTicks(9648), new DateTime(2025, 10, 13, 10, 59, 28, 127, DateTimeKind.Local).AddTicks(9649) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 13, 10, 59, 28, 127, DateTimeKind.Local).AddTicks(9650), new DateTime(2025, 10, 13, 10, 59, 28, 127, DateTimeKind.Local).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 13, 10, 59, 28, 127, DateTimeKind.Local).AddTicks(9788), new DateTime(2025, 10, 13, 10, 59, 28, 127, DateTimeKind.Local).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 13, 10, 59, 28, 127, DateTimeKind.Local).AddTicks(9791), new DateTime(2025, 10, 13, 10, 59, 28, 127, DateTimeKind.Local).AddTicks(9792) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 13, 10, 59, 28, 127, DateTimeKind.Local).AddTicks(9793), new DateTime(2025, 10, 13, 10, 59, 28, 127, DateTimeKind.Local).AddTicks(9793) });
        }
    }
}
