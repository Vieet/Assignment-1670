using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.Data.Migrations
{
    public partial class _7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Total",
                table: "OrderDetail",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "71a17528-c35c-4645-b8bb-ce0a98523172");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "6ac84780-378a-4ae3-8379-2b6427e62855");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "31fe974b-2d60-420b-859c-42a2395a2329");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7225807-ec94-4dfc-8550-8a341e1da0e4", "AQAAAAEAACcQAAAAEHZ3Zr0nRVPKy6CR9jfSFD0lXdF8KnS0/3RqNzY1TOs5/j14meAK2BhD95gQcGGBWA==", "2d97330c-e044-43a9-a3e6-dfd19efd8994" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48d46823-5077-4cb1-8117-d7e9e1c764ef", "AQAAAAEAACcQAAAAEMU19hXdeoMl7xGLt2CA/OS4e14XamRPVmQx6BC+RMGj2KFfavZ7unL/Y7h+hfkL3A==", "0b78e9bf-0b67-4367-bc30-d66c92e075eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d07ae0ba-2fe5-4ec0-a36a-aa2e3bf01e6b", "AQAAAAEAACcQAAAAEE5hs5qTBacRjw9X8XCwxl6K3RKLXW/MQCY40dFi4gaGGWIkCqaqQRYv0qBkc7XBSQ==", "540978fe-2ddd-4065-9e6d-b420a51a8786" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Total",
                table: "OrderDetail",
                type: "real",
                nullable: false,
                oldClrType: typeof(double));

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
    }
}
