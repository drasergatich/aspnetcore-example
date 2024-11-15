using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Empresa.Proyecto.Infra.Migrations
{
    public partial class AddColumnEntityOptionMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EntityOption",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SimpleEntityId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityOption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntityOption_SimpleEntity_SimpleEntityId",
                        column: x => x.SimpleEntityId,
                        principalTable: "SimpleEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 11, 15, 9, 55, 25, 451, DateTimeKind.Local).AddTicks(6373), new DateTime(2024, 11, 15, 9, 55, 25, 451, DateTimeKind.Local).AddTicks(6384) });

            migrationBuilder.CreateIndex(
                name: "IX_EntityOption_SimpleEntityId",
                table: "EntityOption",
                column: "SimpleEntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntityOption");

            migrationBuilder.UpdateData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 11, 15, 8, 53, 7, 724, DateTimeKind.Local).AddTicks(8111), new DateTime(2024, 11, 15, 8, 53, 7, 724, DateTimeKind.Local).AddTicks(8119) });
        }
    }
}
