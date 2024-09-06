using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectclass.Migrations
{
    /// <inheritdoc />
    public partial class myfirst : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "registers",
                columns: table => new
                {
                    r_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    r_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    r_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    r_pass = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registers", x => x.r_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "registers");
        }
    }
}
