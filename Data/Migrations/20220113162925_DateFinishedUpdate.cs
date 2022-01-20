using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskRegistrationSystem.Data.Migrations
{
    public partial class DateFinishedUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FinishDate",
                table: "Task",
                newName: "DateFinished");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateFinished",
                table: "Task",
                newName: "FinishDate");
        }
    }
}
