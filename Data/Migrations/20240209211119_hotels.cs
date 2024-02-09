using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class hotels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HotelOwners",
                columns: table => new
                {
                    OwnerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelOwners", x => x.OwnerId);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    HotelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stars = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.HotelId);
                });

            migrationBuilder.CreateTable(
                name: "HotelHotelOwner",
                columns: table => new
                {
                    HotelOwnersOwnerId = table.Column<int>(type: "int", nullable: false),
                    HotelsHotelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelHotelOwner", x => new { x.HotelOwnersOwnerId, x.HotelsHotelId });
                    table.ForeignKey(
                        name: "FK_HotelHotelOwner_HotelOwners_HotelOwnersOwnerId",
                        column: x => x.HotelOwnersOwnerId,
                        principalTable: "HotelOwners",
                        principalColumn: "OwnerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HotelHotelOwner_Hotels_HotelsHotelId",
                        column: x => x.HotelsHotelId,
                        principalTable: "Hotels",
                        principalColumn: "HotelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "HotelOwners",
                columns: new[] { "OwnerId", "LastName", "Mail", "Name" },
                values: new object[,]
                {
                    { 1, "Griffin", "peter.griffin@gmail.com", "Peter" },
                    { 2, "McCwak", "thomas.mccwak@gmail.com", "Thomas" },
                    { 3, "Pudzianowski", "mario.pudzilla@pudzian.pl", "Mariusz" }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "Adress", "City", "Name", "Stars" },
                values: new object[,]
                {
                    { 1, "ul. Zlota 44", "Warsaw", "London Look Hotel", 5 },
                    { 2, "ul. Kaminskiego 1337", "Bydgoszcz", "Resdient Big Hotel", 4 },
                    { 3, "ul. Leskowiec 4", "Biala Rawska", "U Pudziana Hotel", 5 }
                });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address_City", "Address_PostalCode", "Address_Region", "Address_Street" },
                values: new object[] { "Kraków", "31-150", "małopolskie", "Św. Filipa 17" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address_City", "Address_PostalCode", "Address_Region", "Address_Street" },
                values: new object[] { "Kraków", "31-150", "małopolskie", "Krowoderska 45/6" });

            migrationBuilder.CreateIndex(
                name: "IX_HotelHotelOwner_HotelsHotelId",
                table: "HotelHotelOwner",
                column: "HotelsHotelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HotelHotelOwner");

            migrationBuilder.DropTable(
                name: "HotelOwners");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address_City", "Address_PostalCode", "Address_Region", "Address_Street" },
                values: new object[] { "Kraków", "31-150", "małopolskie", "Św. Filipa 17" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address_City", "Address_PostalCode", "Address_Region", "Address_Street" },
                values: new object[] { "Kraków", "31-150", "małopolskie", "Krowoderska 45/6" });
        }
    }
}
