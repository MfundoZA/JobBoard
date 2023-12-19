using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobBoard.Data.Migrations
{
    public partial class FirstClassCitizenBridgeTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfileCertifications");

            migrationBuilder.DropTable(
                name: "ProfileOpenings");

            migrationBuilder.DropTable(
                name: "ProfileSkills");
        }
    }
}
