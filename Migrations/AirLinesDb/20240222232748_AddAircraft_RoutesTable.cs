using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_CORE_Project.Migrations.AirLinesDb
{
    public partial class AddAircraft_RoutesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aircraft_Routes",
                columns: table => new
                {
                    AC_Id = table.Column<int>(type: "int", nullable: false),
                    Route_Id = table.Column<int>(type: "int", nullable: false),
                    Departure = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Num_Of_Pass = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Arrival = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aircraft_Routes", x => new { x.Route_Id, x.AC_Id, x.Departure });
                    table.ForeignKey(
                        name: "FK_Aircraft_Routes_Aircrafts_AC_Id",
                        column: x => x.AC_Id,
                        principalTable: "Aircrafts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Aircraft_Routes_Routes_Route_Id",
                        column: x => x.Route_Id,
                        principalTable: "Routes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aircraft_Routes_AC_Id",
                table: "Aircraft_Routes",
                column: "AC_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aircraft_Routes");
        }
    }
}
