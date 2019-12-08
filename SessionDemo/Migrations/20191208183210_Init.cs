using Microsoft.EntityFrameworkCore.Migrations;

namespace SessionDemo.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Classroom = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Classroom", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "P3", "Adam", "Aladin" },
                    { 2, "P3", "Bob", "Brumbál" },
                    { 3, "P3", "Cyrus", "Casper" },
                    { 4, "P3", "Daniel", "Drakula" },
                    { 5, "P3", "Eve", "Elektra" },
                    { 6, "P3", "Filip", "Frankenstein" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
