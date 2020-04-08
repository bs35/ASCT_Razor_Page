using Microsoft.EntityFrameworkCore.Migrations;

namespace ASCT_API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aircrafts",
                columns: table => new
                {
                    Tail_Number = table.Column<string>(maxLength: 6, nullable: false),
                    LRU_Name = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    LRU_Part_Number = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Software_Name = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Software_Part_Number = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    EC_Number = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    PRE_POST_Notes = table.Column<string>(type: "text", nullable: true),
                    Fleet_Type = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aircrafts", x => x.Tail_Number);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aircrafts");
        }
    }
}
