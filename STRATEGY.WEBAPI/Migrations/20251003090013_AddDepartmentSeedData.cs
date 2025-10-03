using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STRATEGY.WEBAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddDepartmentSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "CreateDate", "DepartmentManager", "DepartmentName", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2025, 10, 3, 12, 0, 13, 489, DateTimeKind.Local).AddTicks(2179), "Head IT", "IT Department", 0, new DateTime(2025, 10, 3, 12, 0, 13, 489, DateTimeKind.Local).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 3, 12, 0, 13, 489, DateTimeKind.Local).AddTicks(2019), new DateTime(2025, 10, 3, 12, 0, 13, 489, DateTimeKind.Local).AddTicks(2033) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 3, 12, 0, 13, 489, DateTimeKind.Local).AddTicks(2034), new DateTime(2025, 10, 3, 12, 0, 13, 489, DateTimeKind.Local).AddTicks(2035) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 3, 12, 0, 13, 489, DateTimeKind.Local).AddTicks(2036), new DateTime(2025, 10, 3, 12, 0, 13, 489, DateTimeKind.Local).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 3, 12, 0, 13, 489, DateTimeKind.Local).AddTicks(2157), new DateTime(2025, 10, 3, 12, 0, 13, 489, DateTimeKind.Local).AddTicks(2158) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 3, 12, 0, 13, 489, DateTimeKind.Local).AddTicks(2158), new DateTime(2025, 10, 3, 12, 0, 13, 489, DateTimeKind.Local).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 3, 12, 0, 13, 489, DateTimeKind.Local).AddTicks(2160), new DateTime(2025, 10, 3, 12, 0, 13, 489, DateTimeKind.Local).AddTicks(2160) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 3, 11, 44, 26, 897, DateTimeKind.Local).AddTicks(9698), new DateTime(2025, 10, 3, 11, 44, 26, 897, DateTimeKind.Local).AddTicks(9713) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 3, 11, 44, 26, 897, DateTimeKind.Local).AddTicks(9715), new DateTime(2025, 10, 3, 11, 44, 26, 897, DateTimeKind.Local).AddTicks(9716) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 3, 11, 44, 26, 897, DateTimeKind.Local).AddTicks(9717), new DateTime(2025, 10, 3, 11, 44, 26, 897, DateTimeKind.Local).AddTicks(9718) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 3, 11, 44, 26, 897, DateTimeKind.Local).AddTicks(9881), new DateTime(2025, 10, 3, 11, 44, 26, 897, DateTimeKind.Local).AddTicks(9882) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 3, 11, 44, 26, 897, DateTimeKind.Local).AddTicks(9883), new DateTime(2025, 10, 3, 11, 44, 26, 897, DateTimeKind.Local).AddTicks(9884) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 3, 11, 44, 26, 897, DateTimeKind.Local).AddTicks(9885), new DateTime(2025, 10, 3, 11, 44, 26, 897, DateTimeKind.Local).AddTicks(9885) });
        }
    }
}
