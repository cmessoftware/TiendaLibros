using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TiendaLibros.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Libro",
                columns: new[] { "Id", "FechaPublicacion", "Genero", "Precio", "Titulo" },
                values: new object[,]
                {
                    { 1, new DateTime(2012, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genero1", 2400m, "Libro1" },
                    { 2, new DateTime(2008, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genero2", 3000m, "Libro2" },
                    { 3, new DateTime(2008, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genero3", 3000m, "Libro3" },
                    { 4, new DateTime(2008, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genero4", 3000m, "Libro4" },
                    { 5, new DateTime(2008, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genero5", 6000m, "Libro5" },
                    { 6, new DateTime(2008, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genero6", 4000m, "Libro6" },
                    { 7, new DateTime(2008, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genero7", 4500m, "Libro7" },
                    { 8, new DateTime(2008, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genero8", 4500m, "Libro8" },
                    { 9, new DateTime(2008, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genero9", 6600m, "Libro9" },
                    { 10, new DateTime(2008, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genero10", 7000m, "Libro10" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Libro",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Libro",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Libro",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Libro",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Libro",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Libro",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Libro",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Libro",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Libro",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Libro",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
