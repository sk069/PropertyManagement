using Microsoft.EntityFrameworkCore.Migrations;

namespace PropertyManagement.Migrations
{
    public partial class Prorerty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer_Detail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_Detail", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Dealer_Detail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dealer_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dealer_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dealer_Detail", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Property_Detail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Property_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Facilities = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property_Detail", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Property_Oction",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bid_Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Property_ID = table.Column<int>(type: "int", nullable: false),
                    Obj_property_DetailsID = table.Column<int>(type: "int", nullable: true),
                    Customer_ID = table.Column<int>(type: "int", nullable: false),
                    Obj_Customer_DetailID = table.Column<int>(type: "int", nullable: true),
                    Dealer_ID = table.Column<int>(type: "int", nullable: false),
                    Obj_Dealer_DetailsID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property_Oction", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Property_Oction_Customer_Detail_Obj_Customer_DetailID",
                        column: x => x.Obj_Customer_DetailID,
                        principalTable: "Customer_Detail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Property_Oction_Dealer_Detail_Obj_Dealer_DetailsID",
                        column: x => x.Obj_Dealer_DetailsID,
                        principalTable: "Dealer_Detail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Property_Oction_Property_Detail_Obj_property_DetailsID",
                        column: x => x.Obj_property_DetailsID,
                        principalTable: "Property_Detail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Property_Oction_Obj_Customer_DetailID",
                table: "Property_Oction",
                column: "Obj_Customer_DetailID");

            migrationBuilder.CreateIndex(
                name: "IX_Property_Oction_Obj_Dealer_DetailsID",
                table: "Property_Oction",
                column: "Obj_Dealer_DetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_Property_Oction_Obj_property_DetailsID",
                table: "Property_Oction",
                column: "Obj_property_DetailsID");
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
