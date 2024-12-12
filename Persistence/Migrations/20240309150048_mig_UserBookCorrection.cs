using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Persistence.Migrations
{
    public partial class mig_UserBookCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDelete",
                table: "Users_Books",
                newName: "IsPaid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsPaid",
                table: "Users_Books",
                newName: "IsDelete");
        }
    }
}
