using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.Data.Migrations
{
    public partial class final2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "496b7fc1-1846-4f88-9a2c-e35885262c8d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "15925a31-532f-41ca-97fd-9ab9aa4c76b8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "48fcba8b-8fa9-44cd-936e-37605329e0f4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0bf03bd0-2dac-4826-b87c-d9cc7e9b7146", "AQAAAAEAACcQAAAAEE5R9wSzlxTeXAgFuPNnFsaoCHAJKE6jUTC5PFkVolK+p4H3L75zGeOAzGrnTgyw7A==", "d2a78f4f-469b-4d49-8983-3927f3553a21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eccd2ab5-074f-4840-a131-c231d8a92c67", "AQAAAAEAACcQAAAAEKbE5KyavbdCRp0ckHk+2/8BMXqP/ec2Bd2OHRgBTRm/VW0Y5BFMf/8kBmDyufUiDg==", "c7908ebe-3c55-4ed4-8992-bec5b811ce46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7f65d94-084f-41e2-85f9-26b0892ac623", "AQAAAAEAACcQAAAAEMFng5tz6PfWBRAddRnRnNpg0N/fC29w0AnXqfrU4CgRoZytC/SMPaTPe21JZX/ZVg==", "2028f719-22d6-4e6e-bce5-21c7b6c047f5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
