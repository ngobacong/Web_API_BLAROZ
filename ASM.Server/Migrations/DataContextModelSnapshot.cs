﻿// <auto-generated />
using System;
using ASM.Share.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASM.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASM.Share.Models.Donhang", b =>
                {
                    b.Property<int>("DonhangID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ghichu")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("KhachhangID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Ngaydat")
                        .HasColumnType("datetime2");

                    b.Property<double>("Tongtien")
                        .HasColumnType("float");

                    b.Property<int>("TrangthaiDonhang")
                        .HasColumnType("int");

                    b.HasKey("DonhangID");

                    b.HasIndex("KhachhangID");

                    b.ToTable("Donhangs");
                });

            modelBuilder.Entity("ASM.Share.Models.DonhangChitiet", b =>
                {
                    b.Property<int>("ChitietID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DonhangID")
                        .HasColumnType("int");

                    b.Property<string>("Ghichu")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("MonAnID")
                        .HasColumnType("int");

                    b.Property<int>("Soluong")
                        .HasColumnType("int");

                    b.Property<double>("Thanhtien")
                        .HasColumnType("float");

                    b.HasKey("ChitietID");

                    b.HasIndex("DonhangID");

                    b.HasIndex("MonAnID");

                    b.ToTable("DonhangChitiets");
                });

            modelBuilder.Entity("ASM.Share.Models.Khachhang", b =>
                {
                    b.Property<int>("KhachhangID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConfirmPassword")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Mota")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("Ngaysinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.HasKey("KhachhangID");

                    b.ToTable("Khachhangs");
                });

            modelBuilder.Entity("ASM.Share.Models.MonAn", b =>
                {
                    b.Property<int>("MonAnID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Gia")
                        .HasColumnType("float");

                    b.Property<string>("Hinh")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Mota")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("Phanloai")
                        .HasColumnType("int");

                    b.Property<bool>("Trangthai")
                        .HasColumnType("bit");

                    b.HasKey("MonAnID");

                    b.ToTable("MonAns");
                });

            modelBuilder.Entity("ASM.Share.Models.Nguoidung", b =>
                {
                    b.Property<int>("NguoidungID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Admin")
                        .HasColumnType("bit");

                    b.Property<string>("ConfirmPassword")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Locked")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("NguoidungID");

                    b.ToTable("Nguoidungs");
                });

            modelBuilder.Entity("ASM.Share.Models.Donhang", b =>
                {
                    b.HasOne("ASM.Share.Models.Khachhang", "Khachhang")
                        .WithMany()
                        .HasForeignKey("KhachhangID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Khachhang");
                });

            modelBuilder.Entity("ASM.Share.Models.DonhangChitiet", b =>
                {
                    b.HasOne("ASM.Share.Models.Donhang", "Donhang")
                        .WithMany("DonhangChitiets")
                        .HasForeignKey("DonhangID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASM.Share.Models.MonAn", "MonAn")
                        .WithMany()
                        .HasForeignKey("MonAnID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Donhang");

                    b.Navigation("MonAn");
                });

            modelBuilder.Entity("ASM.Share.Models.Donhang", b =>
                {
                    b.Navigation("DonhangChitiets");
                });
#pragma warning restore 612, 618
        }
    }
}
