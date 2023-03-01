using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.Data.Migrations
{
    public partial class _5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "4306126c-1b9b-4930-b0b6-dc2de543b8b5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "a84ae83b-130f-4353-b5fb-63f59d1665d4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "ec86e51e-d6fb-42dd-9e5f-08fc2194590c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b634ec48-f274-49c2-aef4-3505554ad11f", "AQAAAAEAACcQAAAAEPmglsI00o81nODI5MpFLYXnYFNtFVKzutlnPi0qWbaaBl64PoE7zh1MAStFLQU7cQ==", "32969ff9-192b-41af-85d7-833c114ab17b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "803e7859-f0a2-4125-8727-6b3583b1b2c4", "AQAAAAEAACcQAAAAEJHhLJlkW56Q9dXhZpbbj5D/g6HwS7QOM3UnP2lOxCIgykRQXXIBZObvs/4hshf1eQ==", "28e20d6d-9406-45ac-a638-b68560130b93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "812b5618-0331-4a73-b93f-41c1f0baec36", "AQAAAAEAACcQAAAAEBMYSKwEYjHwYV+os5BBOYCDkLx5WZAUO7NYG2nOsbiMdCZvhj2zbjO5jGCtD1wmKg==", "9f670466-8c1f-4c0b-bdb5-3c2d23a9cd1a" });
        }
    }
}
