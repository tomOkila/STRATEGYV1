using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace STRATEGY.WEBAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddSeededRoleMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreateDate", "RoleName", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 3, 11, 44, 26, 897, DateTimeKind.Local).AddTicks(9881), "Admin", 0, new DateTime(2025, 10, 3, 11, 44, 26, 897, DateTimeKind.Local).AddTicks(9882) },
                    { 2, new DateTime(2025, 10, 3, 11, 44, 26, 897, DateTimeKind.Local).AddTicks(9883), "User", 0, new DateTime(2025, 10, 3, 11, 44, 26, 897, DateTimeKind.Local).AddTicks(9884) },
                    { 3, new DateTime(2025, 10, 3, 11, 44, 26, 897, DateTimeKind.Local).AddTicks(9885), "Visitor", 0, new DateTime(2025, 10, 3, 11, 44, 26, 897, DateTimeKind.Local).AddTicks(9885) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 3, 11, 35, 13, 987, DateTimeKind.Local).AddTicks(6997), new DateTime(2025, 10, 3, 11, 35, 13, 987, DateTimeKind.Local).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 3, 11, 35, 13, 987, DateTimeKind.Local).AddTicks(7012), new DateTime(2025, 10, 3, 11, 35, 13, 987, DateTimeKind.Local).AddTicks(7012) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 3, 11, 35, 13, 987, DateTimeKind.Local).AddTicks(7014), new DateTime(2025, 10, 3, 11, 35, 13, 987, DateTimeKind.Local).AddTicks(7014) });
        }
    }
}
