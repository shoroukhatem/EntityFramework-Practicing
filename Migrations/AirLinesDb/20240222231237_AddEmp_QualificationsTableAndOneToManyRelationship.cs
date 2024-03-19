using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_CORE_Project.Migrations.AirLinesDb
{
    public partial class AddEmp_QualificationsTableAndOneToManyRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Airline_Phones_AirLines_AL_Id",
                table: "Airline_Phones");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_AirLines_AL_ID",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_AirLines_AL_ID",
                table: "Transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Airline_Phones",
                table: "Airline_Phones");

            migrationBuilder.RenameTable(
                name: "Transaction",
                newName: "Transactions");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.RenameTable(
                name: "Airline_Phones",
                newName: "Airlines_Phones");

            migrationBuilder.RenameIndex(
                name: "IX_Transaction_AL_ID",
                table: "Transactions",
                newName: "IX_Transactions_AL_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_AL_ID",
                table: "Employees",
                newName: "IX_Employees_AL_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Airlines_Phones",
                table: "Airlines_Phones",
                columns: new[] { "AL_Id", "Phones" });

            migrationBuilder.CreateTable(
                name: "Emp_Qualifications",
                columns: table => new
                {
                    Emp_Id = table.Column<int>(type: "int", nullable: false),
                    Qualifications = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emp_Qualifications", x => new { x.Emp_Id, x.Qualifications });
                    table.ForeignKey(
                        name: "FK_Emp_Qualifications_Employees_Emp_Id",
                        column: x => x.Emp_Id,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Airlines_Phones_AirLines_AL_Id",
                table: "Airlines_Phones",
                column: "AL_Id",
                principalTable: "AirLines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_AirLines_AL_ID",
                table: "Employees",
                column: "AL_ID",
                principalTable: "AirLines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_AirLines_AL_ID",
                table: "Transactions",
                column: "AL_ID",
                principalTable: "AirLines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Airlines_Phones_AirLines_AL_Id",
                table: "Airlines_Phones");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_AirLines_AL_ID",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_AirLines_AL_ID",
                table: "Transactions");

            migrationBuilder.DropTable(
                name: "Emp_Qualifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Airlines_Phones",
                table: "Airlines_Phones");

            migrationBuilder.RenameTable(
                name: "Transactions",
                newName: "Transaction");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.RenameTable(
                name: "Airlines_Phones",
                newName: "Airline_Phones");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_AL_ID",
                table: "Transaction",
                newName: "IX_Transaction_AL_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_AL_ID",
                table: "Employee",
                newName: "IX_Employee_AL_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Airline_Phones",
                table: "Airline_Phones",
                columns: new[] { "AL_Id", "Phones" });

            migrationBuilder.AddForeignKey(
                name: "FK_Airline_Phones_AirLines_AL_Id",
                table: "Airline_Phones",
                column: "AL_Id",
                principalTable: "AirLines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_AirLines_AL_ID",
                table: "Employee",
                column: "AL_ID",
                principalTable: "AirLines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_AirLines_AL_ID",
                table: "Transaction",
                column: "AL_ID",
                principalTable: "AirLines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
