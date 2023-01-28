using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JABILProject.Migrations
{
    /// <inheritdoc />
    public partial class DBInitialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    PKBuilding = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Building = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.PKBuilding);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    PKCustomers = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prefix = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    FKBuilding = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.PKCustomers);
                    table.ForeignKey(
                        name: "FK_Customers_Buildings_FKBuilding",
                        column: x => x.FKBuilding,
                        principalTable: "Buildings",
                        principalColumn: "PKBuilding",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PartNumbers",
                columns: table => new
                {
                    PKPartNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false),
                    FKCustomer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartNumbers", x => x.PKPartNumber);
                    table.ForeignKey(
                        name: "FK_PartNumbers_Customers_FKCustomer",
                        column: x => x.FKCustomer,
                        principalTable: "Customers",
                        principalColumn: "PKCustomers",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_FKBuilding",
                table: "Customers",
                column: "FKBuilding");

            migrationBuilder.CreateIndex(
                name: "IX_PartNumbers_FKCustomer",
                table: "PartNumbers",
                column: "FKCustomer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PartNumbers");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Buildings");
        }
    }
}
