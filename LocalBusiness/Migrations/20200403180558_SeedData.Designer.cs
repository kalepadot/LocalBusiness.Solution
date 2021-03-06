﻿// <auto-generated />
using LocalBusiness.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LocalBusiness.Migrations
{
    [DbContext(typeof(LocalBusinessContext))]
    [Migration("20200403180558_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LocalBusiness.Models.Restaurant", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Type");

                    b.HasKey("RestaurantId");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            RestaurantId = 1,
                            Name = "Harus Bakery",
                            Type = "Bakery"
                        },
                        new
                        {
                            RestaurantId = 2,
                            Name = "Harus Cafe",
                            Type = "Cafe"
                        },
                        new
                        {
                            RestaurantId = 3,
                            Name = "House of Haru",
                            Type = "Sushi"
                        },
                        new
                        {
                            RestaurantId = 4,
                            Name = "Ristorante Harus",
                            Type = "Italian"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
