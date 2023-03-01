using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.Data.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Request",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(nullable: false),
                    Message = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "4306126c-1b9b-4930-b0b6-dc2de543b8b5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "a84ae83b-130f-4353-b5fb-63f59d1665d4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "ec86e51e-d6fb-42dd-9e5f-08fc2194590c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b634ec48-f274-49c2-aef4-3505554ad11f", "AQAAAAEAACcQAAAAEPmglsI00o81nODI5MpFLYXnYFNtFVKzutlnPi0qWbaaBl64PoE7zh1MAStFLQU7cQ==", "32969ff9-192b-41af-85d7-833c114ab17b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "803e7859-f0a2-4125-8727-6b3583b1b2c4", "AQAAAAEAACcQAAAAEJHhLJlkW56Q9dXhZpbbj5D/g6HwS7QOM3UnP2lOxCIgykRQXXIBZObvs/4hshf1eQ==", "28e20d6d-9406-45ac-a638-b68560130b93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "812b5618-0331-4a73-b93f-41c1f0baec36", "AQAAAAEAACcQAAAAEBMYSKwEYjHwYV+os5BBOYCDkLx5WZAUO7NYG2nOsbiMdCZvhj2zbjO5jGCtD1wmKg==", "9f670466-8c1f-4c0b-bdb5-3c2d23a9cd1a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Request");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "0a9a955f-a867-4b40-a023-e33532134e2c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "5cce0a96-640f-40f6-a7d6-9c9444e700fe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "2fa6795e-3053-43dc-8321-b33d6df74465");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd2b73cd-3851-4221-847f-ec33e219f6f1", "AQAAAAEAACcQAAAAEFiuCndXuWYFsvcBqoARnQoH4QNxxltDiklDnVhx2jZF0P+tx4AFFLZfl7fNaDHmQQ==", "6e271f42-0ebd-4122-aaf3-ac95b643cf12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a2b6b4b-4468-4107-b480-9c2a8aa804d9", "AQAAAAEAACcQAAAAEH7zfXudWEf9hFrWDF2zeuyjGRYgAdDqzWy4KWH6SAd/CPmBo0k7QW16Tb5wQyDrvw==", "83ddbb0d-0213-4150-bbfe-4dbbe8c30929" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d00460e0-21a6-4063-b665-33323be6cc86", "AQAAAAEAACcQAAAAEChCdTFTawxL1IT6/hoQod7aYh6Upn1lr9JyxwoX00krkosdov1mrMz8NBKRDUrjSw==", "c42f83cb-b5fb-4bd6-98c9-e7aaca7b2f5e" });
        }
    }
}
