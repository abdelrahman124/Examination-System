using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectExamination.Migrations
{
    /// <inheritdoc />
    public partial class updateUniqueValue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_logins_LoginId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Exams_Examsid",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_Examsid",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Students_LoginId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Examsid",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "LoginId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "Subid",
                table: "Exams",
                newName: "Subjectid");

            migrationBuilder.CreateIndex(
                name: "IX_logins_StudentsId",
                table: "logins",
                column: "StudentsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Exams_Subjectid",
                table: "Exams",
                column: "Subjectid",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Subjects_Subjectid",
                table: "Exams",
                column: "Subjectid",
                principalTable: "Subjects",
                principalColumn: "SubjectsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_logins_Students_StudentsId",
                table: "logins",
                column: "StudentsId",
                principalTable: "Students",
                principalColumn: "StudentsId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Subjects_Subjectid",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_logins_Students_StudentsId",
                table: "logins");

            migrationBuilder.DropIndex(
                name: "IX_logins_StudentsId",
                table: "logins");

            migrationBuilder.DropIndex(
                name: "IX_Exams_Subjectid",
                table: "Exams");

            migrationBuilder.RenameColumn(
                name: "Subjectid",
                table: "Exams",
                newName: "Subid");

            migrationBuilder.AddColumn<int>(
                name: "Examsid",
                table: "Subjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LoginId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_Examsid",
                table: "Subjects",
                column: "Examsid",
                unique: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Exams_Examsid",
                table: "Subjects",
                column: "Examsid",
                principalTable: "Exams",
                principalColumn: "Examsid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
