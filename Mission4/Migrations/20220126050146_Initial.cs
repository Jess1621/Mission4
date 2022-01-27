using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission4.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    ApplicationID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.ApplicationID);
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "ApplicationID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Action", "Doug Liman", false, "", "Awesome Movie!", "PG-13", "Jason Bourne: Bourne Identity", 2002 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "ApplicationID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Sports Drama", "Gavin O'Conner", false, "", "Watch alone, makes me emotional", "PG-13", "Warrior", 2011 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "ApplicationID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Science Fiction", "Denis Villeneuve", false, "", "Super Awesome Movie, should read the book too...", "PG-13", "Dune", 2021 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
