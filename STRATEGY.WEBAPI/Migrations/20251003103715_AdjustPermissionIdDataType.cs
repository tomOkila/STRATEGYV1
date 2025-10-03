using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STRATEGY.WEBAPI.Migrations
{
    /// <inheritdoc />
    public partial class AdjustPermissionIdDataType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PermissionId",
                table: "UserRoles",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 3, 13, 37, 15, 87, DateTimeKind.Local).AddTicks(5190), new DateTime(2025, 10, 3, 13, 37, 15, 87, DateTimeKind.Local).AddTicks(5191) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 3, 13, 37, 15, 87, DateTimeKind.Local).AddTicks(4957), new DateTime(2025, 10, 3, 13, 37, 15, 87, DateTimeKind.Local).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 3, 13, 37, 15, 87, DateTimeKind.Local).AddTicks(4978), new DateTime(2025, 10, 3, 13, 37, 15, 87, DateTimeKind.Local).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 3, 13, 37, 15, 87, DateTimeKind.Local).AddTicks(4981), new DateTime(2025, 10, 3, 13, 37, 15, 87, DateTimeKind.Local).AddTicks(4982) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 3, 13, 37, 15, 87, DateTimeKind.Local).AddTicks(5155), new DateTime(2025, 10, 3, 13, 37, 15, 87, DateTimeKind.Local).AddTicks(5156) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 3, 13, 37, 15, 87, DateTimeKind.Local).AddTicks(5158), new DateTime(2025, 10, 3, 13, 37, 15, 87, DateTimeKind.Local).AddTicks(5159) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 3, 13, 37, 15, 87, DateTimeKind.Local).AddTicks(5160), new DateTime(2025, 10, 3, 13, 37, 15, 87, DateTimeKind.Local).AddTicks(5161) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PermissionId",
                table: "UserRoles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 3, 12, 0, 13, 489, DateTimeKind.Local).AddTicks(2179), new DateTime(2025, 10, 3, 12, 0, 13, 489, DateTimeKind.Local).AddTicks(2180) });

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
    }
}
