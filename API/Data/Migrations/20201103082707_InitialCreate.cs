using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Todos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    IsDone = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Created", "Description" },
                values: new object[] { 1, new DateTime(2020, 11, 3, 10, 27, 6, 406, DateTimeKind.Local).AddTicks(943), "Task1" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Created", "Description" },
                values: new object[] { 2, new DateTime(2020, 11, 3, 10, 27, 6, 412, DateTimeKind.Local).AddTicks(6704), "Task2" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Created", "Description" },
                values: new object[] { 3, new DateTime(2020, 11, 3, 10, 27, 6, 412, DateTimeKind.Local).AddTicks(6781), "Task3" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Created", "Description" },
                values: new object[] { 4, new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "TAsk4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todos");
        }
    }
}
