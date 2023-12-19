using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobBoard.Data.Migrations
{
    public partial class NullabilityAndProfileOpenings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CityBased",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "MilestoneType",
                table: "Milestones",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfileOpenings");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CityBased",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OpeningId",
                table: "Profiles",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MilestoneType",
                table: "Milestones",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_OpeningId",
                table: "Profiles",
                column: "OpeningId");

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_Openings_OpeningId",
                table: "Profiles",
                column: "OpeningId",
                principalTable: "Openings",
                principalColumn: "Id");
        }
    }
}
