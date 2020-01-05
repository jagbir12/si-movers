using Microsoft.EntityFrameworkCore.Migrations;

namespace si_movers.Migrations
{
    public partial class addpersontable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    Street = table.Column<string>(maxLength: 100, nullable: true),
                    Housenumber = table.Column<string>(maxLength: 20, nullable: true),
                    City = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
