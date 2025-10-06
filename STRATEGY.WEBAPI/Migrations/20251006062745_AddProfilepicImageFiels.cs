using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STRATEGY.WEBAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddProfilepicImageFiels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfileImage",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 6, 9, 27, 45, 412, DateTimeKind.Local).AddTicks(6883), new DateTime(2025, 10, 6, 9, 27, 45, 412, DateTimeKind.Local).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 6, 9, 27, 45, 412, DateTimeKind.Local).AddTicks(6721), new DateTime(2025, 10, 6, 9, 27, 45, 412, DateTimeKind.Local).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 6, 9, 27, 45, 412, DateTimeKind.Local).AddTicks(6741), new DateTime(2025, 10, 6, 9, 27, 45, 412, DateTimeKind.Local).AddTicks(6742) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 6, 9, 27, 45, 412, DateTimeKind.Local).AddTicks(6743), new DateTime(2025, 10, 6, 9, 27, 45, 412, DateTimeKind.Local).AddTicks(6744) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 6, 9, 27, 45, 412, DateTimeKind.Local).AddTicks(6860), new DateTime(2025, 10, 6, 9, 27, 45, 412, DateTimeKind.Local).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 6, 9, 27, 45, 412, DateTimeKind.Local).AddTicks(6862), new DateTime(2025, 10, 6, 9, 27, 45, 412, DateTimeKind.Local).AddTicks(6863) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 6, 9, 27, 45, 412, DateTimeKind.Local).AddTicks(6864), new DateTime(2025, 10, 6, 9, 27, 45, 412, DateTimeKind.Local).AddTicks(6864) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfileImage",
                table: "Users");

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
    }
}
