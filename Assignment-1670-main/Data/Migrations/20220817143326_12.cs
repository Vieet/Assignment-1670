using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.Data.Migrations
{
    public partial class _12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Total",
                table: "OrderDetail",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "Total",
                table: "Order",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ed195978-0be0-42a1-93b5-4f9b4ddc9b17");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "753680b3-e584-473f-b8ad-e34c2cfd3882");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "2f5d6af3-eb39-4909-b025-e9866a50b37f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e675c70a-b733-4767-97c9-fa4166fc7357", "AQAAAAEAACcQAAAAEDHxhJ5ltTp6cJwMEP7js2kg1oRLGlgcq+SSwEj0k9aMvnHGArTFlmw7mJlhv3wiPw==", "39924242-0743-4fdd-b1b1-0674a54d6257" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d204d686-0320-4745-abe8-aa41a462c119", "AQAAAAEAACcQAAAAEI0028EpeJDoq4H04x5DxdB+Cnv9HFiYTusv5arPFEVxwFFMr4IF2WrIyg8xC4ASBA==", "72cf2c88-d67d-4ec3-b41b-92daa5297a19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c330278-2ba1-49d2-afc8-05fcb3a8c9c8", "AQAAAAEAACcQAAAAEA/vQKUkiRLsYLn4fZ+areklDRuXVg91Z9FLDqk55XbBF8giTuVLixYz9VV5mKnS+g==", "54285a25-c53c-4095-b05a-40a3db57a210" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Total",
                table: "OrderDetail",
                type: "real",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "Total",
                table: "Order",
                type: "real",
                nullable: false,
                oldClrType: typeof(double));

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
    }
}
