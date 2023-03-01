using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.Data.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
