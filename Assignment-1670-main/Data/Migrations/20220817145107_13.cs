using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.Data.Migrations
{
    public partial class _13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Order",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "80abc344-c147-4179-94bd-0a8242fdbd11");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "08d7ccb4-e0f5-4eb0-ac14-cf824cc5897c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "eb3ddfda-bf3a-4183-8b2f-b7d09df871b0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b901653d-0f20-4396-acde-91954dc4d084", "AQAAAAEAACcQAAAAEHpCUVZBFMsYoxkVVuflLEu6AE/ADgEwpvH8dmBKywtnlgIaA3L+/Xt7IynZ63s7rw==", "52a59bf5-76d4-490f-9419-8d68f2fd02aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38445186-8b53-4b74-8366-4ac1ea90edcf", "AQAAAAEAACcQAAAAEBBLGhv9s9q2kHw9OrxlqQChOlBNkAVktoiQfNpIChyOvo7aWQrOhFQUezdjfTU5ng==", "7fadd7c0-ab20-4117-a67b-b7b3fb260f51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea6b5f9c-fb7a-439f-b4bf-1e157e953e4b", "AQAAAAEAACcQAAAAEHdbLIPWKdbcYDY9h/ceUWgev+gD7cvTvrssZtUxPmlUASbhBo7dyY/N3qVkPQYO2Q==", "ba20b759-2ca4-44e9-ab6b-a2a8ac8732b2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Order");

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
    }
}
