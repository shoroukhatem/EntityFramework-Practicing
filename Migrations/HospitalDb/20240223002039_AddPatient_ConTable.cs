using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_CORE_Project.Migrations.HospitalDb
{
    public partial class AddPatient_ConTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patient_Con",
                columns: table => new
                {
                    Con_Id = table.Column<int>(type: "int", nullable: false),
                    Pat_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient_Con", x => new { x.Con_Id, x.Pat_Id });
                    table.ForeignKey(
                        name: "FK_Patient_Con_Consultants_Con_Id",
                        column: x => x.Con_Id,
                        principalTable: "Consultants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patient_Con_Patients_Pat_Id",
                        column: x => x.Pat_Id,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Con_Pat_Id",
                table: "Patient_Con",
                column: "Pat_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patient_Con");
        }
    }
}
