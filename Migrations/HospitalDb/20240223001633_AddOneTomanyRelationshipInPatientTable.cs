using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_CORE_Project.Migrations.HospitalDb
{
    public partial class AddOneTomanyRelationshipInPatientTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Con_Id",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ward_Id",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_Con_Id",
                table: "Patients",
                column: "Con_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_Ward_Id",
                table: "Patients",
                column: "Ward_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Consultants_Con_Id",
                table: "Patients",
                column: "Con_Id",
                principalTable: "Consultants",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Wards_Ward_Id",
                table: "Patients",
                column: "Ward_Id",
                principalTable: "Wards",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Consultants_Con_Id",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Wards_Ward_Id",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_Con_Id",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_Ward_Id",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Con_Id",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Ward_Id",
                table: "Patients");
        }
    }
}
