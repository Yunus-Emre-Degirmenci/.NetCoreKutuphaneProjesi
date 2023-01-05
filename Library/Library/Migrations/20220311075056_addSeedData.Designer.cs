﻿// <auto-generated />
using System;
using Library.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Library.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20220311075056_addSeedData")]
    partial class addSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Library.Models.StudentDetail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchollNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Tbl_StudentID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Tbl_StudentID")
                        .IsUnique();

                    b.ToTable("StudentDetail");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            BirthDay = new DateTime(1996, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2022, 3, 11, 10, 50, 55, 806, DateTimeKind.Local).AddTicks(4157),
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchollNumber = "100",
                            Status = 1,
                            Tbl_StudentID = 1
                        },
                        new
                        {
                            ID = 2,
                            BirthDay = new DateTime(1999, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2022, 3, 11, 10, 50, 55, 806, DateTimeKind.Local).AddTicks(5202),
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchollNumber = "101",
                            Status = 1,
                            Tbl_StudentID = 2
                        },
                        new
                        {
                            ID = 3,
                            BirthDay = new DateTime(1995, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2022, 3, 11, 10, 50, 55, 806, DateTimeKind.Local).AddTicks(5210),
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchollNumber = "102",
                            Status = 1,
                            Tbl_StudentID = 3
                        },
                        new
                        {
                            ID = 4,
                            BirthDay = new DateTime(1994, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2022, 3, 11, 10, 50, 55, 806, DateTimeKind.Local).AddTicks(5223),
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchollNumber = "103",
                            Status = 1,
                            Tbl_StudentID = 4
                        });
                });

            modelBuilder.Entity("Library.Models.Tbl_Author", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Isim");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Soyisim");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Yazarlar");
                });

            modelBuilder.Entity("Library.Models.Tbl_Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PageCount")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Tbl_AuthorID")
                        .HasColumnType("int");

                    b.Property<int>("Tbl_BookTypeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Tbl_AuthorID");

                    b.HasIndex("Tbl_BookTypeID");

                    b.ToTable("Tbl_Books");
                });

            modelBuilder.Entity("Library.Models.Tbl_BookType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Tbl_BookTypes");
                });

            modelBuilder.Entity("Library.Models.Tbl_Operation", b =>
                {
                    b.Property<int>("Tbl_StudentID")
                        .HasColumnType("int");

                    b.Property<int>("Tbl_BookID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Tbl_StudentID", "Tbl_BookID");

                    b.HasIndex("Tbl_BookID");

                    b.ToTable("Operasyon");
                });

            modelBuilder.Entity("Library.Models.Tbl_Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Tbl_Students");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedDate = new DateTime(2022, 3, 11, 10, 50, 55, 806, DateTimeKind.Local).AddTicks(2452),
                            FirstName = "Yunus",
                            Gender = 1,
                            LastName = "Değirmenci",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1
                        },
                        new
                        {
                            ID = 2,
                            CreatedDate = new DateTime(2022, 3, 11, 10, 50, 55, 806, DateTimeKind.Local).AddTicks(3514),
                            FirstName = "Serhat",
                            Gender = 1,
                            LastName = "Ünver",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1
                        },
                        new
                        {
                            ID = 3,
                            CreatedDate = new DateTime(2022, 3, 11, 10, 50, 55, 806, DateTimeKind.Local).AddTicks(3521),
                            FirstName = "Gözde",
                            Gender = 2,
                            LastName = "Sağlam",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1
                        },
                        new
                        {
                            ID = 4,
                            CreatedDate = new DateTime(2022, 3, 11, 10, 50, 55, 806, DateTimeKind.Local).AddTicks(3522),
                            FirstName = "Özlem",
                            Gender = 2,
                            LastName = "Yılmaz",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1
                        });
                });

            modelBuilder.Entity("Library.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedDate = new DateTime(2022, 3, 11, 10, 50, 55, 803, DateTimeKind.Local).AddTicks(6710),
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Password = "$2a$11$jyrI60Z.HgbUtxW7/FHGYuLWUslnZRKF4AnpZek6j27EjHbjcEi9u",
                            Role = 1,
                            Status = 1,
                            UserName = "administrator"
                        },
                        new
                        {
                            ID = 2,
                            CreatedDate = new DateTime(2022, 3, 11, 10, 50, 55, 804, DateTimeKind.Local).AddTicks(9216),
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Password = "$2a$11$QMuCP13XCnJyAy8nIlL31.qYKkmStHrUoVYMz2.VuRol2Z0dPkcpi",
                            Role = 2,
                            Status = 1,
                            UserName = "yunus"
                        });
                });

            modelBuilder.Entity("Library.Models.StudentDetail", b =>
                {
                    b.HasOne("Library.Models.Tbl_Student", "Tbl_Student")
                        .WithOne("StudentDetail")
                        .HasForeignKey("Library.Models.StudentDetail", "Tbl_StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tbl_Student");
                });

            modelBuilder.Entity("Library.Models.Tbl_Book", b =>
                {
                    b.HasOne("Library.Models.Tbl_Author", "Tbl_Author")
                        .WithMany("Tbl_Books")
                        .HasForeignKey("Tbl_AuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Models.Tbl_BookType", "Tbl_BookType")
                        .WithMany("Tbl_Books")
                        .HasForeignKey("Tbl_BookTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tbl_Author");

                    b.Navigation("Tbl_BookType");
                });

            modelBuilder.Entity("Library.Models.Tbl_Operation", b =>
                {
                    b.HasOne("Library.Models.Tbl_Book", "Tbl_Book")
                        .WithMany("Tbl_Operations")
                        .HasForeignKey("Tbl_BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Models.Tbl_Student", "Tbl_Student")
                        .WithMany("Tbl_Operations")
                        .HasForeignKey("Tbl_StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tbl_Book");

                    b.Navigation("Tbl_Student");
                });

            modelBuilder.Entity("Library.Models.Tbl_Author", b =>
                {
                    b.Navigation("Tbl_Books");
                });

            modelBuilder.Entity("Library.Models.Tbl_Book", b =>
                {
                    b.Navigation("Tbl_Operations");
                });

            modelBuilder.Entity("Library.Models.Tbl_BookType", b =>
                {
                    b.Navigation("Tbl_Books");
                });

            modelBuilder.Entity("Library.Models.Tbl_Student", b =>
                {
                    b.Navigation("StudentDetail");

                    b.Navigation("Tbl_Operations");
                });
#pragma warning restore 612, 618
        }
    }
}
