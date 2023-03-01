using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.Data.Migrations
{
    public partial class _10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderDetailId",
                table: "Order");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Order",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "f76614bc-e66b-467b-8341-204e42088690");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "31ce3f4c-fd00-486d-895b-b4e5cd9df3ab");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "b1de9dbc-5887-4b40-bc0f-a0001aa43747");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea8a3f5e-9e47-48ac-a7c3-510f1e73c2ef", "AQAAAAEAACcQAAAAENNSW0LMSsRfXQBYz8Hfa20Mm6aT3ggnPEEM+ui/chfphAqimXVjchRTO9S4TXDsRw==", "9c707169-db2a-4c24-b20c-162d51aef3ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08c74c6f-4129-4511-b468-bca5141ac4e5", "AQAAAAEAACcQAAAAEKdzOLzhblQyP1YTmlZ0Zy4NYSdSJhOfLhhLkKVfkscebWH3g9wZrRrP6klDaHKu7A==", "a5f812a9-936f-40a8-9fc9-ea6b4d36ec8d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5e2cdce-685c-4ee3-9067-9755fc9badd0", "AQAAAAEAACcQAAAAEHd4jOrhHL0H+K0LXL913++TaiqLlgOv3Ob3Bk7S4iVHbtevFl5q0QYZ8yIP7cg7BA==", "7d2c8003-b034-494a-a437-6d71546c10f6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Order",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderDetailId",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
