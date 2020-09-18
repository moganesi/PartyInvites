using Microsoft.EntityFrameworkCore.Migrations;

namespace PartyInvites.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "City",
            //    columns: table => new
            //    {
            //        city_Id = table.Column<int>(type: "int", nullable: false),
            //        name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        name_ascii = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        lat = table.Column<decimal>(type: "decimal(7, 4)", nullable: true),
            //        lon = table.Column<decimal>(type: "decimal(7, 4)", nullable: true),
            //        country_id = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_City", x => x.city_Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Country",
            //    columns: table => new
            //    {
            //        country_Id = table.Column<int>(type: "int", nullable: false),
            //        name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        iso2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        iso3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Country", x => x.country_Id);
            //    });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
