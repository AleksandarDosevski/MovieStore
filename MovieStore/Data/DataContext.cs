using MovieStore.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieStore.Models;
using Microsoft.Extensions.Configuration;

namespace MovieStore.Data
{
    public class DataContext : IdentityDbContext<IdentityUser>
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public IConfiguration Configuration { get; }

        // ********* we have to tell the datacontext class about our models *********
        public DbSet<Movie> Movies { get; set; }   // table name
        public DbSet<Category> Categories { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<PreOrder> PreOrders { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            const string ADMIN_ID = "b4280b6a-0613-4cbd-a9e6-f1701e926e73";
            const string ROLE_ID = ADMIN_ID;
            const string password = "admin123abc";
            //var passwordFromSettings = new ConfigurationBuilder()
            //    .AddJsonFile("appsettings.json")
            //    .Build()
            //    .GetSection("AdminCredentials")["Password"];
            //var emailFromSetting = new ConfigurationBuilder()
            //    .AddJsonFile("appsettings.json")
            //    .Build()
            //    .GetSection("AdminCredentials")["Username"];

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = ROLE_ID,
                    Name = "admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = "b4280b6a-0613-4cbd-a9e6-f1701e926e74",
                    Name = "editor",
                    NormalizedName = "EDITOR"
                },
                new IdentityRole
                {
                    Id = "b4280b6a-0613-4cbd-a9e6-f1701e926e75",
                    Name = "guest",
                    NormalizedName = "GUEST"
                }
            );

            var hasher = new PasswordHasher<IdentityUser>();

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = ADMIN_ID,
                UserName = "admin@onlineMovieStore.com",
                NormalizedUserName = "ADMIN@ONLINEMovieStore.COM",
                Email = "admin@onlineMovieStore.com",
                NormalizedEmail = "ADMIN@ONLINEMovieStore.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, password),
                SecurityStamp = string.Empty,
                ConcurrencyStamp = "c8554266-b401-4519-9aeb-a9283053fc58"
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });

            // Category Seed Data
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Fiction"
                },
                new Category
                {
                    Id = 2,
                    Name = "Action"
                },
                new Category
                {
                    Id = 3,
                    Name = "Crime"
                },
                new Category
                {
                    Id = 4,
                    Name = "Adventure"
                },
                new Category
                {
                    Id = 5,
                    Name = "Drama"
                },
                new Category
                {
                    Id = 6,
                    Name = "Fantasy"
                },
                new Category
                {
                    Id = 7,
                    Name = "Thrillers"
                },
                new Category
                {
                    Id = 8,
                    Name = "General"
                },
                new Category
                {
                    Id = 9,
                    Name = "Horror"
                },
                new Category
                {
                    Id = 10,
                    Name = "Uncategorised"
                }
            );

            // Director Seed Data
            modelBuilder.Entity<Director>().HasData(
                new Director
                {
                    Id = 1,
                    Name = "James Cameroon",
                    ShortDescription = "Description",
                    Popularity = true
                }
            );


            // Movie Seed Data
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1,
                    Title = "Titanic",
                    DirectorID = 1,
                    DirectorName = "James Cameroon",
                    CategoryID = 5,
                    CategoryName = "Drama",
                    Copies = 100,
                    Country = "USA",
                    Description = "Description",
                    Language = "English",
                    Price = 25,
                    Shipping = "Free",
                    YearOfRelease = new DateTime(2020, 02, 29, 23, 29, 25),
                    PhotoURL = "Titanic.jpg",
                    SoldItems = 20
                }
            );

            base.OnModelCreating(modelBuilder);
        }

    }
}
