using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class RepairMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "HotelHotelOwner",
                columns: new[] { "HotelOwnersOwnerId", "HotelsHotelId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HotelHotelOwner",
                keyColumns: new[] { "HotelOwnersOwnerId", "HotelsHotelId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "HotelHotelOwner",
                keyColumns: new[] { "HotelOwnersOwnerId", "HotelsHotelId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "HotelHotelOwner",
                keyColumns: new[] { "HotelOwnersOwnerId", "HotelsHotelId" },
                keyValues: new object[] { 3, 3 });

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
        }
    }
}
