﻿// <auto-generated />
using System;
using CourierBid.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CourierBid.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220108184650_TableImplem")]
    partial class TableImplem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("CourierBid.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("Role")
                        .HasColumnType("text");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ApplicationUser");
                });

            modelBuilder.Entity("CourierBid.Models.Cargo", b =>
                {
                    b.Property<int>("CargoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Volume")
                        .HasColumnType("text");

                    b.Property<string>("Weight")
                        .HasColumnType("text");

                    b.HasKey("CargoId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Cargo");
                });

            modelBuilder.Entity("CourierBid.Models.CargoTypes", b =>
                {
                    b.Property<int>("CargoTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("CargoTypeId");

                    b.ToTable("CargoTypes");
                });

            modelBuilder.Entity("CourierBid.Models.Contracts", b =>
                {
                    b.Property<int>("ContractId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ExpeditionId")
                        .HasColumnType("integer");

                    b.Property<int>("TransportId")
                        .HasColumnType("integer");

                    b.HasKey("ContractId");

                    b.HasIndex("ExpeditionId");

                    b.HasIndex("TransportId");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("CourierBid.Models.Expeditions", b =>
                {
                    b.Property<int>("ExpeditionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<float>("Budget")
                        .HasColumnType("real");

                    b.Property<int>("CargoId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DeliveryLimit")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("DeliveryLocation")
                        .HasColumnType("text");

                    b.Property<DateTime>("DeliveryTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("PickupLimit")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("PickupLocation")
                        .HasColumnType("text");

                    b.Property<DateTime>("PickupTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("ExpeditionId");

                    b.HasIndex("CargoId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Expeditions");
                });

            modelBuilder.Entity("CourierBid.Models.Transports", b =>
                {
                    b.Property<int>("TransportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("EndLocation")
                        .HasColumnType("text");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("StartLocation")
                        .HasColumnType("text");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("TruckId")
                        .HasColumnType("integer");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.HasKey("TransportId");

                    b.HasIndex("TruckId");

                    b.ToTable("Transports");
                });

            modelBuilder.Entity("CourierBid.Models.TruckModels", b =>
                {
                    b.Property<int>("ModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("text");

                    b.Property<string>("Dimensions")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<float>("Speed")
                        .HasColumnType("real");

                    b.Property<float>("Volume")
                        .HasColumnType("real");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("ModelId");

                    b.ToTable("TruckModels");
                });

            modelBuilder.Entity("CourierBid.Models.Trucks", b =>
                {
                    b.Property<int>("TruckId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CourierId")
                        .HasColumnType("text");

                    b.Property<float>("EmptyPrice")
                        .HasColumnType("real");

                    b.Property<float>("FullPrice")
                        .HasColumnType("real");

                    b.Property<int>("ModelId")
                        .HasColumnType("integer");

                    b.Property<string>("RegistryPlate")
                        .HasColumnType("text");

                    b.HasKey("TruckId");

                    b.HasIndex("CourierId")
                        .IsUnique();

                    b.HasIndex("ModelId");

                    b.ToTable("Trucks");
                });

            modelBuilder.Entity("CourierBid.Models.Cargo", b =>
                {
                    b.HasOne("CourierBid.Models.CargoTypes", "CargoTypes")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CargoTypes");
                });

            modelBuilder.Entity("CourierBid.Models.Contracts", b =>
                {
                    b.HasOne("CourierBid.Models.Expeditions", "Expeditions")
                        .WithMany()
                        .HasForeignKey("ExpeditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourierBid.Models.Transports", "Transports")
                        .WithMany()
                        .HasForeignKey("TransportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Expeditions");

                    b.Navigation("Transports");
                });

            modelBuilder.Entity("CourierBid.Models.Expeditions", b =>
                {
                    b.HasOne("CourierBid.Models.Cargo", "Cargo")
                        .WithMany()
                        .HasForeignKey("CargoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourierBid.Data.ApplicationUser", "ApplicationUser")
                        .WithOne("Expeditions")
                        .HasForeignKey("CourierBid.Models.Expeditions", "UserId");

                    b.Navigation("ApplicationUser");

                    b.Navigation("Cargo");
                });

            modelBuilder.Entity("CourierBid.Models.Transports", b =>
                {
                    b.HasOne("CourierBid.Models.Trucks", "Trucks")
                        .WithMany()
                        .HasForeignKey("TruckId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trucks");
                });

            modelBuilder.Entity("CourierBid.Models.Trucks", b =>
                {
                    b.HasOne("CourierBid.Data.ApplicationUser", "ApplicationUser")
                        .WithOne("Transports")
                        .HasForeignKey("CourierBid.Models.Trucks", "CourierId");

                    b.HasOne("CourierBid.Models.TruckModels", "TruckModels")
                        .WithMany()
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("TruckModels");
                });

            modelBuilder.Entity("CourierBid.Data.ApplicationUser", b =>
                {
                    b.Navigation("Expeditions");

                    b.Navigation("Transports");
                });
#pragma warning restore 612, 618
        }
    }
}