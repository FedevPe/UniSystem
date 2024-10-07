using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversitarySystem.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class NewColumnsTableCollegeCareers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Duration",
                table: "CollegeCareers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mode",
                table: "CollegeCareers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "CollegeCareers",
                type: "bit",
                nullable: false,
                defaultValue: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mode",
                table: "CollegeCareers");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "CollegeCareers");

            migrationBuilder.AlterColumn<string>(
                name: "Duration",
                table: "CollegeCareers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);
        }
    }
}
