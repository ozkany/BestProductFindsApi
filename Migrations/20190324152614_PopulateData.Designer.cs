﻿// <auto-generated />
using System;
using BestProductFindsApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BestProductFindsApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190324152614_PopulateData")]
    partial class PopulateData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BestProductFindsApi.Data.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Men's"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Women's"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Outdoors"
                        });
                });

            modelBuilder.Entity("BestProductFindsApi.Data.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoryId");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<int?>("SellerId");

                    b.Property<string>("URL");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SellerId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreateDate = new DateTime(2019, 3, 24, 18, 26, 14, 186, DateTimeKind.Local).AddTicks(370),
                            Description = "Koton Erkek Slim Pantolon",
                            Name = "Koton Erkek Slim Pantolon",
                            Price = 70.39m,
                            SellerId = 1,
                            URL = "https://www.hepsiburada.com/koton-erkek-slim-pantolon-p-HBV00000DI558"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CreateDate = new DateTime(2019, 3, 24, 18, 26, 14, 187, DateTimeKind.Local).AddTicks(3260),
                            Description = "Lc Waikiki Erkek Polo Yaka Tshirt",
                            Name = "Lc Waikiki Erkek Polo Yaka Tshirt",
                            Price = 29.99m,
                            SellerId = 1,
                            URL = "https://www.hepsiburada.com/lc-waikiki-erkek-polo-yaka-tshirt-p-HBV00000GR2VA"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            CreateDate = new DateTime(2019, 3, 24, 18, 26, 14, 187, DateTimeKind.Local).AddTicks(3280),
                            Description = "Kadın Siyah Pantolon IW6180003108 IW6180003108",
                            Name = "Kadın Siyah Pantolon",
                            Price = 164.50m,
                            SellerId = 2,
                            URL = "https://www.trendyol.com/ipekyol/kadin-siyah-pantolon-iw6180003108-p-3603675?boutiqueId=309730&merchantId=968"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            CreateDate = new DateTime(2019, 3, 24, 18, 26, 14, 187, DateTimeKind.Local).AddTicks(3280),
                            Description = "Kadın Bej Etek (18805)",
                            Name = "Kadın Bej Etek",
                            Price = 420.00m,
                            SellerId = 2,
                            URL = "https://www.trendyol.com/burberry/kadin-bej-etek-18805-p-3224783?boutiqueId=307783&merchantId=4421"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            CreateDate = new DateTime(2019, 3, 24, 18, 26, 14, 187, DateTimeKind.Local).AddTicks(3280),
                            Description = "Jean Pantolon | Sophie - Skinny",
                            Name = "Jean Pantolon",
                            Price = 149.90m,
                            SellerId = 3,
                            URL = "https://www.morhipo.com/kampanya/detay/15359570/80621/tommy-hilfiger-jean-pantolon-sophie-skinny"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            CreateDate = new DateTime(2019, 3, 24, 18, 26, 14, 187, DateTimeKind.Local).AddTicks(3280),
                            Description = "Ceket",
                            Name = "Ceket",
                            Price = 904.90m,
                            SellerId = 3,
                            URL = "https://www.morhipo.com/kampanya/detay/20712902/80613/emporio-armani-ss1600001979-ceket"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            CreateDate = new DateTime(2019, 3, 24, 18, 26, 14, 187, DateTimeKind.Local).AddTicks(3290),
                            Description = "Samsung 40J5270 40\" 102 Ekran Uydu Alıcılı Full HD Smart LED TV",
                            Name = "Samsung 40J5270 40\" 102 Ekran Uydu Alıcılı Full HD Smart LED TV",
                            Price = 2191.50m,
                            SellerId = 1,
                            URL = "https://www.hepsiburada.com/samsung-40j5270-40-102-ekran-uydu-alicili-full-hd-smart-led-tv-p-EVTVSAM40J5270"
                        });
                });

            modelBuilder.Entity("BestProductFindsApi.Data.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("WebSite");

                    b.HasKey("Id");

                    b.ToTable("Sellers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Hepsiburada",
                            WebSite = "www.hepsiburada.com"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Trendyol",
                            WebSite = "www.trendyol.com"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Morhipo",
                            WebSite = "www.morhipo.com"
                        },
                        new
                        {
                            Id = 4,
                            Name = "ModaCruz",
                            WebSite = "www.modacruz.com"
                        });
                });

            modelBuilder.Entity("BestProductFindsApi.Data.Product", b =>
                {
                    b.HasOne("BestProductFindsApi.Data.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("BestProductFindsApi.Data.Seller", "Seller")
                        .WithMany()
                        .HasForeignKey("SellerId");
                });
#pragma warning restore 612, 618
        }
    }
}
