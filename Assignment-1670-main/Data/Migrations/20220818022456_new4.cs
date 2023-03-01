using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.Data.Migrations
{
    public partial class new4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "Horror" },
                    { 4, "Manga" },
                    { 5, "Business" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "Author", "CategoryId", "Image", "Price", "Publisher", "Quantity", "Title", "YearPublished" },
                values: new object[] { 4, "Stephen King", 3, "https://cdn0.fahasa.com/media/catalog/product/8/9/8936066693349-1_2.jpg", 15.0, "Thanh Niên", 50, "IT - Gã Hề Ma Quái", 2022 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "Author", "CategoryId", "Image", "Price", "Publisher", "Quantity", "Title", "YearPublished" },
                values: new object[] { 3, "Mugiwara", 4, "https://images.thuvienpdf.com/LVAq31.webp", 6.0, "Kim Dong", 50, "DoraBase", 2008 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "Author", "CategoryId", "Image", "Price", "Publisher", "Quantity", "Title", "YearPublished" },
                values: new object[] { 5, "Dale Carnagie", 5, "https://s.memehay.com/files/posts/20201216/cuon-sach-dak-nhan-tam-dark-nhan-tam.png", 15.0, "NXB Trẻ", 2000, "Đắc Nhân Tâm", 2012 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "80abc344-c147-4179-94bd-0a8242fdbd11");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "08d7ccb4-e0f5-4eb0-ac14-cf824cc5897c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "eb3ddfda-bf3a-4183-8b2f-b7d09df871b0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b901653d-0f20-4396-acde-91954dc4d084", "AQAAAAEAACcQAAAAEHpCUVZBFMsYoxkVVuflLEu6AE/ADgEwpvH8dmBKywtnlgIaA3L+/Xt7IynZ63s7rw==", "52a59bf5-76d4-490f-9419-8d68f2fd02aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38445186-8b53-4b74-8366-4ac1ea90edcf", "AQAAAAEAACcQAAAAEBBLGhv9s9q2kHw9OrxlqQChOlBNkAVktoiQfNpIChyOvo7aWQrOhFQUezdjfTU5ng==", "7fadd7c0-ab20-4117-a67b-b7b3fb260f51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea6b5f9c-fb7a-439f-b4bf-1e157e953e4b", "AQAAAAEAACcQAAAAEHdbLIPWKdbcYDY9h/ceUWgev+gD7cvTvrssZtUxPmlUASbhBo7dyY/N3qVkPQYO2Q==", "ba20b759-2ca4-44e9-ab6b-a2a8ac8732b2" });
        }
    }
}
