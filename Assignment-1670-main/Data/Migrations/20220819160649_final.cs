using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.Data.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "fa503d2f-4769-4542-af7a-e3ea47201dbf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "6b2e9baf-043c-42db-a989-d478e4826362");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "eaa5ab77-2553-434d-844d-442819a35e19");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3866cf88-9440-482a-8b28-45b437f8e766", "AQAAAAEAACcQAAAAEM0Wt4bKFwsVppGpiNumlNcdq/5mnc19pEAz6N0TF+Tjt3NLUBxpG+U2H0C5NGJWEg==", "47d9b9cb-13d8-4d6e-bd0d-5e2e32429b39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86b05a5f-6c6c-497c-846e-d441710abefb", "AQAAAAEAACcQAAAAECCQxI1fPtwR+CVR1DGP4PG870PngYgIAFChspNL3bWcaqPP3xfTHE0CLzVO97VEUQ==", "e0fe4ea2-bbb3-4976-b026-5813405eda46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b745073-a033-4a14-8c14-9d0f99f976bf", "AQAAAAEAACcQAAAAEBnpMU4259OEYzugsIp2RSTcJC+FqqkaXwn3MFND56YW7MbJSpJ/9TyO6lMRURJodw==", "9a494c19-49bc-47a2-8ca1-ea8128df018d" });
        }
    }
}
