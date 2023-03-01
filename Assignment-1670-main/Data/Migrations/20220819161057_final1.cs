using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.Data.Migrations
{
    public partial class final1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "33103d81-d293-421c-9c0b-77e22eeb18fc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "c133f7d4-1759-4c53-bd0c-cbe732ee9e6b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "93956814-1879-42d5-bc1e-f00d820a3e55");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32216b40-1389-4df5-bb9a-15933bd0f410", "AQAAAAEAACcQAAAAENwe3zELqJUkOpN3IOBL85g7L0FmosRlTJNymk0TlyP+97BMspiv6XUY9mr1m19uvA==", "c0914c4a-3fc6-496a-9793-aeaaa2751e6b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50161acb-f015-4c34-99ee-60443eeb83b4", "AQAAAAEAACcQAAAAEHcFmuRqRb9BUGHNF8GYT9eFhPdKS5JFh7Uv6plk+iL+iFVJ0osesN8aCSRTfZHLcw==", "8a1d30d3-8cf6-4ead-a8b8-ac8ae366a0a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "235a6e25-0342-4f77-b34d-2405c547a1b0", "AQAAAAEAACcQAAAAELGE6PLJxPP84pVfiIRqWbQrxx3WXwVO23kmQ/kvfODuC0WEfgMXOBNqQ4cZdmAiHQ==", "f9fbdf9e-1ac4-4150-a4af-20bb80200be7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "179793a2-6e66-449f-8067-63546856b4e8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "23e1fd79-fdf6-45ac-b8f6-59da2050b72f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "26ab6de8-b0a1-4a9a-b788-5604d79710ac");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "541585c2-32d8-4c11-a317-e3a5138fb130", "AQAAAAEAACcQAAAAEM3nwepH4t2wkwtZ1v1o19WZP/91zWXp0CBpoP9LV9AVf2P90y5TL9dSYJNYaW9mRQ==", "0e8a2e00-229c-4463-9bb4-a16721bc25e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c542c746-64c2-4fef-bf5d-80fce61b48a8", "AQAAAAEAACcQAAAAEI78gfuRfJdeKFgTvJcD+jXRY6m5K7762LBEYJkxSakuCvKMeDp63WiY97kWbl3k7Q==", "758fb26b-125b-488b-883c-51af83db8561" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ebb990f-6d33-47f0-ba08-ccf456eed43e", "AQAAAAEAACcQAAAAEAlS6e165BUPWjDdMqU2upCBpzlFCT9cHnQ/qwg0ffdHf8D8qc+at1D6UitkL6PXfw==", "d0c88685-383b-4ae2-a081-d7ee31040fcf" });
        }
    }
}
