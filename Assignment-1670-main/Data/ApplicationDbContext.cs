using Assignment.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Book> Book { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<CategoryRequest> Request { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedBook(builder);
            SeedCategory(builder);
            SeedUser(builder);
            SeedRole(builder);
            SeedUserRole(builder);
        }
        private void SeedBook(ModelBuilder builder)
        {
            builder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "Harry Potter Vol 1",
                    Publisher = "Bloomsbury",
                    Author = "J.K. Rowling",
                    YearPublished = 1997,
                    Image = "https://images-na.ssl-images-amazon.com/images/I/515iJ1-+IvL.jpg",
                    Price = 11.99,
                    Quantity = 100,
                    CategoryId = 1
                },
                new Book
                {
                    Id = 2,
                    Title = "Sherlock Holmes Vol 1",
                    Publisher = "Kim Dong",
                    Author = "Conan Doyle",
                    YearPublished = 1892,
                    Image = "https://images-na.ssl-images-amazon.com/images/I/41Di3v-DFZL._SX363_BO1,204,203,200_.jpg",
                    Price = 10,
                    Quantity = 100,
                    CategoryId = 2
                },
                new Book
                {
                    Id = 3,
                    Title = "DoraBase",
                    Publisher = "Kim Dong",
                    Author = "Mugiwara",
                    YearPublished = 2008,
                    Image = "https://images.thuvienpdf.com/LVAq31.webp",
                    Price = 6,
                    Quantity = 50,
                    CategoryId = 4
                },
                new Book
                {
                    Id = 4,
                    Title = "IT - Gã Hề Ma Quái",
                    Publisher = "Thanh Niên",
                    Author = "Stephen King",
                    YearPublished = 2022,
                    Image = "https://cdn0.fahasa.com/media/catalog/product/8/9/8936066693349-1_2.jpg",
                    Price = 15,
                    Quantity = 50,
                    CategoryId = 3
                },
                new Book
                {
                    Id = 5,
                    Title = "Đắc Nhân Tâm",
                    Publisher = "NXB Trẻ",
                    Author = "Dale Carnagie",
                    YearPublished = 2012,
                    Image = "https://s.memehay.com/files/posts/20201216/cuon-sach-dak-nhan-tam-dark-nhan-tam.png",
                    Price = 15,
                    Quantity = 2000,
                    CategoryId = 5
                }
            );
        }
        private void SeedCategory(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Fantasy"
                },
                new Category
                {
                    Id = 2,
                    Name = "Detective"
                },
                new Category
                {
                    Id = 3,
                    Name = "Horror"
                },
                new Category
                {
                    Id = 4,
                    Name = "Manga"
                },
                new Category
                {
                    Id = 5,
                    Name = "Business"
                }
            );
        }
        private void SeedUserRole(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = "1",
                    RoleId = "1"
                },
                new IdentityUserRole<string>
                {
                    UserId = "2",
                    RoleId = "2"
                },
                new IdentityUserRole<string>
                {
                    UserId = "3",
                    RoleId = "3"
                }
            );
        }

        private void SeedRole(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "1",
                    Name = "Admin",
                    NormalizedName = "Admin"
                },
                new IdentityRole
                {
                    Id = "2",
                    Name = "StoreOwner",
                    NormalizedName = "StoreOwner"
                },
                new IdentityRole
                {
                    Id = "3",
                    Name = "Customer",
                    NormalizedName = "Customer"
                }
            );
        }

        private void SeedUser(ModelBuilder builder)
        {
            var admin = new IdentityUser
            {
                Id = "1",
                Email = "admin@gmail.com",
                UserName = "admin@gmail.com",
                NormalizedUserName = "admin@gmail.com"
            };
            var storeowner = new IdentityUser
            {
                Id = "2",
                Email = "storeowner@gmail.com",
                UserName = "storeowner@gmail.com",
                NormalizedUserName = "storeowner@gmail.com"
            };
            var customer = new IdentityUser
            {
                Id = "3",
                Email = "customer@gmail.com",
                UserName = "customer@gmail.com",
                NormalizedUserName = "customer@gmail.com"
            };

            var hasher = new PasswordHasher<IdentityUser>();

            admin.PasswordHash = hasher.HashPassword(admin, "Admin@123");
            storeowner.PasswordHash = hasher.HashPassword(storeowner, "Store@123");
            customer.PasswordHash = hasher.HashPassword(customer, "Cus@123");

            builder.Entity<IdentityUser>().HasData(admin, storeowner, customer);
        }
    }
}
