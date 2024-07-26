using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application_books.Migrations
{
    /// <inheritdoc />
    public partial class fixentityLibros : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Fecha de Creación",
                schema: "dbo",
                table: "libros_book",
                newName: "created_time");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "created_time",
                schema: "dbo",
                table: "libros_book",
                newName: "Fecha de Creación");
        }
    }
}
