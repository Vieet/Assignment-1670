using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.Data.Migrations
{
    public partial class new5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "fc13b203-9b09-4895-9fae-ad7d133469c9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "86c6abb1-e83b-4a90-9dbb-58721ff9466a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "0e0a4372-5caa-4eb5-8e03-4c4d5d8096df");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6482ad7-40a1-4f13-bc3b-92b9d6ca52ba", "AQAAAAEAACcQAAAAECkbc+0A8RSPruPMY5fvGDviyWblyRhLNI60vyTf7VUZaHzsVmHkHs+meEUPzyC6Sg==", "d4ae915b-60f6-48f9-a2f9-144844f5464e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "985fe068-4c9c-42de-8afe-b39a02248e03", "AQAAAAEAACcQAAAAEMDpJG6ic/sK7Cm1YTAc932mn94XaMFWax95v2sACduCfTWotmPJoRcV2//ER/kgoQ==", "2523cc5c-1dc5-44da-93bb-e3af97651a46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2406813a-c51b-47ec-8469-7f785fa3508d", "AQAAAAEAACcQAAAAEIYXUgbCSXH2+upRAuU+VTp9rKQsdzx9Snhqbf1Aqh36KHZdLQnS3SlhicFuNMMOSw==", "75c6560f-6ade-4220-a271-9b3b88f68c79" });
        }
    }
}
