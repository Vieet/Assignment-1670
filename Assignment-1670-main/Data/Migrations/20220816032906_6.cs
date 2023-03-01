using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.Data.Migrations
{
    public partial class _6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "OrderDetail");

            migrationBuilder.AddColumn<float>(
                name: "Total",
                table: "OrderDetail",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Total",
                table: "Order",
                nullable: false,
                defaultValue: 0f);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Order");

            migrationBuilder.AddColumn<float>(
                name: "TotalPrice",
                table: "OrderDetail",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "1d729c32-69e3-487b-92ae-388e1af1d783");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "c980c6c8-e4ba-4307-ab84-0a134eb851a3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "89e50728-3eda-4ee4-8dfb-5fe324f642d8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28e17937-65a6-408e-97e1-344164080721", "AQAAAAEAACcQAAAAEMAFC1u+d8SK+Tpnce5Keow18+rpfe1jvPwbbRTxsfI5TEQ9e3Db2EPYtWQw6zXzUg==", "b6928773-bce4-42bd-8556-17995c0bb9c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c824ce55-380f-4fdd-bc02-a9832c1ece48", "AQAAAAEAACcQAAAAEN26ENPSQfL3aFZZlkEgUBTvKu/5XuRFANh64reBYSmKmonQ2Sz9mfcY62tdNeHnjQ==", "67eb44c5-0359-4c18-84dd-cd0c4d884972" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d9af504-3f32-4d23-abf8-5917c64547e2", "AQAAAAEAACcQAAAAEAnyDToP4PXHJRXXiCJLtbbu1eQ4jJod0WZ/7hF02iTQ2j2OM0YsY7AqqdqfDNA6Qw==", "03bdeffd-b22c-4160-bacd-c95cc919f707" });
        }
    }
}
