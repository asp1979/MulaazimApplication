﻿// <auto-generated />
using MaidFinderWebAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MaidFinderWebAPI.Migrations
{
    [DbContext(typeof(MaidFinderDbContext))]
    [Migration("20220826073558_initial create2")]
    partial class initialcreate2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MaidFinderWebAPI.City", b =>
                {
                    b.Property<string>("CityID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CityID");

                    b.ToTable("City");
                });

            modelBuilder.Entity("MaidFinderWebAPI.Model.Candidate", b =>
                {
                    b.Property<string>("CandidateID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Area")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CNIC")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CellNumber")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CityID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CandidateID");

                    b.HasIndex("CityID");

                    b.ToTable("Candidate");
                });

            modelBuilder.Entity("MaidFinderWebAPI.Model.Candidate", b =>
                {
                    b.HasOne("MaidFinderWebAPI.City", "City")
                        .WithMany()
                        .HasForeignKey("CityID");

                    b.Navigation("City");
                });
#pragma warning restore 612, 618
        }
    }
}