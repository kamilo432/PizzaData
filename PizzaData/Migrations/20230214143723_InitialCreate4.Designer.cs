﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaData.Data;

#nullable disable

namespace PizzaData.Migrations
{
    [DbContext(typeof(PizzaDataContext))]
    [Migration("20230214143723_InitialCreate4")]
    partial class InitialCreate4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PizzaData.Models.Flour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Elasticity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlourDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlourName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlourType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PizzaId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Protein")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Strength")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PizzaId");

                    b.ToTable("Flours");
                });

            modelBuilder.Entity("PizzaData.Models.Pizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("AmbientFermentationTime")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("FlourAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("FridgeFermentationTime")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("OliveOilAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SaltAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("WaterAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("YeastAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Pizza");
                });

            modelBuilder.Entity("PizzaData.Models.Flour", b =>
                {
                    b.HasOne("PizzaData.Models.Pizza", null)
                        .WithMany("Flours")
                        .HasForeignKey("PizzaId");
                });

            modelBuilder.Entity("PizzaData.Models.Pizza", b =>
                {
                    b.Navigation("Flours");
                });
#pragma warning restore 612, 618
        }
    }
}