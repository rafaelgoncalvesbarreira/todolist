using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoList.Business.EntityFramework.Migrations
{
    public partial class Task_Tite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Tasks",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Tasks");
        }
    }
}
