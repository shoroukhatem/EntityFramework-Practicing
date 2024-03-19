using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_CORE_Project.Migrations
{
    public partial class AddManyToManyRelationBetweenOwnerAndProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prop_Owner",
                columns: table => new
                {
                    Own_Id = table.Column<int>(type: "int", nullable: false),
                    Prop_Id = table.Column<int>(type: "int", nullable: false),
                    Percent = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prop_Owner", x => new { x.Own_Id, x.Prop_Id });
                    table.ForeignKey(
                        name: "FK_Prop_Owner_Owners_Own_Id",
                        column: x => x.Own_Id,
                        principalTable: "Owners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prop_Owner_properties_Prop_Id",
                        column: x => x.Prop_Id,
                        principalTable: "properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prop_Owner_Prop_Id",
                table: "Prop_Owner",
                column: "Prop_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prop_Owner");
        }
    }
}
