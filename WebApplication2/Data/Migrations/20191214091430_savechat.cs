using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Data.Migrations
{
    public partial class savechat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SaveChatChatid",
                table: "AspNetUserTokens",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SaveChatChatid",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SaveChatChatid",
                table: "AspNetUserRoles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SaveChatChatid",
                table: "AspNetUserLogins",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SaveChatChatid",
                table: "AspNetUserClaims",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SaveChatChatid",
                table: "AspNetRoles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SaveChatChatid",
                table: "AspNetRoleClaims",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "text",
                columns: table => new
                {
                    Chatid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Chats = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_text", x => x.Chatid);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserTokens_SaveChatChatid",
                table: "AspNetUserTokens",
                column: "SaveChatChatid");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SaveChatChatid",
                table: "AspNetUsers",
                column: "SaveChatChatid");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_SaveChatChatid",
                table: "AspNetUserRoles",
                column: "SaveChatChatid");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_SaveChatChatid",
                table: "AspNetUserLogins",
                column: "SaveChatChatid");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_SaveChatChatid",
                table: "AspNetUserClaims",
                column: "SaveChatChatid");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_SaveChatChatid",
                table: "AspNetRoles",
                column: "SaveChatChatid");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_SaveChatChatid",
                table: "AspNetRoleClaims",
                column: "SaveChatChatid");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_text_SaveChatChatid",
                table: "AspNetRoleClaims",
                column: "SaveChatChatid",
                principalTable: "text",
                principalColumn: "Chatid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoles_text_SaveChatChatid",
                table: "AspNetRoles",
                column: "SaveChatChatid",
                principalTable: "text",
                principalColumn: "Chatid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_text_SaveChatChatid",
                table: "AspNetUserClaims",
                column: "SaveChatChatid",
                principalTable: "text",
                principalColumn: "Chatid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_text_SaveChatChatid",
                table: "AspNetUserLogins",
                column: "SaveChatChatid",
                principalTable: "text",
                principalColumn: "Chatid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_text_SaveChatChatid",
                table: "AspNetUserRoles",
                column: "SaveChatChatid",
                principalTable: "text",
                principalColumn: "Chatid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_text_SaveChatChatid",
                table: "AspNetUsers",
                column: "SaveChatChatid",
                principalTable: "text",
                principalColumn: "Chatid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_text_SaveChatChatid",
                table: "AspNetUserTokens",
                column: "SaveChatChatid",
                principalTable: "text",
                principalColumn: "Chatid",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_text_SaveChatChatid",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoles_text_SaveChatChatid",
                table: "AspNetRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_text_SaveChatChatid",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_text_SaveChatChatid",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_text_SaveChatChatid",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_text_SaveChatChatid",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_text_SaveChatChatid",
                table: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "text");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserTokens_SaveChatChatid",
                table: "AspNetUserTokens");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_SaveChatChatid",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_SaveChatChatid",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserLogins_SaveChatChatid",
                table: "AspNetUserLogins");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserClaims_SaveChatChatid",
                table: "AspNetUserClaims");

            migrationBuilder.DropIndex(
                name: "IX_AspNetRoles_SaveChatChatid",
                table: "AspNetRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetRoleClaims_SaveChatChatid",
                table: "AspNetRoleClaims");

            migrationBuilder.DropColumn(
                name: "SaveChatChatid",
                table: "AspNetUserTokens");

            migrationBuilder.DropColumn(
                name: "SaveChatChatid",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SaveChatChatid",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "SaveChatChatid",
                table: "AspNetUserLogins");

            migrationBuilder.DropColumn(
                name: "SaveChatChatid",
                table: "AspNetUserClaims");

            migrationBuilder.DropColumn(
                name: "SaveChatChatid",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "SaveChatChatid",
                table: "AspNetRoleClaims");
        }
    }
}
