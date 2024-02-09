using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class AddedOrganization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrganizationId",
                table: "reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Regon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address_Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address_PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address_Region = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Nip", "Regon", "Title", "Address_City", "Address_PostalCode", "Address_Region", "Address_Street" },
                values: new object[] { 1, "83492384", "13424234", "WSEI", "Kraków", "31-150", "małopolskie", "Św. Filipa 17" });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Nip", "Regon", "Title", "Address_City", "Address_PostalCode", "Address_Region", "Address_Street" },
                values: new object[] { 2, "2498534", "0873439249", "Firma", "Kraków", "31-150", "małopolskie", "Krowoderska 45/6" });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "reservation_date", "Name", "OrganizationId", "Region" },
                values: new object[] { "Krakow", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AA", 1, "ul. Fiolkowa" });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "reservation_date", "Name", "OrganizationId", "Region" },
                values: new object[] { "Krakow", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C#", 2, "ul. Rozowa" });

            migrationBuilder.CreateIndex(
                name: "IX_reservations_OrganizationId",
                table: "reservations",
                column: "OrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_reservations_Organizations_OrganizationId",
                table: "reservations",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_reservations_Organizations_OrganizationId",
                table: "reservations");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropIndex(
                name: "IX_reservations_OrganizationId",
                table: "reservations");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "reservations");

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "reservation_date", "Name", "Region" },
                values: new object[] { "127813268163", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adam", "adam@wsei.edu.pl" });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "reservation_date", "Name", "Region" },
                values: new object[] { "293443823478", new DateTime(1999, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ewa", "ewa@wsei.edu.pl" });
        }
    }
}
