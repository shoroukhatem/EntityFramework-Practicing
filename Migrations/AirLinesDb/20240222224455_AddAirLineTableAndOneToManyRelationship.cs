using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_CORE_Project.Migrations.AirLinesDb
{
    public partial class AddAirLineTableAndOneToManyRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AL_ID",
                table: "Aircrafts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AirLine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cont_Person = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirLine", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aircrafts_AL_ID",
                table: "Aircrafts",
                column: "AL_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Aircrafts_AirLine_AL_ID",
                table: "Aircrafts",
                column: "AL_ID",
                principalTable: "AirLine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aircrafts_AirLine_AL_ID",
                table: "Aircrafts");

            migrationBuilder.DropTable(
                name: "AirLine");

            migrationBuilder.DropIndex(
                name: "IX_Aircrafts_AL_ID",
                table: "Aircrafts");

            migrationBuilder.DropColumn(
                name: "AL_ID",
                table: "Aircrafts");
        }
    }
}
