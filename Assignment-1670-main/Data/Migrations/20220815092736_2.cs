using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.Data.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "93737474-f942-4ddd-b44e-0860478b8943");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "1dc9f4a0-8165-4b39-b5be-b49da0d2f876");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "708d9cc0-ea06-4a8b-ac45-6672ce64449e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7244b51-c098-4885-87c2-28ec1f632283", "AQAAAAEAACcQAAAAEDWFJhPjR+CGBXvrjtBaGxObGLAlMqsxCKPrTgI6pQCqjeQaIP0J7UFAfKS8UnS7bg==", "961558bf-6486-453a-869c-a85af646dea2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c218d101-bc9f-42fd-bc9e-0827b3eef132", "AQAAAAEAACcQAAAAEBr+SSNfbLIXmVe1K7Kc5jYlCRfClaunkFEj+vxIFm4zdhEVugdZ+TZmZW0o50MHRQ==", "77d5d5ff-7e59-40f4-bcb8-bf6fea3a1753" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3ff7950-ef5d-4d31-9ff7-2d2fa18feab7", "AQAAAAEAACcQAAAAEPt7IN3iY6odDnNyFFn4jOSisJPJ0CTBgBTTEtGbztC7pQv+7Mq3yGg+oorxtiERjg==", "f9bd6773-5445-4391-83e9-fddf3c691e74" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "7b4e8f27-ee9e-4aac-8ba5-8a1a3dcaa863");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "15dcdb81-04e4-4d5f-8628-86c87386972e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "ea0351b0-8134-4065-b914-a593c1531897");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b577c88d-062b-4109-8fb4-b56181b1f0b8", "AQAAAAEAACcQAAAAEILVjtbBUxydkoGqWBU0m5ks6YcjzPwxWSD6XUjxGDt3LHc7GgU/tFnqJ4M0jTY+rw==", "74c22f6a-d907-4d44-961f-815fb1619fe6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ebb4511-c25e-4525-aa9b-528711bda302", "AQAAAAEAACcQAAAAEHrrPcusYibe9KxLgQk65KW0GOrd0OO1GEzYpqNoI1Ic664JVJrEWy6eM9er/H8vVg==", "1be0afe2-eb95-4e27-8012-7ae9f8334d0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd428477-cb10-4cc6-ab5b-88d50cb426c7", "AQAAAAEAACcQAAAAEOR4ZPqVe4PQtPH2Q0UkHbcBtsDSi5FQ1oEUnJdwaotwxnmDiohSqrLzChkPpoz3Zg==", "5701e837-d8a5-49fa-b7e7-635814402e16" });
        }
    }
}
