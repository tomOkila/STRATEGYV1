using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STRATEGY.WEBAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddPlanDocumentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlanDocuments",
                columns: table => new
                {
                    PlanDocumentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanID = table.Column<int>(type: "int", nullable: false),
                    DocumentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanDocuments", x => x.PlanDocumentId);
                    table.ForeignKey(
                        name: "FK_PlanDocuments_Plans_PlanID",
                        column: x => x.PlanID,
                        principalTable: "Plans",
                        principalColumn: "PlanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 13, 10, 59, 28, 127, DateTimeKind.Local).AddTicks(9817), new DateTime(2025, 10, 13, 10, 59, 28, 127, DateTimeKind.Local).AddTicks(9818) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 13, 10, 59, 28, 127, DateTimeKind.Local).AddTicks(9631), new DateTime(2025, 10, 13, 10, 59, 28, 127, DateTimeKind.Local).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 13, 10, 59, 28, 127, DateTimeKind.Local).AddTicks(9648), new DateTime(2025, 10, 13, 10, 59, 28, 127, DateTimeKind.Local).AddTicks(9649) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 13, 10, 59, 28, 127, DateTimeKind.Local).AddTicks(9650), new DateTime(2025, 10, 13, 10, 59, 28, 127, DateTimeKind.Local).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 13, 10, 59, 28, 127, DateTimeKind.Local).AddTicks(9788), new DateTime(2025, 10, 13, 10, 59, 28, 127, DateTimeKind.Local).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 13, 10, 59, 28, 127, DateTimeKind.Local).AddTicks(9791), new DateTime(2025, 10, 13, 10, 59, 28, 127, DateTimeKind.Local).AddTicks(9792) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 13, 10, 59, 28, 127, DateTimeKind.Local).AddTicks(9793), new DateTime(2025, 10, 13, 10, 59, 28, 127, DateTimeKind.Local).AddTicks(9793) });

            migrationBuilder.CreateIndex(
                name: "IX_PlanDocuments_PlanID",
                table: "PlanDocuments",
                column: "PlanID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlanDocuments");

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
    }
}
