using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application_books.Migrations
{
    /// <inheritdoc />
    public partial class comentario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comentarios",
                columns: table => new
                {
                    id_comentario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    id_libro = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    id_usuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    comentario = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentarios", x => x.id_comentario);
                    table.ForeignKey(
                        name: "FK_Comentarios_libros_book_id_libro",
                        column: x => x.id_libro,
                        principalSchema: "dbo",
                        principalTable: "libros_book",
                        principalColumn: "id_libro",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comentarios_usuario_id_usuario",
                        column: x => x.id_usuario,
                        principalSchema: "dbo",
                        principalTable: "usuario",
                        principalColumn: "id_usuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_id_libro",
                table: "Comentarios",
                column: "id_libro");

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_id_usuario",
                table: "Comentarios",
                column: "id_usuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comentarios");
        }
    }
}
