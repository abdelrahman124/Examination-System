using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectExamination.Migrations
{
    /// <inheritdoc />
    public partial class gfh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "studentExam");

            migrationBuilder.DropColumn(
                name: "SPassword",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Sname",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "guidIdRandomlya",
                table: "Questions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SPassword",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sname",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "guidIdRandomlya",
                table: "Questions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "studentExam",
                columns: table => new
                {
                    studentId = table.Column<int>(type: "int", nullable: false),
                    examId = table.Column<int>(type: "int", nullable: false),
                    mark = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentExam", x => new { x.studentId, x.examId });
                    table.ForeignKey(
                        name: "FK_studentExam_Exams_examId",
                        column: x => x.examId,
                        principalTable: "Exams",
                        principalColumn: "Examsid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_studentExam_Students_studentId",
                        column: x => x.studentId,
                        principalTable: "Students",
                        principalColumn: "StudentsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_studentExam_examId",
                table: "studentExam",
                column: "examId");
        }
    }
}
