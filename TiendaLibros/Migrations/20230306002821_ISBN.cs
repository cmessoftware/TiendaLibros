using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TiendaLibro.Migrations
{
    /// <inheritdoc />
    public partial class ISBN : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_LibroDetalleFormato_LibroDetalleId",
                table: "LibroDetalleFormato",
                column: "LibroDetalleId");

            migrationBuilder.CreateIndex(
                name: "IX_Libro_GeneroId",
                table: "Libro",
                column: "GeneroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Libro_Genero_GeneroId",
                table: "Libro",
                column: "GeneroId",
                principalTable: "Genero",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LibroDetalleFormato_LibroDetalle_LibroDetalleId",
                table: "LibroDetalleFormato",
                column: "LibroDetalleId",
                principalTable: "LibroDetalle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Libro_Genero_GeneroId",
                table: "Libro");

            migrationBuilder.DropForeignKey(
                name: "FK_LibroDetalleFormato_LibroDetalle_LibroDetalleId",
                table: "LibroDetalleFormato");

            migrationBuilder.DropIndex(
                name: "IX_LibroDetalleFormato_LibroDetalleId",
                table: "LibroDetalleFormato");

            migrationBuilder.DropIndex(
                name: "IX_Libro_GeneroId",
                table: "Libro");
        }
    }
}
