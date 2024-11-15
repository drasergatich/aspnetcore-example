using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Empresa.Proyecto.Infra.Migrations
{
    public partial class BdNuevosRegistrosCatalogoMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 11, 15, 10, 12, 23, 487, DateTimeKind.Local).AddTicks(309), new DateTime(2024, 11, 15, 10, 12, 23, 487, DateTimeKind.Local).AddTicks(318) });

            migrationBuilder.InsertData(
                table: "SimpleEntity",
                columns: new[] { "Id", "Created", "Modified", "Name", "Value" },
                values: new object[,]
                {
                    { 4, new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Activo", null },
                    { 5, new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactivo", null },
                    { 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pendiente", null },
                    { 7, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completado", null },
                    { 8, new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cancelado", null },
                    { 9, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "En progreso", null },
                    { 10, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Procesado", null },
                    { 11, new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Revisado", null },
                    { 12, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Autorizado", null },
                    { 13, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Denegado", null },
                    { 14, new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Suspendido", null },
                    { 15, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expirado", null },
                    { 16, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Temporal", null },
                    { 17, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Permanente", null },
                    { 18, new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Provisional", null },
                    { 19, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finalizado", null },
                    { 20, new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reprogramado", null },
                    { 21, new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Duplicado", null },
                    { 22, new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Original", null },
                    { 23, new DateTime(2023, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Activo temporal", null },
                    { 24, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Listo para envío", null },
                    { 25, new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "En espera", null },
                    { 26, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nuevo cliente", null },
                    { 27, new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cliente recurrente", null },
                    { 28, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Producto especial", null },
                    { 29, new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Servicio personalizado", null },
                    { 30, new DateTime(2024, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "En evaluación", null },
                    { 31, new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aprobado", null },
                    { 32, new DateTime(2022, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "En corrección", null },
                    { 33, new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Concluido", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.UpdateData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 11, 15, 9, 55, 25, 451, DateTimeKind.Local).AddTicks(6373), new DateTime(2024, 11, 15, 9, 55, 25, 451, DateTimeKind.Local).AddTicks(6384) });
        }
    }
}
