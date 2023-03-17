using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TiendaLibro.Migrations
{
    /// <inheritdoc />
    public partial class Simplificacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LibroDetalle_Libro",
                table: "LibroDetalle");

            migrationBuilder.DropColumn(
                name: "PortadaLink",
                table: "LibroDetalle");

            migrationBuilder.DropColumn(
                name: "Resumen",
                table: "LibroDetalle");

            migrationBuilder.DropColumn(
                name: "ResumenLink",
                table: "LibroDetalle");

            migrationBuilder.DropColumn(
                name: "ISBN",
                table: "Libro");

            migrationBuilder.RenameColumn(
                name: "LibroDetalleFormatoId",
                table: "Moneda",
                newName: "FormatoId");

            migrationBuilder.RenameIndex(
                name: "IX_Moneda_LibroDetalleFormatoId",
                table: "Moneda",
                newName: "IX_Moneda_FormatoId");

            migrationBuilder.RenameColumn(
                name: "LibroDetalleFormatoId",
                table: "Formato",
                newName: "LibroDetalleId");

            migrationBuilder.RenameIndex(
                name: "IX_Formato_LibroDetalleFormatoId",
                table: "Formato",
                newName: "IX_Formato_LibroDetalleId");

            migrationBuilder.AlterColumn<string>(
                name: "ISBN",
                table: "LibroDetalle",
                type: "varchar(16)",
                unicode: false,
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<int>(
                name: "Edicion",
                table: "LibroDetalle",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PortadaLink",
                table: "Libro",
                type: "varchar(256)",
                unicode: false,
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Resumen",
                table: "Libro",
                type: "varchar(2000)",
                unicode: false,
                maxLength: 2000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ResumenLink",
                table: "Libro",
                type: "varchar(256)",
                unicode: false,
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CodigoMoneda",
                table: "Formato",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Precio",
                table: "Formato",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddForeignKey(
                name: "FK_Formato_LibroDetalle_LibroDetalleId",
                table: "Formato",
                column: "LibroDetalleId",
                principalTable: "LibroDetalle",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LibroDetalle_Libro_LibroId",
                table: "LibroDetalle",
                column: "LibroId",
                principalTable: "Libro",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Moneda_Formato_FormatoId",
                table: "Moneda",
                column: "FormatoId",
                principalTable: "Formato",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Formato_LibroDetalle_LibroDetalleId",
                table: "Formato");

            migrationBuilder.DropForeignKey(
                name: "FK_LibroDetalle_Libro_LibroId",
                table: "LibroDetalle");

            migrationBuilder.DropForeignKey(
                name: "FK_Moneda_Formato_FormatoId",
                table: "Moneda");

            migrationBuilder.DropColumn(
                name: "PortadaLink",
                table: "Libro");

            migrationBuilder.DropColumn(
                name: "Resumen",
                table: "Libro");

            migrationBuilder.DropColumn(
                name: "ResumenLink",
                table: "Libro");

            migrationBuilder.DropColumn(
                name: "CodigoMoneda",
                table: "Formato");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Formato");

            migrationBuilder.RenameColumn(
                name: "FormatoId",
                table: "Moneda",
                newName: "LibroDetalleFormatoId");

            migrationBuilder.RenameIndex(
                name: "IX_Moneda_FormatoId",
                table: "Moneda",
                newName: "IX_Moneda_LibroDetalleFormatoId");

            migrationBuilder.RenameColumn(
                name: "LibroDetalleId",
                table: "Formato",
                newName: "LibroDetalleFormatoId");

            migrationBuilder.RenameIndex(
                name: "IX_Formato_LibroDetalleId",
                table: "Formato",
                newName: "IX_Formato_LibroDetalleFormatoId");

            migrationBuilder.AlterColumn<string>(
                name: "ISBN",
                table: "LibroDetalle",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(16)",
                oldUnicode: false,
                oldMaxLength: 16);

            migrationBuilder.AlterColumn<int>(
                name: "Edicion",
                table: "LibroDetalle",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "PortadaLink",
                table: "LibroDetalle",
                type: "varchar(256)",
                unicode: false,
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Resumen",
                table: "LibroDetalle",
                type: "varchar(2000)",
                unicode: false,
                maxLength: 2000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResumenLink",
                table: "LibroDetalle",
                type: "varchar(256)",
                unicode: false,
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ISBN",
                table: "Libro",
                type: "varchar(16)",
                unicode: false,
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "LibroDetalleFormato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LibroDetalleId = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibroDetalleFormato", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LibroDetalleFormato_LibroDetalle_LibroDetalleId",
                        column: x => x.LibroDetalleId,
                        principalTable: "LibroDetalle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LibroDetalleFormato_LibroDetalleId",
                table: "LibroDetalleFormato",
                column: "LibroDetalleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Formato_LibroDetalleFormato",
                table: "Formato",
                column: "LibroDetalleFormatoId",
                principalTable: "LibroDetalleFormato",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LibroDetalle_Libro",
                table: "LibroDetalle",
                column: "LibroId",
                principalTable: "Libro",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Moneda_LibroDetalleFormato",
                table: "Moneda",
                column: "LibroDetalleFormatoId",
                principalTable: "LibroDetalleFormato",
                principalColumn: "Id");
        }
    }
}
