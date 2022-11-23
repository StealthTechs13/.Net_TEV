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
    [Migration("20201024092412_addDeviceInEmergencyCallHistory")]
    partial class addDeviceInEmergencyCallHistory
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

            modelBuilder.Entity("Tev.DAL.Entities.EmergencyCallHistory", b =>
                {
                    b.Property<string>("EmergencyCallHistoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CallingPurpose")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CreatedDate")
                        .HasColumnType("bigint");

                    b.Property<string>("DeviceId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ModifiedDate")
                        .HasColumnType("bigint");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("EmergencyCallHistoryId");

                    b.HasIndex("DeviceId");

                    b.ToTable("EmergencyCallHistories");
                });

            modelBuilder.Entity("Tev.DAL.Entities.EscalationMatrix", b =>
                {
                    b.Property<string>("EscalationMatrixId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("AttentionTime")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CreatedDate")
                        .HasColumnType("bigint");

                    b.Property<string>("DeviceId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("EscalationLevel")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ModifiedDate")
                        .HasColumnType("bigint");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<string>("ReceiverDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiverName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiverPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SenderPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SmokeStatus")
                        .HasColumnType("int");

                    b.Property<int>("SmokeValue")
                        .HasColumnType("int");

                    b.HasKey("EscalationMatrixId");

                    b.HasIndex("DeviceId");

                    b.ToTable("EscalationMatrices");
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

            modelBuilder.Entity("Tev.DAL.Entities.EmergencyCallHistory", b =>
                {
                    b.HasOne("Tev.DAL.Entities.Device", "Device")
                        .WithMany("EmergencyCallHistories")
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Tev.DAL.Entities.EscalationMatrix", b =>
                {
                    b.HasOne("Tev.DAL.Entities.Device", "Device")
                        .WithMany("EscalationMatrices")
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
