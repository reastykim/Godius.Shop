﻿// <auto-generated />
using Godius.Shop.Data;
using Godius.Shop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Godius.Shop.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180214023053_AddItemGeneration")]
    partial class AddItemGeneration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Godius.Shop.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Godius.Shop.Models.Goods", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<string>("SerialCode");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Goods");
                });

            modelBuilder.Entity("Godius.Shop.Models.GoodsCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("SerialCode");

                    b.HasKey("Id");

                    b.ToTable("GoodsCategories");
                });

            modelBuilder.Entity("Godius.Shop.Models.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AC");

                    b.Property<int>("Category");

                    b.Property<int>("DC");

                    b.Property<string>("Description");

                    b.Property<int>("Durability");

                    b.Property<int>("Generation");

                    b.Property<int>("HC");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<int>("WC");

                    b.Property<int>("Weight");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Godius.Shop.Models.ItemGoods", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<Guid>("GoodsId");

                    b.Property<Guid>("ItemId");

                    b.Property<double>("Probability");

                    b.HasKey("Id");

                    b.HasIndex("GoodsId");

                    b.HasIndex("ItemId");

                    b.ToTable("ItemGoods");
                });

            modelBuilder.Entity("Godius.Shop.Models.Purchase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("Date");

                    b.Property<Guid?>("GoodsId");

                    b.Property<string>("PurchaserId");

                    b.Property<Guid>("ResultItemId");

                    b.HasKey("Id");

                    b.HasIndex("GoodsId");

                    b.HasIndex("PurchaserId");

                    b.ToTable("PurchaseHistory");
                });

            modelBuilder.Entity("Godius.Shop.Models.ResultItemGoods", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ItemGoodsId");

                    b.Property<Guid>("PurchaseId");

                    b.Property<int>("UpgradeDurability");

                    b.Property<int>("UpgradeOption");

                    b.HasKey("Id");

                    b.HasIndex("ItemGoodsId");

                    b.HasIndex("PurchaseId")
                        .IsUnique();

                    b.ToTable("ResultItemGoods");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Godius.Shop.Models.Goods", b =>
                {
                    b.HasOne("Godius.Shop.Models.GoodsCategory", "Category")
                        .WithMany("Goods")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Godius.Shop.Models.ItemGoods", b =>
                {
                    b.HasOne("Godius.Shop.Models.Goods", "Goods")
                        .WithMany("ItemsGoods")
                        .HasForeignKey("GoodsId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Godius.Shop.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Godius.Shop.Models.Purchase", b =>
                {
                    b.HasOne("Godius.Shop.Models.Goods")
                        .WithMany("Purchases")
                        .HasForeignKey("GoodsId");

                    b.HasOne("Godius.Shop.Models.ApplicationUser", "Purchaser")
                        .WithMany()
                        .HasForeignKey("PurchaserId");
                });

            modelBuilder.Entity("Godius.Shop.Models.ResultItemGoods", b =>
                {
                    b.HasOne("Godius.Shop.Models.ItemGoods", "ItemGoods")
                        .WithMany("ResultItemGoods")
                        .HasForeignKey("ItemGoodsId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Godius.Shop.Models.Purchase", "Purchase")
                        .WithOne("ResultItemGoods")
                        .HasForeignKey("Godius.Shop.Models.ResultItemGoods", "PurchaseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Godius.Shop.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Godius.Shop.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Godius.Shop.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Godius.Shop.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
