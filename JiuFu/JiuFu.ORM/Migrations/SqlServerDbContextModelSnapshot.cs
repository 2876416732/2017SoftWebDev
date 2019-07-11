﻿// <auto-generated />
using System;
using JiuFu.ORM.SqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JiuFu.ORM.Migrations
{
    [DbContext(typeof(SqlServerDbContext))]
    partial class SqlServerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JiuFu.Entities.Commodity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Detail");

                    b.Property<string>("Name");

                    b.Property<string>("Price");

                    b.Property<int>("SaleState");

                    b.Property<string>("picture");

                    b.HasKey("Id");

                    b.ToTable("Commoditys");
                });

            modelBuilder.Entity("JiuFu.Entities.CommodityOrder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CommoditysId");

                    b.Property<string>("Name");

                    b.Property<string>("Number");

                    b.Property<bool>("OrderStatus");

                    b.Property<string>("Remarks");

                    b.Property<int>("SaleStates");

                    b.HasKey("Id");

                    b.HasIndex("CommoditysId");

                    b.ToTable("CommodityOrders");
                });

            modelBuilder.Entity("JiuFu.Entities.Degree", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("FlavorsId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("FlavorsId");

                    b.ToTable("Degrees");
                });

            modelBuilder.Entity("JiuFu.Entities.Entertainment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Date");

                    b.Property<string>("Detail");

                    b.Property<string>("Name");

                    b.Property<string>("Position");

                    b.Property<string>("picture");

                    b.HasKey("Id");

                    b.ToTable("Entertainments");
                });

            modelBuilder.Entity("JiuFu.Entities.Flavor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Flavors");
                });

            modelBuilder.Entity("JiuFu.Entities.Food", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Detail");

                    b.Property<Guid>("FoodClassId");

                    b.Property<string>("Name");

                    b.Property<string>("Price");

                    b.Property<int>("SaleState");

                    b.Property<Guid>("flavorId");

                    b.Property<string>("picture");

                    b.HasKey("Id");

                    b.HasIndex("FoodClassId");

                    b.HasIndex("flavorId");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("JiuFu.Entities.FoodClass", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("FoodClass");
                });

            modelBuilder.Entity("JiuFu.Entities.FoodOrder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FlarNames");

                    b.Property<Guid>("FoodId");

                    b.Property<int>("FoodState");

                    b.Property<string>("Number");

                    b.Property<bool>("OrderStatus");

                    b.Property<string>("Remarks");

                    b.Property<string>("Room");

                    b.HasKey("Id");

                    b.HasIndex("FoodId");

                    b.ToTable("FoodOrders");
                });

            modelBuilder.Entity("JiuFu.Entities.Goods", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Detail");

                    b.Property<string>("Name");

                    b.Property<string>("Price");

                    b.Property<string>("picture");

                    b.HasKey("Id");

                    b.ToTable("Goodss");
                });

            modelBuilder.Entity("JiuFu.Entities.GoodsOrder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("GoodsId");

                    b.Property<string>("Name");

                    b.Property<string>("Number");

                    b.Property<bool>("OrderStatus");

                    b.Property<string>("Remarks");

                    b.Property<string>("Room");

                    b.Property<int>("State");

                    b.HasKey("Id");

                    b.HasIndex("GoodsId");

                    b.ToTable("GoodsOrders");
                });

            modelBuilder.Entity("JiuFu.Entities.Laundry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Mode");

                    b.Property<string>("Price");

                    b.HasKey("Id");

                    b.ToTable("Laundrys");
                });

            modelBuilder.Entity("JiuFu.Entities.LaundryOrder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<Guid?>("LaundryId");

                    b.Property<string>("Piece");

                    b.Property<string>("Price");

                    b.Property<string>("Remarks");

                    b.Property<string>("Room");

                    b.Property<int>("State");

                    b.HasKey("Id");

                    b.HasIndex("LaundryId");

                    b.ToTable("LaundryOrders");
                });

            modelBuilder.Entity("JiuFu.Entities.Renewal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Comategory");

                    b.Property<string>("Date");

                    b.Property<int>("state");

                    b.HasKey("Id");

                    b.ToTable("Renewals");
                });

            modelBuilder.Entity("JiuFu.Entities.Scenic", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Date");

                    b.Property<string>("Detail");

                    b.Property<string>("Name");

                    b.Property<string>("Position");

                    b.Property<string>("picture");

                    b.HasKey("Id");

                    b.ToTable("Scenics");
                });

            modelBuilder.Entity("JiuFu.UserAndRole.ApplicationRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ApplicationRoleType");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Description")
                        .HasMaxLength(550);

                    b.Property<string>("DisplayName")
                        .HasMaxLength(250);

                    b.Property<bool>("IsDefaultRole");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.Property<string>("SortCode")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("JiuFu.UserAndRole.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("AvatarPath");

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("MobileNumber")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("Sex")
                        .HasMaxLength(100);

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<string>("floor");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<Guid>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("JiuFu.Entities.CommodityOrder", b =>
                {
                    b.HasOne("JiuFu.Entities.Commodity", "Commoditys")
                        .WithMany("CommodityOrder")
                        .HasForeignKey("CommoditysId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("JiuFu.Entities.Degree", b =>
                {
                    b.HasOne("JiuFu.Entities.Flavor", "Flavors")
                        .WithMany("Degrees")
                        .HasForeignKey("FlavorsId");
                });

            modelBuilder.Entity("JiuFu.Entities.Food", b =>
                {
                    b.HasOne("JiuFu.Entities.FoodClass", "FoodClass")
                        .WithMany("Foods")
                        .HasForeignKey("FoodClassId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("JiuFu.Entities.Flavor", "Flavor")
                        .WithMany("Foods")
                        .HasForeignKey("flavorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("JiuFu.Entities.FoodOrder", b =>
                {
                    b.HasOne("JiuFu.Entities.Food", "Food")
                        .WithMany("Foods")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("JiuFu.Entities.GoodsOrder", b =>
                {
                    b.HasOne("JiuFu.Entities.Goods", "Goods")
                        .WithMany("GoodsOrders")
                        .HasForeignKey("GoodsId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("JiuFu.Entities.LaundryOrder", b =>
                {
                    b.HasOne("JiuFu.Entities.Laundry", "Laundry")
                        .WithMany("LaundriesOrder")
                        .HasForeignKey("LaundryId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("JiuFu.UserAndRole.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("JiuFu.UserAndRole.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("JiuFu.UserAndRole.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("JiuFu.UserAndRole.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("JiuFu.UserAndRole.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("JiuFu.UserAndRole.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
