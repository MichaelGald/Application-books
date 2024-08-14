using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application_books.Migrations
{
    /// <inheritdoc />
    public partial class promediocalifica : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "calificacion",
                schema: "dbo",
                table: "calificacion",
                newName: "Puntuacion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Puntuacion",
                schema: "dbo",
                table: "calificacion",
                newName: "calificacion");
        }
    }
}
