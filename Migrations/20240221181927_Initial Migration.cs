using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDMVCWEB.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CusName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CusEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CusPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CusMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CusAgree = table.Column<bool>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CusId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
