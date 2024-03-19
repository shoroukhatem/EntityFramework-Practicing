using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_CORE_Project.Migrations.ITIDb
{
    public partial class AddManyToManyRelationCourse_Instructor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course_Instructors",
                columns: table => new
                {
                    Course_Id = table.Column<int>(type: "int", nullable: false),
                    Inst_Id = table.Column<int>(type: "int", nullable: false),
                    Evaluation = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course_Instructors", x => new { x.Course_Id, x.Inst_Id });
                    table.ForeignKey(
                        name: "FK_Course_Instructors_Courses_Course_Id",
                        column: x => x.Course_Id,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Course_Instructors_Instructors_Inst_Id",
                        column: x => x.Inst_Id,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Course_Instructors_Inst_Id",
                table: "Course_Instructors",
                column: "Inst_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Course_Instructors");
        }
    }
}
