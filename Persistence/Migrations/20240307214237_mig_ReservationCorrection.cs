using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Persistence.Migrations
{
    public partial class mig_ReservationCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Books_MessageSettings_MessageId",
                table: "Users_Books");

            migrationBuilder.DropIndex(
                name: "IX_Users_Books_MessageId",
                table: "Users_Books");

            migrationBuilder.DropColumn(
                name: "MessageId",
                table: "Users_Books");

            migrationBuilder.AddColumn<int>(
                name: "MessageSettingsId",
                table: "Users_Books",
                type: "int",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "MessageId",
                table: "Users_Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Books_MessageId",
                table: "Users_Books",
                column: "MessageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Books_MessageSettings_MessageId",
                table: "Users_Books",
                column: "MessageId",
                principalTable: "MessageSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
