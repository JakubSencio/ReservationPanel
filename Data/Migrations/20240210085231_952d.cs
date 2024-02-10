using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class _952d : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "602d282a-b6bd-47e3-8344-dd1fdd6f8f32", "602d282a-b6bd-47e3-8344-dd1fdd6f8f32", "user", "USER" },
                    { "c4137af8-c29f-48ad-be92-3d150407a243", "c4137af8-c29f-48ad-be92-3d150407a243", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3660351d-0d72-4a2d-87d7-5f917be3502f", 0, "94e71005-c3dd-4dd3-8f1a-e39f9b5801ce", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADMIN", "AQAAAAEAACcQAAAAEMoS6lrDUqb2XksEiGaUOAnGkUPLyh1nDpZ3gbmElGZ4KTUH0ih1cTTof0kMt7mFEQ==", null, false, "21941a47-33f9-4f5f-816b-5a103034f341", false, "adam" },
                    { "fd771d12-e5ec-48ef-a96a-958ee235497c", 0, "b4363e29-b311-423c-ac4a-955fb2a21c0e", "malysz@wsei.edu.pl", true, false, null, "USER@WSEI.EDU.PL", "USER", "AQAAAAEAACcQAAAAEFUlNvkLum0QbfK45DmJFAl8X6Q8S7Vmz2D4VwuDufIXnIns8rW10oR9ax6pO4bRDg==", null, false, "17ccf643-4fcd-4f72-9910-18a42f75248a", false, "malysz" }
                });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "Priority" },
                values: new object[] { 30, 2 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c4137af8-c29f-48ad-be92-3d150407a243", "3660351d-0d72-4a2d-87d7-5f917be3502f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "602d282a-b6bd-47e3-8344-dd1fdd6f8f32", "fd771d12-e5ec-48ef-a96a-958ee235497c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c4137af8-c29f-48ad-be92-3d150407a243", "3660351d-0d72-4a2d-87d7-5f917be3502f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "602d282a-b6bd-47e3-8344-dd1fdd6f8f32", "fd771d12-e5ec-48ef-a96a-958ee235497c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "602d282a-b6bd-47e3-8344-dd1fdd6f8f32");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4137af8-c29f-48ad-be92-3d150407a243");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3660351d-0d72-4a2d-87d7-5f917be3502f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd771d12-e5ec-48ef-a96a-958ee235497c");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "reservations");

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "reservations");

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ff5c8041-0f2a-471a-b366-a367a11aa12c", "0b55d724-0615-43c1-83aa-3b5b138ea119" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "275a0379-e68f-44db-84db-d613ee33fd1d", "28313e8c-7bcc-49af-9605-cf6d6aedcf2e" });
        }
    }
}
