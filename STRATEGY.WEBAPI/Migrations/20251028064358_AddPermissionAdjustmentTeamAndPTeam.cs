using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STRATEGY.WEBAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddPermissionAdjustmentTeamAndPTeam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 28, 9, 43, 58, 375, DateTimeKind.Local).AddTicks(5309), new DateTime(2025, 10, 28, 9, 43, 58, 375, DateTimeKind.Local).AddTicks(5309) });

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
                columns: new[] { "Create", "CreateDate", "Update", "UpdatedDate" },
                values: new object[] { false, new DateTime(2025, 10, 28, 9, 43, 58, 375, DateTimeKind.Local).AddTicks(5313), false, new DateTime(2025, 10, 28, 9, 43, 58, 375, DateTimeKind.Local).AddTicks(5313) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 5,
                columns: new[] { "Create", "CreateDate", "Update", "UpdatedDate" },
                values: new object[] { false, new DateTime(2025, 10, 28, 9, 43, 58, 375, DateTimeKind.Local).AddTicks(5314), false, new DateTime(2025, 10, 28, 9, 43, 58, 375, DateTimeKind.Local).AddTicks(5315) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 4,
                columns: new[] { "Create", "CreateDate", "Update", "UpdatedDate" },
                values: new object[] { true, new DateTime(2025, 10, 17, 12, 40, 2, 128, DateTimeKind.Local).AddTicks(3996), true, new DateTime(2025, 10, 17, 12, 40, 2, 128, DateTimeKind.Local).AddTicks(3997) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 5,
                columns: new[] { "Create", "CreateDate", "Update", "UpdatedDate" },
                values: new object[] { true, new DateTime(2025, 10, 17, 12, 40, 2, 128, DateTimeKind.Local).AddTicks(3999), true, new DateTime(2025, 10, 17, 12, 40, 2, 128, DateTimeKind.Local).AddTicks(4000) });

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

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 17, 12, 40, 2, 128, DateTimeKind.Local).AddTicks(4190), new DateTime(2025, 10, 17, 12, 40, 2, 128, DateTimeKind.Local).AddTicks(4191) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 17, 12, 40, 2, 128, DateTimeKind.Local).AddTicks(4193), new DateTime(2025, 10, 17, 12, 40, 2, 128, DateTimeKind.Local).AddTicks(4194) });
        }
    }
}
