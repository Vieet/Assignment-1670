using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.Data.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "d4e2ed11-a0e6-4e0a-a905-b7efa5a751e7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "9cf222c6-3ee0-4d50-acc2-e3782330ece6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "089c5e20-825e-478a-97a4-6734334286e1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad1fb03c-42a7-4b06-a1de-e82421452331", "AQAAAAEAACcQAAAAEBWn6tSx65hNdE9j0MbZwQGqc6h1Ea8JrvcF0RDCD6FE1FjtAd42BSTwvL5GAWzI2w==", "3c019176-dc05-4a58-8957-09c067136679" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15aa5c77-aa1e-4ff2-a1d3-ab30346c83f3", "AQAAAAEAACcQAAAAEAlrE/EMOVuHV1b+3TjSbLEBJOtdHuAKqIweCJXW4l52mKkz/nMRUuIq6575Xxn6jg==", "3251d266-3e88-4181-9962-c2a051389013" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c49c48b4-04e7-43ed-8716-69e1e9fa2b95", "AQAAAAEAACcQAAAAENxfGZWDgH13HZv0fgipDgPRbcbKzgzRhW08c0uDfYRcEWP644y5PxrtTHxtuEfJ+A==", "57171d92-9c7a-4920-bf8b-9effee66e386" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "99b08fe7-6113-4737-937c-a9d22d1bf731");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "42e6b203-a3e3-45c5-af42-814e6b74a389");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "126858d4-301d-4602-b248-3cb5ed45b7d1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6771b48-9f32-4147-bc57-c003ba6ae174", "AQAAAAEAACcQAAAAEBMPbsP6dYzmj5xkrE3fhz4u6502mcPbrZR1z7+WLGdiiXLQa+wYnUpJFVyNETQGPw==", "be29b687-b221-463d-8b03-0dda520876cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2b88731-c68b-45b0-86c8-fa956ca8871a", "AQAAAAEAACcQAAAAEEObr3Ri6phVkOnEKh6qdX77tk4VxPBfCTdJCrn9B+yVIzCsmNIQNyC+qqv3v4EwAw==", "80dc0e29-3d70-4243-911e-33f394080fdc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba0fefde-3681-4e4f-b9e1-4270fe298b32", "AQAAAAEAACcQAAAAEHs6I6EgipmmCinEHQDm/g7i3bVV1vW4XP+VeB/M8tWckhYpWQo/hQYshFO4la94bw==", "eb3213df-2e7b-40a7-a9bf-aaa9fc41da91" });
        }
    }
}
