using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversitarySystem.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class NewColumnTableStudents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "PendingMatters",
                table: "Students",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PendingMatters",
                table: "Students");
        }
    }
}
