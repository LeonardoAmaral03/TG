﻿// <auto-generated />
using System;
using ComputerMaintenance.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ComputerMaintenance.Migrations
{
    [DbContext(typeof(ComputerMaintenanceContext))]
    partial class ComputerMaintenanceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ComputerMaintenance.Models.Computer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Computer");
                });

            modelBuilder.Entity("ComputerMaintenance.Models.ComputerItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AcquisitionDate");

                    b.Property<string>("Brand");

                    b.Property<int?>("ComputerId");

                    b.Property<string>("Description");

                    b.Property<string>("Model");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("ComputerId");

                    b.ToTable("ComputerItem");
                });

            modelBuilder.Entity("ComputerMaintenance.Models.Maintenance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Activity");

                    b.Property<int?>("ItemId");

                    b.Property<string>("Name");

                    b.Property<int>("Period");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("Maintenance");
                });

            modelBuilder.Entity("ComputerMaintenance.Models.ComputerItem", b =>
                {
                    b.HasOne("ComputerMaintenance.Models.Computer", "Computer")
                        .WithMany("Items")
                        .HasForeignKey("ComputerId");
                });

            modelBuilder.Entity("ComputerMaintenance.Models.Maintenance", b =>
                {
                    b.HasOne("ComputerMaintenance.Models.ComputerItem", "Item")
                        .WithMany("Maintenances")
                        .HasForeignKey("ItemId");
                });
#pragma warning restore 612, 618
        }
    }
}
