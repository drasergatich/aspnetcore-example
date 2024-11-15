using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Empresa.Proyecto.Infra.Migrations
{
    public partial class BdSeedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailTranslation");

            migrationBuilder.DropTable(
                name: "EmailNotifications");

            migrationBuilder.InsertData(
                table: "SimpleEntity",
                columns: new[] { "Id", "Created", "Modified", "Name", "Value" },
                values: new object[] { 1, new DateTime(2024, 11, 15, 8, 53, 7, 724, DateTimeKind.Local).AddTicks(8111), new DateTime(2024, 11, 15, 8, 53, 7, 724, DateTimeKind.Local).AddTicks(8119), "Nuevo", null });

            migrationBuilder.InsertData(
                table: "SimpleEntity",
                columns: new[] { "Id", "Created", "Modified", "Name", "Value" },
                values: new object[] { 2, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Existente", null });

            migrationBuilder.InsertData(
                table: "SimpleEntity",
                columns: new[] { "Id", "Created", "Modified", "Name", "Value" },
                values: new object[] { 3, new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reconstruido", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.CreateTable(
                name: "EmailNotifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailNotifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailTranslation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmailNotificationId = table.Column<int>(type: "int", nullable: true),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailTranslation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailTranslation_EmailNotifications_EmailNotificationId",
                        column: x => x.EmailNotificationId,
                        principalTable: "EmailNotifications",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmailTranslation_EmailNotificationId",
                table: "EmailTranslation",
                column: "EmailNotificationId");
        }
    }
}
