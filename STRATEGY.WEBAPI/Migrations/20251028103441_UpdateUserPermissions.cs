using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STRATEGY.WEBAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserPermissions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Create", "CreateDate", "Delete", "Update", "UpdatedDate" },
                values: new object[] { true, new DateTime(2025, 10, 28, 13, 34, 41, 429, DateTimeKind.Local).AddTicks(1159), true, true, new DateTime(2025, 10, 28, 13, 34, 41, 429, DateTimeKind.Local).AddTicks(1160) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 28, 9, 43, 58, 375, DateTimeKind.Local).AddTicks(5549), new DateTime(2025, 10, 28, 9, 43, 58, 375, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 28, 9, 43, 58, 375, DateTimeKind.Local).AddTicks(5291), new DateTime(2025, 10, 28, 9, 43, 58, 375, DateTimeKind.Local).AddTicks(5307) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 2,
                columns: new[] { "Create", "CreateDate", "Delete", "Update", "UpdatedDate" },
                values: new object[] { false, new DateTime(2025, 10, 28, 9, 43, 58, 375, DateTimeKind.Local).AddTicks(5309), false, false, new DateTime(2025, 10, 28, 9, 43, 58, 375, DateTimeKind.Local).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 28, 9, 43, 58, 375, DateTimeKind.Local).AddTicks(5311), new DateTime(2025, 10, 28, 9, 43, 58, 375, DateTimeKind.Local).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 28, 9, 43, 58, 375, DateTimeKind.Local).AddTicks(5313), new DateTime(2025, 10, 28, 9, 43, 58, 375, DateTimeKind.Local).AddTicks(5313) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 28, 9, 43, 58, 375, DateTimeKind.Local).AddTicks(5314), new DateTime(2025, 10, 28, 9, 43, 58, 375, DateTimeKind.Local).AddTicks(5315) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 28, 9, 43, 58, 375, DateTimeKind.Local).AddTicks(5516), new DateTime(2025, 10, 28, 9, 43, 58, 375, DateTimeKind.Local).AddTicks(5517) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 28, 9, 43, 58, 375, DateTimeKind.Local).AddTicks(5518), new DateTime(2025, 10, 28, 9, 43, 58, 375, DateTimeKind.Local).AddTicks(5519) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 28, 9, 43, 58, 375, DateTimeKind.Local).AddTicks(5520), new DateTime(2025, 10, 28, 9, 43, 58, 375, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 28, 9, 43, 58, 375, DateTimeKind.Local).AddTicks(5521), new DateTime(2025, 10, 28, 9, 43, 58, 375, DateTimeKind.Local).AddTicks(5522) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 28, 9, 43, 58, 375, DateTimeKind.Local).AddTicks(5523), new DateTime(2025, 10, 28, 9, 43, 58, 375, DateTimeKind.Local).AddTicks(5523) });
        }
    }
}
