﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tev.DAL;

namespace Tev.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201021135907_AddTechnicianDevicesMappingTable")]
    partial class AddTechnicianDevicesMappingTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Tev.DAL.Entities.Device", b =>
                {
                    b.Property<string>("PhysicalDeviceId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CreatedDate")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LogicalDeviceId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ModifiedDate")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrgId")
                        .HasColumnType("int");

                    b.HasKey("PhysicalDeviceId");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("Tev.DAL.Entities.Technician", b =>
                {
                    b.Property<string>("TechnicianId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CreatedDate")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ModifiedDate")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TechnicianId");

                    b.ToTable("Technicians");
                });

            modelBuilder.Entity("Tev.DAL.Entities.TechnicianDevices", b =>
                {
                    b.Property<string>("TechnicianDeviceId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CreatedDate")
                        .HasColumnType("bigint");

                    b.Property<int>("DeviceType")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ModifiedDate")
                        .HasColumnType("bigint");

                    b.Property<string>("TechnicianId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TechnicianDeviceId");

                    b.HasIndex("TechnicianId");

                    b.ToTable("TechnicianDevices");
                });

            modelBuilder.Entity("Tev.DAL.Entities.TechnicianDevices", b =>
                {
                    b.HasOne("Tev.DAL.Entities.Technician", "Technician")
                        .WithMany("TechnicianDevices")
                        .HasForeignKey("TechnicianId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
