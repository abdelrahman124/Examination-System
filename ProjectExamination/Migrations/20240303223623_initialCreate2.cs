using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectExamination.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_studentExam",
                table: "studentExam");

            migrationBuilder.DropIndex(
                name: "IX_studentExam_studentId",
                table: "studentExam");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "studentExam");

            migrationBuilder.AddPrimaryKey(
                name: "PK_studentExam",
                table: "studentExam",
                columns: new[] { "studentId", "examId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_studentExam",
                table: "studentExam");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "studentExam",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_studentExam",
                table: "studentExam",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_studentExam_studentId",
                table: "studentExam",
                column: "studentId");
        }
    }
}
