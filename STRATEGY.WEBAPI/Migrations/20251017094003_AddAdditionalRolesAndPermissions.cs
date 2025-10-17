using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace STRATEGY.WEBAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddAdditionalRolesAndPermissions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 17, 12, 40, 2, 128, DateTimeKind.Local).AddTicks(4232), new DateTime(2025, 10, 17, 12, 40, 2, 128, DateTimeKind.Local).AddTicks(4233) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 17, 12, 40, 2, 128, DateTimeKind.Local).AddTicks(3971), new DateTime(2025, 10, 17, 12, 40, 2, 128, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 17, 12, 40, 2, 128, DateTimeKind.Local).AddTicks(3991), new DateTime(2025, 10, 17, 12, 40, 2, 128, DateTimeKind.Local).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 17, 12, 40, 2, 128, DateTimeKind.Local).AddTicks(3994), new DateTime(2025, 10, 17, 12, 40, 2, 128, DateTimeKind.Local).AddTicks(3994) });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionId", "Create", "CreateDate", "Delete", "PermissionName", "Update", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 4, true, new DateTime(2025, 10, 17, 12, 40, 2, 128, DateTimeKind.Local).AddTicks(3996), false, "Team", true, 0, new DateTime(2025, 10, 17, 12, 40, 2, 128, DateTimeKind.Local).AddTicks(3997) },
                    { 5, true, new DateTime(2025, 10, 17, 12, 40, 2, 128, DateTimeKind.Local).AddTicks(3999), false, "Pteam", true, 0, new DateTime(2025, 10, 17, 12, 40, 2, 128, DateTimeKind.Local).AddTicks(4000) }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 17, 12, 40, 2, 128, DateTimeKind.Local).AddTicks(4182), new DateTime(2025, 10, 17, 12, 40, 2, 128, DateTimeKind.Local).AddTicks(4183) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 17, 12, 40, 2, 128, DateTimeKind.Local).AddTicks(4186), new DateTime(2025, 10, 17, 12, 40, 2, 128, DateTimeKind.Local).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 17, 12, 40, 2, 128, DateTimeKind.Local).AddTicks(4188), new DateTime(2025, 10, 17, 12, 40, 2, 128, DateTimeKind.Local).AddTicks(4189) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreateDate", "RoleName", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 4, new DateTime(2025, 10, 17, 12, 40, 2, 128, DateTimeKind.Local).AddTicks(4190), "Team", 0, new DateTime(2025, 10, 17, 12, 40, 2, 128, DateTimeKind.Local).AddTicks(4191) },
                    { 5, new DateTime(2025, 10, 17, 12, 40, 2, 128, DateTimeKind.Local).AddTicks(4193), "Pteam", 0, new DateTime(2025, 10, 17, 12, 40, 2, 128, DateTimeKind.Local).AddTicks(4194) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5);

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
    }
}
