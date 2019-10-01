﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MilesPerGallon.Models;

namespace MilesPerGallon.Migrations
{
    [DbContext(typeof(MilesPerGallonContext))]
    partial class MilesPerGallonContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MilesPerGallon.Models.Car", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CarModel");


                    b.Property<DateTime>("FillupDate");

                    b.Property<string>("FirstName");

                    b.Property<float>("GallonsFilled");

                    b.Property<float>("MilesDriven");

                    b.HasKey("ID");

                    b.ToTable("Car");
                });
#pragma warning restore 612, 618
        }
    }
}