using Microsoft.EntityFrameworkCore.Migrations;

namespace kingpin.Migrations
{
    public partial class notuservaladded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NotForUserFacing",
                table: "Articles",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NotForUserFacing",
                table: "Articles");
        }
    }
}
