using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.Data.Migrations
{
    public partial class h1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "f0748963-3c9e-466a-9180-8f0cc3adce45");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "1efd9d1c-d733-458c-9647-59eeaaf5ac7b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "6af31bd2-8096-449d-8475-2f6bc7f417ed");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc8557ea-dd39-49b4-a8c8-e78c8fe163d7", "AQAAAAEAACcQAAAAEFERXBPeYegQwIKhTnylfQbEuuJR7U9x6QESSj9YmNqX9eoRUtSaEAq9UWEW2JDDoA==", "e64ae0d0-e216-4e7b-8285-c26224adb6f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfaf894d-34c4-45ff-889e-dbaab350183a", "AQAAAAEAACcQAAAAEINUlOui79uB9oxi/vkfjrVf7/3iXZQXP/ostdvHbzI/OA/an0UwTc41nTtJOxT0UA==", "9c943c90-3b70-4cae-a27a-1478ea7ab495" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "639b382e-3f24-41ac-9683-fd4ac072bc3e", "AQAAAAEAACcQAAAAELqHOcArtxdSESE8G426aPKFsBVsRS/GY/PskuAdTBmkU5pvdeOzAYKnTHxPod5vcQ==", "42f2bbe2-180c-4143-abf1-013b547b1b11" });
        }
    }
}
