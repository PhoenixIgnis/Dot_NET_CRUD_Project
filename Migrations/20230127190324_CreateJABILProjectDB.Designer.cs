﻿// <auto-generated />
using Dot_NET_CRUD_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JABILProject.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230127190324_CreateJABILProjectDB")]
    partial class CreateJABILProjectDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JABIL_Project.Models.Buildings", b =>
                {
                    b.Property<int>("PKBuilding")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PKBuilding"));

                    b.Property<string>("Building")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PKBuilding");

                    b.ToTable("Buildings");
                });

            modelBuilder.Entity("JABIL_Project.Models.Customers", b =>
                {
                    b.Property<int>("PKCustomers")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PKCustomers"));

                    b.Property<string>("Customer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FKBuilding")
                        .HasColumnType("int");

                    b.Property<string>("Prefix")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("PKCustomers");

                    b.HasIndex("FKBuilding");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("JABIL_Project.Models.PartNumbers", b =>
                {
                    b.Property<int>("PKPartNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PKPartNumber"));

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<int>("FKCustomer")
                        .HasColumnType("int");

                    b.Property<string>("PartNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PKPartNumber");

                    b.HasIndex("FKCustomer");

                    b.ToTable("PartNumbers");
                });

            modelBuilder.Entity("JABIL_Project.Models.Customers", b =>
                {
                    b.HasOne("JABIL_Project.Models.Buildings", "Building")
                        .WithMany("Customers")
                        .HasForeignKey("FKBuilding")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Building");
                });

            modelBuilder.Entity("JABIL_Project.Models.PartNumbers", b =>
                {
                    b.HasOne("JABIL_Project.Models.Customers", "Customer")
                        .WithMany("PartNumbers")
                        .HasForeignKey("FKCustomer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("JABIL_Project.Models.Buildings", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("JABIL_Project.Models.Customers", b =>
                {
                    b.Navigation("PartNumbers");
                });
#pragma warning restore 612, 618
        }
    }
}
