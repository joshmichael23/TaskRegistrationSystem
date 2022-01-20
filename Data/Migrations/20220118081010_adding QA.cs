using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskRegistrationSystem.Data.Migrations
{
    public partial class addingQA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "QA",
                table: "Task",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "-");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QA",
                table: "Task");
        }
    }
}
