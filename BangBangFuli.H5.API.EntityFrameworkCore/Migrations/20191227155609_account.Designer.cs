﻿// <auto-generated />
using System;
using BangBangFuli.H5.API.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BangBangFuli.H5.API.EntityFrameworkCore.Migrations
{
    [DbContext(typeof(CouponSystemDBContext))]
    [Migration("20191227155609_account")]
    partial class account
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BangBangFuli.H5.API.Core.Entities.Banner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BatchId");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Banners");
                });

            modelBuilder.Entity("BangBangFuli.H5.API.Core.Entities.BannerDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BannerId");

                    b.Property<string>("PhotoPath");

                    b.HasKey("Id");

                    b.HasIndex("BannerId");

                    b.ToTable("BannerDetails");
                });

            modelBuilder.Entity("BangBangFuli.H5.API.Core.Entities.BatchInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("BatchInformations");
                });

            modelBuilder.Entity("BangBangFuli.H5.API.Core.Entities.Coupon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AvaliableCount");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("TotalCount");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<DateTime>("ValidityDate");

                    b.HasKey("Id");

                    b.ToTable("Coupons");
                });

            modelBuilder.Entity("BangBangFuli.H5.API.Core.Entities.ModuleInfo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(64);

                    b.HasKey("ID");

                    b.ToTable("ModuleInfos");
                });

            modelBuilder.Entity("BangBangFuli.H5.API.Core.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Contactor")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("CouponCode")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("DeliveryNumber");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("MobilePhone")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("OrderCode")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<int>("ZipCode")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BangBangFuli.H5.API.Core.Entities.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId");

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<int>("ProductCount")
                        .HasMaxLength(10);

                    b.Property<int>("ProductId");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("BangBangFuli.H5.API.Core.Entities.ProductDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PhotoPath");

                    b.Property<int>("ProductInformationId");

                    b.HasKey("Id");

                    b.HasIndex("ProductInformationId");

                    b.ToTable("ProductDetails");
                });

            modelBuilder.Entity("BangBangFuli.H5.API.Core.Entities.ProductInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BatchId");

                    b.Property<string>("Description");

                    b.Property<string>("ProductCode");

                    b.Property<string>("ProductName")
                        .IsRequired();

                    b.Property<int>("ProductStatus");

                    b.Property<int>("StockType");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("ProductInformations");
                });

            modelBuilder.Entity("BangBangFuli.H5.API.Core.Entities.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("SupplierName");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("BangBangFuli.H5.API.Core.Entities.UserAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasMaxLength(256);

                    b.Property<int>("UserID");

                    b.Property<string>("UserName")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.ToTable("UserAccounts");
                });

            modelBuilder.Entity("BangBangFuli.H5.API.Core.Entities.UserInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Name")
                        .HasMaxLength(32);

                    b.Property<int>("RoleID");

                    b.Property<int>("State");

                    b.Property<double>("TargetAmt");

                    b.Property<string>("TelPhone")
                        .HasMaxLength(11);

                    b.Property<string>("UserName")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.ToTable("UserInfos");
                });

            modelBuilder.Entity("BangBangFuli.H5.API.Core.Entities.UserRole", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName")
                        .HasMaxLength(32);

                    b.Property<int>("State");

                    b.HasKey("ID");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("BangBangFuli.H5.API.Core.Entities.UserRoleJurisdiction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsAdd");

                    b.Property<bool>("IsAssignment");

                    b.Property<bool>("IsDelete");

                    b.Property<bool>("IsEdit");

                    b.Property<bool>("IsQuery");

                    b.Property<int>("ModuleID");

                    b.Property<int>("UserRoleID");

                    b.HasKey("Id");

                    b.ToTable("UserRoleJurisdictions");
                });

            modelBuilder.Entity("BangBangFuli.H5.API.Core.Entities.BannerDetail", b =>
                {
                    b.HasOne("BangBangFuli.H5.API.Core.Entities.Banner")
                        .WithMany("BannerDetails")
                        .HasForeignKey("BannerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BangBangFuli.H5.API.Core.Entities.OrderDetail", b =>
                {
                    b.HasOne("BangBangFuli.H5.API.Core.Entities.Order")
                        .WithMany("Details")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BangBangFuli.H5.API.Core.Entities.ProductDetail", b =>
                {
                    b.HasOne("BangBangFuli.H5.API.Core.Entities.ProductInformation")
                        .WithMany("Details")
                        .HasForeignKey("ProductInformationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
