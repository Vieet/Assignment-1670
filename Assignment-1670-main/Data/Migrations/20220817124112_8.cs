using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.Data.Migrations
{
    public partial class _8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "cfb9ced9-092e-403a-bbcb-417138f2e8e9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "1939dc80-670e-4ff4-bb3c-b9b3ea464bce");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "5fb1a9b1-b52d-4a6f-95a1-23af53f93bba");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc3088ad-2f57-46de-9ec4-fe0bda77d14c", "AQAAAAEAACcQAAAAEOSYupU/Qp3SzpLcxDaxqMNtxEjtHDh3ZArglJsxnSN8FuEZZzBeOD21LFE4Vu8E8A==", "b80f2d68-8c02-4b3b-8567-c379985f280e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7e1c2d0-1db4-4f5c-a3a0-01722d3ce874", "AQAAAAEAACcQAAAAEPJDE25E4tDYaq+vc7KgQsZNxtzotChwgIaKpTpBRg0xRF/7Jz5FGLNM5B6AMfZVkQ==", "6db7c478-fce8-4aa7-b555-180321b2b777" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bfcf08f-93cb-4694-8e5a-6c85bde49f87", "AQAAAAEAACcQAAAAEBdCxyQaCfPfVb1ePumPF5SAQ6srBPNvTzaYPFd311+J4mxwJ7EXl/8vTt96j1oGmw==", "79e9f44d-cd88-45c5-aacc-23c3ad182689" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "71a17528-c35c-4645-b8bb-ce0a98523172");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "6ac84780-378a-4ae3-8379-2b6427e62855");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "31fe974b-2d60-420b-859c-42a2395a2329");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7225807-ec94-4dfc-8550-8a341e1da0e4", "AQAAAAEAACcQAAAAEHZ3Zr0nRVPKy6CR9jfSFD0lXdF8KnS0/3RqNzY1TOs5/j14meAK2BhD95gQcGGBWA==", "2d97330c-e044-43a9-a3e6-dfd19efd8994" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48d46823-5077-4cb1-8117-d7e9e1c764ef", "AQAAAAEAACcQAAAAEMU19hXdeoMl7xGLt2CA/OS4e14XamRPVmQx6BC+RMGj2KFfavZ7unL/Y7h+hfkL3A==", "0b78e9bf-0b67-4367-bc30-d66c92e075eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d07ae0ba-2fe5-4ec0-a36a-aa2e3bf01e6b", "AQAAAAEAACcQAAAAEE5hs5qTBacRjw9X8XCwxl6K3RKLXW/MQCY40dFi4gaGGWIkCqaqQRYv0qBkc7XBSQ==", "540978fe-2ddd-4065-9e6d-b420a51a8786" });
        }
    }
}
