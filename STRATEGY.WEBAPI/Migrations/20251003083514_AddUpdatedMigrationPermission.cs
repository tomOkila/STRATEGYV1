using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STRATEGY.WEBAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddUpdatedMigrationPermission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionId", "Create", "CreateDate", "Delete", "PermissionName", "Update", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 3, false, new DateTime(2025, 10, 3, 11, 35, 13, 987, DateTimeKind.Local).AddTicks(7014), false, "Visitor", false, 0, new DateTime(2025, 10, 3, 11, 35, 13, 987, DateTimeKind.Local).AddTicks(7014) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
