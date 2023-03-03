using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TiendaLibro.Migrations
{
    /// <inheritdoc />
    public partial class ISBNLibros : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
                name: "ISBN",
                table: "Libro",
                nullable: true,
                maxLength: 16);

         }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ISBN",
                table: "Libro"
            );
        }
    }
}
