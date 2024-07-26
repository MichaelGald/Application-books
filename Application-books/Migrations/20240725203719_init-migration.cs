using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application_books.Migrations
{
    /// <inheritdoc />
    public partial class initmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "autor",
                schema: "dbo",
                columns: table => new
                {
                    id_autor = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    autor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    bibliografia = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_autor", x => x.id_autor);
                });

            migrationBuilder.CreateTable(
                name: "usuario",
                schema: "dbo",
                columns: table => new
                {
                    id_usuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    cliente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.id_usuario);
                });

            migrationBuilder.CreateTable(
                name: "libros_book",
                schema: "dbo",
                columns: table => new
                {
                    id_libro = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    titulo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    genero = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FechadeCreación = table.Column<DateTime>(name: "Fecha de Creación", type: "datetime2", maxLength: 50, nullable: false),
                    pdf_libro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    id_autor = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_libros_book", x => x.id_libro);
                    table.ForeignKey(
                        name: "FK_libros_book_autor_id_autor",
                        column: x => x.id_autor,
                        principalSchema: "dbo",
                        principalTable: "autor",
                        principalColumn: "id_autor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "membresia",
                schema: "dbo",
                columns: table => new
                {
                    id_membresia = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    id_usuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tipo_columna = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fecha_inicio = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    fecha_fin = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_membresia", x => x.id_membresia);
                    table.ForeignKey(
                        name: "FK_membresia_usuario_id_membresia",
                        column: x => x.id_membresia,
                        principalSchema: "dbo",
                        principalTable: "usuario",
                        principalColumn: "id_usuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "calificacion",
                schema: "dbo",
                columns: table => new
                {
                    id_calificacion = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    id_libro = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    id_usuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    calificacion = table.Column<int>(type: "int", nullable: false),
                    comentario = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    fecha = table.Column<DateTime>(type: "datetime2", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_calificacion", x => x.id_calificacion);
                    table.ForeignKey(
                        name: "FK_calificacion_libros_book_id_libro",
                        column: x => x.id_libro,
                        principalSchema: "dbo",
                        principalTable: "libros_book",
                        principalColumn: "id_libro",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_calificacion_usuario_id_usuario",
                        column: x => x.id_usuario,
                        principalSchema: "dbo",
                        principalTable: "usuario",
                        principalColumn: "id_usuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "lista_favorito",
                schema: "dbo",
                columns: table => new
                {
                    id_listafavorito = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    id_usuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    id_libro = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lista_favorito", x => x.id_listafavorito);
                    table.ForeignKey(
                        name: "FK_lista_favorito_libros_book_id_libro",
                        column: x => x.id_libro,
                        principalSchema: "dbo",
                        principalTable: "libros_book",
                        principalColumn: "id_libro",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_lista_favorito_usuario_id_usuario",
                        column: x => x.id_usuario,
                        principalSchema: "dbo",
                        principalTable: "usuario",
                        principalColumn: "id_usuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_calificacion_id_libro",
                schema: "dbo",
                table: "calificacion",
                column: "id_libro");

            migrationBuilder.CreateIndex(
                name: "IX_calificacion_id_usuario",
                schema: "dbo",
                table: "calificacion",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_libros_book_id_autor",
                schema: "dbo",
                table: "libros_book",
                column: "id_autor");

            migrationBuilder.CreateIndex(
                name: "IX_lista_favorito_id_libro",
                schema: "dbo",
                table: "lista_favorito",
                column: "id_libro");

            migrationBuilder.CreateIndex(
                name: "IX_lista_favorito_id_usuario",
                schema: "dbo",
                table: "lista_favorito",
                column: "id_usuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "calificacion",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "lista_favorito",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "membresia",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "libros_book",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "usuario",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "autor",
                schema: "dbo");
        }
    }
}
