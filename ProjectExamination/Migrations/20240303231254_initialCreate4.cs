using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectExamination.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LoginId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentsId",
                table: "logins",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_LoginId",
                table: "Students",
                column: "LoginId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_logins_LoginId",
                table: "Students",
                column: "LoginId",
                principalTable: "logins",
                principalColumn: "LoginId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_logins_LoginId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_LoginId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "LoginId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentsId",
                table: "logins");
        }
    }
}
