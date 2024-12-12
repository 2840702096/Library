using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Persistence.Migrations
{
    public partial class mig_MessageCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Books_MessageSettings_MessageSettingsId",
                table: "Users_Books");

            migrationBuilder.DropIndex(
                name: "IX_Users_Books_MessageSettingsId",
                table: "Users_Books");

            migrationBuilder.DropColumn(
                name: "MessageSettingsId",
                table: "Users_Books");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MessageSettings");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "MessageSettings",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "MessageSettings");

            migrationBuilder.AddColumn<int>(
                name: "MessageSettingsId",
                table: "Users_Books",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MessageSettings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Books_MessageSettingsId",
                table: "Users_Books",
                column: "MessageSettingsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Books_MessageSettings_MessageSettingsId",
                table: "Users_Books",
                column: "MessageSettingsId",
                principalTable: "MessageSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
