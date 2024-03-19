using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_CORE_Project.Migrations.AirLinesDb
{
    public partial class AddAirLinePhonesTableAndOneToManyRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aircrafts_AirLine_AL_ID",
                table: "Aircrafts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AirLine",
                table: "AirLine");

            migrationBuilder.RenameTable(
                name: "AirLine",
                newName: "AirLines");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AirLines",
                table: "AirLines",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Airline_Phones",
                columns: table => new
                {
                    AL_Id = table.Column<int>(type: "int", nullable: false),
                    Phones = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airline_Phones", x => new { x.AL_Id, x.Phones });
                    table.ForeignKey(
                        name: "FK_Airline_Phones_AirLines_AL_Id",
                        column: x => x.AL_Id,
                        principalTable: "AirLines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Aircrafts_AirLines_AL_ID",
                table: "Aircrafts",
                column: "AL_ID",
                principalTable: "AirLines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aircrafts_AirLines_AL_ID",
                table: "Aircrafts");

            migrationBuilder.DropTable(
                name: "Airline_Phones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AirLines",
                table: "AirLines");

            migrationBuilder.RenameTable(
                name: "AirLines",
                newName: "AirLine");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AirLine",
                table: "AirLine",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Aircrafts_AirLine_AL_ID",
                table: "Aircrafts",
                column: "AL_ID",
                principalTable: "AirLine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
