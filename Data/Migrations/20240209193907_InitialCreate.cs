using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Region = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    reservation_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "reservations",
                columns: new[] { "Id", "City", "reservation_date", "Name", "Region" },
                values: new object[] { 1, "127813268163", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adam", "adam@wsei.edu.pl" });

            migrationBuilder.InsertData(
                table: "reservations",
                columns: new[] { "Id", "City", "reservation_date", "Name", "Region" },
                values: new object[] { 2, "293443823478", new DateTime(1999, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ewa", "ewa@wsei.edu.pl" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "reservations");
        }
    }
}
