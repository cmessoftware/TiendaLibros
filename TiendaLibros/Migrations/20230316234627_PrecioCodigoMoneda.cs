using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TiendaLibro.Migrations
{
    /// <inheritdoc />
    public partial class PrecioCodigoMoneda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Formato_LibroDetalle_LibroDetalleId",
                table: "Formato");

            migrationBuilder.AlterColumn<string>(
                name: "ResumenLink",
                table: "Libro",
                type: "varchar(256)",
                unicode: false,
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(256)",
                oldUnicode: false,
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<int>(
                name: "LibroDetalleId",
                table: "Formato",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CodigoMoneda",
                table: "Formato",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Formato_LibroDetalle_LibroDetalleId",
                table: "Formato",
                column: "LibroDetalleId",
                principalTable: "LibroDetalle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Formato_LibroDetalle_LibroDetalleId",
                table: "Formato");

            migrationBuilder.AlterColumn<string>(
                name: "ResumenLink",
                table: "Libro",
                type: "varchar(256)",
                unicode: false,
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(256)",
                oldUnicode: false,
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LibroDetalleId",
                table: "Formato",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CodigoMoneda",
                table: "Formato",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AddForeignKey(
                name: "FK_Formato_LibroDetalle_LibroDetalleId",
                table: "Formato",
                column: "LibroDetalleId",
                principalTable: "LibroDetalle",
                principalColumn: "Id");
        }
    }
}
