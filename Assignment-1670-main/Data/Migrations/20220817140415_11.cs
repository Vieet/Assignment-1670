using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.Data.Migrations
{
    public partial class _11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Total",
                table: "OrderDetail",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ca78fda6-e617-4d20-9976-94e2c393b609");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "8b52842d-4b9f-4325-991c-baf42266d743");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "0b9fb168-cfe1-47d1-b12b-7c4ac06b48a1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b97cf6c-0888-4f7b-b166-6523245cb7f7", "AQAAAAEAACcQAAAAEAcCFFMe1oOqWsid2ho/k4S7Ku8Xk2P4hdFlBZSGJ6pZMnFXZYPdBb0fYsCbrf08EA==", "61d4f68c-fafb-4f8d-af6e-0395db0cceaf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c78eba3c-792f-4df4-9435-70a6733dcf3a", "AQAAAAEAACcQAAAAEESQ9TUYX3y9TNzMmYr6tMBmrRZGDSP+WvqXZmgv6uw+SXmvKxn5W2IM3ZqDGrPnOQ==", "c6d451e2-0a58-47e1-a9ff-f1b2b47bcd9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "257784cb-d8ef-4286-8c8d-ca429acfddbd", "AQAAAAEAACcQAAAAEIWwYgxqDxlJ6gPWO6dbomGDXwS/LHsgTOb8mXFosAAygCB0Gz4ZCveC1mkytgQKwg==", "8cdf07ea-a4ee-4089-92ab-7fcf3b14533d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Total",
                table: "OrderDetail",
                type: "float",
                nullable: false,
                oldClrType: typeof(float));

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
    }
}
