using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectExamination.Migrations
{
    /// <inheritdoc />
    public partial class UpdateQuestionTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "User_Answer",
                table: "Questions");

            migrationBuilder.AlterColumn<int>(
                name: "Mark",
                table: "Questions",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Mark",
                table: "Questions",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "User_Answer",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
