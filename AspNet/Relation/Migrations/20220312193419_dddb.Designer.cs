﻿// <auto-generated />
using KS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Relation.Migrations
{
    [DbContext(typeof(PortoDbContext))]
    [Migration("20220312193419_dddb")]
    partial class dddb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Relation.Models.Address", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("StudentID")
                        .IsUnique();

                    b.ToTable("ADDRESS");
                });

            modelBuilder.Entity("Relation.Models.Author", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AuthorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("AUTHOR");
                });

            modelBuilder.Entity("Relation.Models.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AuthorID")
                        .HasColumnType("int");

                    b.Property<string>("BookName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Page")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AuthorID");

                    b.ToTable("BOOK");
                });

            modelBuilder.Entity("Relation.Models.Hobby", b =>
                {
                    b.Property<int>("HobbyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("HobbyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HobbyID");

                    b.ToTable("HOBBY");
                });

            modelBuilder.Entity("Relation.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Fullname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("STUDENT");
                });

            modelBuilder.Entity("Relation.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("TeacherName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherID");

                    b.ToTable("TEACHER");
                });

            modelBuilder.Entity("Relation.Models.TeacherToHobby", b =>
                {
                    b.Property<int>("TeacherID")
                        .HasColumnType("int");

                    b.Property<int>("HobbyID")
                        .HasColumnType("int");

                    b.HasKey("TeacherID", "HobbyID");

                    b.HasIndex("HobbyID");

                    b.ToTable("TEACHERTOHOBBY");
                });

            modelBuilder.Entity("Relation.Models.Address", b =>
                {
                    b.HasOne("Relation.Models.Student", "Students")
                        .WithOne("Addresses")
                        .HasForeignKey("Relation.Models.Address", "StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Students");
                });

            modelBuilder.Entity("Relation.Models.Book", b =>
                {
                    b.HasOne("Relation.Models.Author", "Authors")
                        .WithMany("Books")
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Authors");
                });

            modelBuilder.Entity("Relation.Models.TeacherToHobby", b =>
                {
                    b.HasOne("Relation.Models.Hobby", "HobbyTable")
                        .WithMany("collectionTable")
                        .HasForeignKey("HobbyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Relation.Models.Teacher", "TeacherTable")
                        .WithMany("collectionTable")
                        .HasForeignKey("TeacherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HobbyTable");

                    b.Navigation("TeacherTable");
                });

            modelBuilder.Entity("Relation.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Relation.Models.Hobby", b =>
                {
                    b.Navigation("collectionTable");
                });

            modelBuilder.Entity("Relation.Models.Student", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("Relation.Models.Teacher", b =>
                {
                    b.Navigation("collectionTable");
                });
#pragma warning restore 612, 618
        }
    }
}
