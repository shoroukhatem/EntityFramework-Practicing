using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_CORE_Project.Migrations
{
    public partial class AddSalesOfficeAndEmployeeTablesWithRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Off_Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sales_Offices",
                columns: table => new
                {
                    Number = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales_Offices", x => x.Number);
                    table.ForeignKey(
                        name: "FK_Sales_Offices_Employees_EmpId",
                        column: x => x.EmpId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Off_Number",
                table: "Employees",
                column: "Off_Number");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_Offices_EmpId",
                table: "Sales_Offices",
                column: "EmpId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Sales_Offices_Off_Number",
                table: "Employees",
                column: "Off_Number",
                principalTable: "Sales_Offices",
                principalColumn: "Number");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Sales_Offices_Off_Number",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Sales_Offices");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
