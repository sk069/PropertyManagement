using Microsoft.EntityFrameworkCore.Migrations;

namespace PropertyManagement.Migrations
{
    public partial class Propert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer_Detail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_Detail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dealer_Detail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dealer_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dealer_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dealer_Detail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Property_Detail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Property_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Facilities = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property_Detail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Property_Oction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bid_Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Property_Id = table.Column<int>(type: "int", nullable: false),
                    Property_DetailsId = table.Column<int>(type: "int", nullable: true),
                    Customer_Id = table.Column<int>(type: "int", nullable: false),
                    Customer_DetailId = table.Column<int>(type: "int", nullable: true),
                    Dealer_Id = table.Column<int>(type: "int", nullable: false),
                    Dealer_DetailsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property_Oction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Property_Oction_Customer_Detail_Customer_DetailId",
                        column: x => x.Customer_DetailId,
                        principalTable: "Customer_Detail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Property_Oction_Dealer_Detail_Dealer_DetailsId",
                        column: x => x.Dealer_DetailsId,
                        principalTable: "Dealer_Detail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Property_Oction_Property_Detail_Property_DetailsId",
                        column: x => x.Property_DetailsId,
                        principalTable: "Property_Detail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Property_Oction_Customer_DetailId",
                table: "Property_Oction",
                column: "Customer_DetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_Oction_Dealer_DetailsId",
                table: "Property_Oction",
                column: "Dealer_DetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_Oction_Property_DetailsId",
                table: "Property_Oction",
                column: "Property_DetailsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Property_Oction");

            migrationBuilder.DropTable(
                name: "Customer_Detail");

            migrationBuilder.DropTable(
                name: "Dealer_Detail");

            migrationBuilder.DropTable(
                name: "Property_Detail");
        }
    }
}
