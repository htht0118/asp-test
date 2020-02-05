using Microsoft.EntityFrameworkCore.Migrations;

namespace kdhhome.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    UerPassword = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserNo);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    NoteNO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoteTitle = table.Column<string>(nullable: false),
                    NoteContents = table.Column<string>(nullable: false),
                    UserNo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.NoteNO);
                    table.ForeignKey(
                        name: "FK_Notes_Users_UserNo",
                        column: x => x.UserNo,
                        principalTable: "Users",
                        principalColumn: "UserNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notes_UserNo",
                table: "Notes",
                column: "UserNo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
