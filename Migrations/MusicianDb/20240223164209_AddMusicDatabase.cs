using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_CORE_Project.Migrations.MusicianDb
{
    public partial class AddMusicDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instruments",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instruments", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Musicians",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ph_Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musicians", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Song",
                columns: table => new
                {
                    Title = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song", x => x.Title);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mus_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albums_Musicians_Mus_Id",
                        column: x => x.Mus_Id,
                        principalTable: "Musicians",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Mus_Instruments",
                columns: table => new
                {
                    Mus_Id = table.Column<int>(type: "int", nullable: false),
                    Inst_Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mus_Instruments", x => new { x.Mus_Id, x.Inst_Name });
                    table.ForeignKey(
                        name: "FK_Mus_Instruments_Instruments_Inst_Name",
                        column: x => x.Inst_Name,
                        principalTable: "Instruments",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mus_Instruments_Musicians_Mus_Id",
                        column: x => x.Mus_Id,
                        principalTable: "Musicians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mus_Songs",
                columns: table => new
                {
                    Mus_Id = table.Column<int>(type: "int", nullable: false),
                    Song_Title = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mus_Songs", x => new { x.Mus_Id, x.Song_Title });
                    table.ForeignKey(
                        name: "FK_Mus_Songs_Musicians_Mus_Id",
                        column: x => x.Mus_Id,
                        principalTable: "Musicians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mus_Songs_Song_Song_Title",
                        column: x => x.Song_Title,
                        principalTable: "Song",
                        principalColumn: "Title",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Album_Song",
                columns: table => new
                {
                    Song_Title = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Album_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Album_Song", x => x.Song_Title);
                    table.ForeignKey(
                        name: "FK_Album_Song_Albums_Album_Id",
                        column: x => x.Album_Id,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Album_Song_Song_Song_Title",
                        column: x => x.Song_Title,
                        principalTable: "Song",
                        principalColumn: "Title",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Album_Song_Album_Id",
                table: "Album_Song",
                column: "Album_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_Mus_Id",
                table: "Albums",
                column: "Mus_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Mus_Instruments_Inst_Name",
                table: "Mus_Instruments",
                column: "Inst_Name");

            migrationBuilder.CreateIndex(
                name: "IX_Mus_Songs_Song_Title",
                table: "Mus_Songs",
                column: "Song_Title");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Album_Song");

            migrationBuilder.DropTable(
                name: "Mus_Instruments");

            migrationBuilder.DropTable(
                name: "Mus_Songs");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Instruments");

            migrationBuilder.DropTable(
                name: "Song");

            migrationBuilder.DropTable(
                name: "Musicians");
        }
    }
}
