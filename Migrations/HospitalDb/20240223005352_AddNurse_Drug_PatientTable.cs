using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_CORE_Project.Migrations.HospitalDb
{
    public partial class AddNurse_Drug_PatientTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Con_Consultants_Con_Id",
                table: "Patient_Con");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Con_Patients_Pat_Id",
                table: "Patient_Con");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patient_Con",
                table: "Patient_Con");

            migrationBuilder.RenameTable(
                name: "Patient_Con",
                newName: "patient_Con");

            migrationBuilder.RenameIndex(
                name: "IX_Patient_Con_Pat_Id",
                table: "patient_Con",
                newName: "IX_patient_Con_Pat_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_patient_Con",
                table: "patient_Con",
                columns: new[] { "Con_Id", "Pat_Id" });

            migrationBuilder.CreateTable(
                name: "Drugs",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dosage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drugs", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Drug_Brand",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drug_Brand", x => new { x.Code, x.Brand });
                    table.ForeignKey(
                        name: "FK_Drug_Brand_Drugs_Code",
                        column: x => x.Code,
                        principalTable: "Drugs",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Nurse_Drug_Patient",
                columns: table => new
                {
                    Pat_Id = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nur_Num = table.Column<int>(type: "int", nullable: false),
                    Drug_Code = table.Column<int>(type: "int", nullable: false),
                    Dosage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nurse_Drug_Patient", x => new { x.Pat_Id, x.Date, x.Time });
                    table.ForeignKey(
                        name: "FK_Nurse_Drug_Patient_Drugs_Drug_Code",
                        column: x => x.Drug_Code,
                        principalTable: "Drugs",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Nurse_Drug_Patient_Nurses_Nur_Num",
                        column: x => x.Nur_Num,
                        principalTable: "Nurses",
                        principalColumn: "Number",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Nurse_Drug_Patient_Patients_Pat_Id",
                        column: x => x.Pat_Id,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Nurse_Drug_Patient_Drug_Code",
                table: "Nurse_Drug_Patient",
                column: "Drug_Code");

            migrationBuilder.CreateIndex(
                name: "IX_Nurse_Drug_Patient_Nur_Num",
                table: "Nurse_Drug_Patient",
                column: "Nur_Num");

            migrationBuilder.AddForeignKey(
                name: "FK_patient_Con_Consultants_Con_Id",
                table: "patient_Con",
                column: "Con_Id",
                principalTable: "Consultants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_patient_Con_Patients_Pat_Id",
                table: "patient_Con",
                column: "Pat_Id",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_patient_Con_Consultants_Con_Id",
                table: "patient_Con");

            migrationBuilder.DropForeignKey(
                name: "FK_patient_Con_Patients_Pat_Id",
                table: "patient_Con");

            migrationBuilder.DropTable(
                name: "Drug_Brand");

            migrationBuilder.DropTable(
                name: "Nurse_Drug_Patient");

            migrationBuilder.DropTable(
                name: "Drugs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_patient_Con",
                table: "patient_Con");

            migrationBuilder.RenameTable(
                name: "patient_Con",
                newName: "Patient_Con");

            migrationBuilder.RenameIndex(
                name: "IX_patient_Con_Pat_Id",
                table: "Patient_Con",
                newName: "IX_Patient_Con_Pat_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patient_Con",
                table: "Patient_Con",
                columns: new[] { "Con_Id", "Pat_Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Con_Consultants_Con_Id",
                table: "Patient_Con",
                column: "Con_Id",
                principalTable: "Consultants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Con_Patients_Pat_Id",
                table: "Patient_Con",
                column: "Pat_Id",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
