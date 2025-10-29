using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STRATEGY.WEBAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddPlanFieldsVisibilityFlags : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "DetailedStrategicObjectivesVisibility",
                table: "Plans",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "StrategicObjectivesVisibility",
                table: "Plans",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 29, 9, 12, 19, 630, DateTimeKind.Local).AddTicks(2444), new DateTime(2025, 10, 29, 9, 12, 19, 630, DateTimeKind.Local).AddTicks(2446) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 29, 9, 12, 19, 630, DateTimeKind.Local).AddTicks(1953), new DateTime(2025, 10, 29, 9, 12, 19, 630, DateTimeKind.Local).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 29, 9, 12, 19, 630, DateTimeKind.Local).AddTicks(1980), new DateTime(2025, 10, 29, 9, 12, 19, 630, DateTimeKind.Local).AddTicks(1982) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 29, 9, 12, 19, 630, DateTimeKind.Local).AddTicks(1986), new DateTime(2025, 10, 29, 9, 12, 19, 630, DateTimeKind.Local).AddTicks(1988) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 29, 9, 12, 19, 630, DateTimeKind.Local).AddTicks(1992), new DateTime(2025, 10, 29, 9, 12, 19, 630, DateTimeKind.Local).AddTicks(1993) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 29, 9, 12, 19, 630, DateTimeKind.Local).AddTicks(1997), new DateTime(2025, 10, 29, 9, 12, 19, 630, DateTimeKind.Local).AddTicks(1999) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 29, 9, 12, 19, 630, DateTimeKind.Local).AddTicks(2359), new DateTime(2025, 10, 29, 9, 12, 19, 630, DateTimeKind.Local).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 29, 9, 12, 19, 630, DateTimeKind.Local).AddTicks(2365), new DateTime(2025, 10, 29, 9, 12, 19, 630, DateTimeKind.Local).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 29, 9, 12, 19, 630, DateTimeKind.Local).AddTicks(2370), new DateTime(2025, 10, 29, 9, 12, 19, 630, DateTimeKind.Local).AddTicks(2372) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 29, 9, 12, 19, 630, DateTimeKind.Local).AddTicks(2375), new DateTime(2025, 10, 29, 9, 12, 19, 630, DateTimeKind.Local).AddTicks(2377) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 29, 9, 12, 19, 630, DateTimeKind.Local).AddTicks(2379), new DateTime(2025, 10, 29, 9, 12, 19, 630, DateTimeKind.Local).AddTicks(2381) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DetailedStrategicObjectivesVisibility",
                table: "Plans");

            migrationBuilder.DropColumn(
                name: "StrategicObjectivesVisibility",
                table: "Plans");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 28, 13, 34, 41, 429, DateTimeKind.Local).AddTicks(1350), new DateTime(2025, 10, 28, 13, 34, 41, 429, DateTimeKind.Local).AddTicks(1351) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 28, 13, 34, 41, 429, DateTimeKind.Local).AddTicks(1143), new DateTime(2025, 10, 28, 13, 34, 41, 429, DateTimeKind.Local).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 28, 13, 34, 41, 429, DateTimeKind.Local).AddTicks(1159), new DateTime(2025, 10, 28, 13, 34, 41, 429, DateTimeKind.Local).AddTicks(1160) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 28, 13, 34, 41, 429, DateTimeKind.Local).AddTicks(1161), new DateTime(2025, 10, 28, 13, 34, 41, 429, DateTimeKind.Local).AddTicks(1162) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 28, 13, 34, 41, 429, DateTimeKind.Local).AddTicks(1163), new DateTime(2025, 10, 28, 13, 34, 41, 429, DateTimeKind.Local).AddTicks(1163) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 28, 13, 34, 41, 429, DateTimeKind.Local).AddTicks(1164), new DateTime(2025, 10, 28, 13, 34, 41, 429, DateTimeKind.Local).AddTicks(1165) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 28, 13, 34, 41, 429, DateTimeKind.Local).AddTicks(1316), new DateTime(2025, 10, 28, 13, 34, 41, 429, DateTimeKind.Local).AddTicks(1318) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 28, 13, 34, 41, 429, DateTimeKind.Local).AddTicks(1319), new DateTime(2025, 10, 28, 13, 34, 41, 429, DateTimeKind.Local).AddTicks(1320) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 28, 13, 34, 41, 429, DateTimeKind.Local).AddTicks(1321), new DateTime(2025, 10, 28, 13, 34, 41, 429, DateTimeKind.Local).AddTicks(1321) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 28, 13, 34, 41, 429, DateTimeKind.Local).AddTicks(1322), new DateTime(2025, 10, 28, 13, 34, 41, 429, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 28, 13, 34, 41, 429, DateTimeKind.Local).AddTicks(1323), new DateTime(2025, 10, 28, 13, 34, 41, 429, DateTimeKind.Local).AddTicks(1324) });
        }
    }
}
