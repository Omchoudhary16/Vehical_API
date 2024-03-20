using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Veh.Migrations
{
    public partial class dbfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicle_Catalog",
                columns: table => new
                {
                    Veh_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company_name = table.Column<string>(type: "Varchar(20)", maxLength: 20, nullable: false),
                    Veh_model = table.Column<string>(type: "Varchar(20)", maxLength: 20, nullable: false),
                    Seating_capacity = table.Column<string>(type: "Varchar(10)", nullable: false),
                    ShowroomPrice = table.Column<decimal>(type: "Decimal(10,2)", nullable: false),
                    LocalTax = table.Column<decimal>(type: "Decimal(10,2)", nullable: false),
                    GST = table.Column<decimal>(type: "Decimal(10,2)", nullable: false),
                    RoadPrice = table.Column<decimal>(type: "Decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle_Catalog", x => x.Veh_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicle_Catalog");
        }
    }
}
