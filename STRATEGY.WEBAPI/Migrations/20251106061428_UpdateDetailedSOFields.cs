using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STRATEGY.WEBAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDetailedSOFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DetailedScorerName",
                table: "DetailedSO");

            migrationBuilder.RenameColumn(
                name: "DetailedTargetHistory",
                table: "DetailedSO",
                newName: "DetailedTargetRegistrantName");

            migrationBuilder.AddColumn<DateTime>(
                name: "DetailedGoalScoreDate",
                table: "DetailedSO",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 11, 6, 9, 14, 27, 623, DateTimeKind.Local).AddTicks(7248), new DateTime(2025, 11, 6, 9, 14, 27, 623, DateTimeKind.Local).AddTicks(7250) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 11, 6, 9, 14, 27, 623, DateTimeKind.Local).AddTicks(6923), new DateTime(2025, 11, 6, 9, 14, 27, 623, DateTimeKind.Local).AddTicks(6938) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 11, 6, 9, 14, 27, 623, DateTimeKind.Local).AddTicks(6940), new DateTime(2025, 11, 6, 9, 14, 27, 623, DateTimeKind.Local).AddTicks(6941) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 11, 6, 9, 14, 27, 623, DateTimeKind.Local).AddTicks(6943), new DateTime(2025, 11, 6, 9, 14, 27, 623, DateTimeKind.Local).AddTicks(6944) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 11, 6, 9, 14, 27, 623, DateTimeKind.Local).AddTicks(6946), new DateTime(2025, 11, 6, 9, 14, 27, 623, DateTimeKind.Local).AddTicks(6947) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 11, 6, 9, 14, 27, 623, DateTimeKind.Local).AddTicks(6949), new DateTime(2025, 11, 6, 9, 14, 27, 623, DateTimeKind.Local).AddTicks(6949) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 11, 6, 9, 14, 27, 623, DateTimeKind.Local).AddTicks(7202), new DateTime(2025, 11, 6, 9, 14, 27, 623, DateTimeKind.Local).AddTicks(7204) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 11, 6, 9, 14, 27, 623, DateTimeKind.Local).AddTicks(7206), new DateTime(2025, 11, 6, 9, 14, 27, 623, DateTimeKind.Local).AddTicks(7207) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 11, 6, 9, 14, 27, 623, DateTimeKind.Local).AddTicks(7208), new DateTime(2025, 11, 6, 9, 14, 27, 623, DateTimeKind.Local).AddTicks(7209) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 11, 6, 9, 14, 27, 623, DateTimeKind.Local).AddTicks(7210), new DateTime(2025, 11, 6, 9, 14, 27, 623, DateTimeKind.Local).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 11, 6, 9, 14, 27, 623, DateTimeKind.Local).AddTicks(7213), new DateTime(2025, 11, 6, 9, 14, 27, 623, DateTimeKind.Local).AddTicks(7214) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DetailedGoalScoreDate",
                table: "DetailedSO");

            migrationBuilder.RenameColumn(
                name: "DetailedTargetRegistrantName",
                table: "DetailedSO",
                newName: "DetailedTargetHistory");

            migrationBuilder.AddColumn<string>(
                name: "DetailedScorerName",
                table: "DetailedSO",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 29, 9, 43, 24, 442, DateTimeKind.Local).AddTicks(7495), new DateTime(2025, 10, 29, 9, 43, 24, 442, DateTimeKind.Local).AddTicks(7496) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 29, 9, 43, 24, 442, DateTimeKind.Local).AddTicks(7253), new DateTime(2025, 10, 29, 9, 43, 24, 442, DateTimeKind.Local).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 29, 9, 43, 24, 442, DateTimeKind.Local).AddTicks(7273), new DateTime(2025, 10, 29, 9, 43, 24, 442, DateTimeKind.Local).AddTicks(7274) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 29, 9, 43, 24, 442, DateTimeKind.Local).AddTicks(7276), new DateTime(2025, 10, 29, 9, 43, 24, 442, DateTimeKind.Local).AddTicks(7277) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 29, 9, 43, 24, 442, DateTimeKind.Local).AddTicks(7279), new DateTime(2025, 10, 29, 9, 43, 24, 442, DateTimeKind.Local).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 29, 9, 43, 24, 442, DateTimeKind.Local).AddTicks(7282), new DateTime(2025, 10, 29, 9, 43, 24, 442, DateTimeKind.Local).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 29, 9, 43, 24, 442, DateTimeKind.Local).AddTicks(7448), new DateTime(2025, 10, 29, 9, 43, 24, 442, DateTimeKind.Local).AddTicks(7449) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 29, 9, 43, 24, 442, DateTimeKind.Local).AddTicks(7451), new DateTime(2025, 10, 29, 9, 43, 24, 442, DateTimeKind.Local).AddTicks(7452) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 29, 9, 43, 24, 442, DateTimeKind.Local).AddTicks(7454), new DateTime(2025, 10, 29, 9, 43, 24, 442, DateTimeKind.Local).AddTicks(7455) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 29, 9, 43, 24, 442, DateTimeKind.Local).AddTicks(7456), new DateTime(2025, 10, 29, 9, 43, 24, 442, DateTimeKind.Local).AddTicks(7457) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 29, 9, 43, 24, 442, DateTimeKind.Local).AddTicks(7458), new DateTime(2025, 10, 29, 9, 43, 24, 442, DateTimeKind.Local).AddTicks(7459) });
        }
    }
}
