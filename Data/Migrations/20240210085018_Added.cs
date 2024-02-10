using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5411d98b-1cb9-4c66-8838-cdafa592c8fa", "746730de-25e4-4438-8867-33d6c931481e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ea7a40f7-c997-4eb1-abd5-47627771f036", "c0552c07-bf88-47f0-b6fc-72d68cbc3e9c" });

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5411d98b-1cb9-4c66-8838-cdafa592c8fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea7a40f7-c997-4eb1-abd5-47627771f036");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "746730de-25e4-4438-8867-33d6c931481e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0552c07-bf88-47f0-b6fc-72d68cbc3e9c");

            migrationBuilder.AddColumn<int>(
                name: "Room",
                table: "reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "275a0379-e68f-44db-84db-d613ee33fd1d", "275a0379-e68f-44db-84db-d613ee33fd1d", "user", "USER" },
                    { "ff5c8041-0f2a-471a-b366-a367a11aa12c", "ff5c8041-0f2a-471a-b366-a367a11aa12c", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0b55d724-0615-43c1-83aa-3b5b138ea119", 0, "52290631-1961-456a-b286-eb8f22acdc71", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADMIN", "AQAAAAEAACcQAAAAEAfUV2cLe8+hnLFcQxUhVno+DMBePd256bbnrvXQqzOflj4cPbyPxA1hQoyzRVttlg==", null, false, "b29fceb0-2c23-4761-9e1a-eafc81b07dca", false, "adam" },
                    { "28313e8c-7bcc-49af-9605-cf6d6aedcf2e", 0, "1d4518ca-26a0-4800-b7b7-f60ad670f14f", "malysz@wsei.edu.pl", true, false, null, "USER@WSEI.EDU.PL", "USER", "AQAAAAEAACcQAAAAEDJrGsz0Oc8OuE1Ef1Q1+ueq4hR1sSWftMt85yND3JCLkLQhNbXlFsAjMpF5SBhTVg==", null, false, "598dbdf7-0387-4ee0-a9f9-3eb8b6e691c0", false, "malysz" }
                });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Room",
                value: 5);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ff5c8041-0f2a-471a-b366-a367a11aa12c", "0b55d724-0615-43c1-83aa-3b5b138ea119" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "275a0379-e68f-44db-84db-d613ee33fd1d", "28313e8c-7bcc-49af-9605-cf6d6aedcf2e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ff5c8041-0f2a-471a-b366-a367a11aa12c", "0b55d724-0615-43c1-83aa-3b5b138ea119" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "275a0379-e68f-44db-84db-d613ee33fd1d", "28313e8c-7bcc-49af-9605-cf6d6aedcf2e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "275a0379-e68f-44db-84db-d613ee33fd1d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff5c8041-0f2a-471a-b366-a367a11aa12c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b55d724-0615-43c1-83aa-3b5b138ea119");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28313e8c-7bcc-49af-9605-cf6d6aedcf2e");

            migrationBuilder.DropColumn(
                name: "Room",
                table: "reservations");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5411d98b-1cb9-4c66-8838-cdafa592c8fa", "5411d98b-1cb9-4c66-8838-cdafa592c8fa", "user", "USER" },
                    { "ea7a40f7-c997-4eb1-abd5-47627771f036", "ea7a40f7-c997-4eb1-abd5-47627771f036", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "746730de-25e4-4438-8867-33d6c931481e", 0, "c97ac2cf-9ac9-4940-919e-2ac9abb08815", "malysz@wsei.edu.pl", true, false, null, "USER@WSEI.EDU.PL", "USER", "AQAAAAEAACcQAAAAEL4X3zYAiKfBGeePq+rRnz2Pb3SAVecLa8xqnbVpN5S7z3Oiwn8kKFYkoHhVNjfYnw==", null, false, "653699f4-9c94-4271-a07d-d7999ce7c24f", false, "malysz" },
                    { "c0552c07-bf88-47f0-b6fc-72d68cbc3e9c", 0, "805a22e0-415a-4e39-aa8d-80d184058df9", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADMIN", "AQAAAAEAACcQAAAAEB7KG/jHW++yomdyAFYPjbLXYM21hGjihVCMof7t2cw7Xx7MkL7Il2klObzZHBsiTA==", null, false, "ed0682b1-cb44-4606-ab04-ad3dc8b6a0cc", false, "adam" }
                });

            migrationBuilder.InsertData(
                table: "reservations",
                columns: new[] { "Id", "City", "reservation_date", "Name", "OrganizationId", "Region" },
                values: new object[] { 2, "Krakow", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C#", 2, "ul. Rozowa" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5411d98b-1cb9-4c66-8838-cdafa592c8fa", "746730de-25e4-4438-8867-33d6c931481e" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ea7a40f7-c997-4eb1-abd5-47627771f036", "c0552c07-bf88-47f0-b6fc-72d68cbc3e9c" });
        }
    }
}
