using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STRATEGY.WEBAPI.Migrations
{
    /// <inheritdoc />
    public partial class ChnageAddPlanFieldsVisibilityFlags : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
