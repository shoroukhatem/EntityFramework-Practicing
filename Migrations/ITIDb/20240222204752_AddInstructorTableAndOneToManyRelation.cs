using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_CORE_Project.Migrations.ITIDb
{
    public partial class AddInstructorTableAndOneToManyRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Hiring_Date",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Ins_Id",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bouns = table.Column<double>(type: "float", nullable: false),
                    Salary = table.Column<double>(type: "float", nullable: false),
                    Hour_Rate = table.Column<double>(type: "float", nullable: false),
                    Dep_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructors_Departments_Dep_Id",
                        column: x => x.Dep_Id,
                        principalTable: "Departments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Ins_Id",
                table: "Departments",
                column: "Ins_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Dep_Id",
                table: "Instructors",
                column: "Dep_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_Ins_Id",
                table: "Departments",
                column: "Ins_Id",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_Ins_Id",
                table: "Departments");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Ins_Id",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "Hiring_Date",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "Ins_Id",
                table: "Departments");
        }
    }
}
