﻿// <auto-generated />
using System;
using Dataservices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Dataservices.Migrations
{
    [DbContext(typeof(Bakers_DBcontext))]
    [Migration("20210115180317_SecondaryMigration")]
    partial class SecondaryMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Dataservices.Models.Admins", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("admins");
                });

            modelBuilder.Entity("Dataservices.Models.Orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Customer")
                        .HasColumnType("text");

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<int>("delicacyid")
                        .HasColumnType("integer");

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.Property<int>("quantity")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("Dataservices.Models.delicacy_Schedules", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Delicacy_id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Delicacy_Schedules");
                });

            modelBuilder.Entity("Dataservices.Models.delicacys", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<bool>("Spl")
                        .HasColumnType("boolean");

                    b.Property<int?>("delicacy_SchedulesId")
                        .HasColumnType("integer");

                    b.Property<float>("nutri_engy")
                        .HasColumnType("real");

                    b.Property<bool>("veg")
                        .HasColumnType("boolean");

                    b.Property<float>("weight")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("delicacy_SchedulesId");

                    b.ToTable("Delicacys");
                });

            modelBuilder.Entity("Dataservices.Models.delicacys", b =>
                {
                    b.HasOne("Dataservices.Models.delicacy_Schedules", null)
                        .WithMany("Delicacies")
                        .HasForeignKey("delicacy_SchedulesId");
                });

            modelBuilder.Entity("Dataservices.Models.delicacy_Schedules", b =>
                {
                    b.Navigation("Delicacies");
                });
#pragma warning restore 612, 618
        }
    }
}
