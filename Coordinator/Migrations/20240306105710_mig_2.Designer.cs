﻿// <auto-generated />
using System;
using Coordinator.Models.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Coordinator.Migrations
{
    [DbContext(typeof(TwoPhaseCommitContext))]
    [Migration("20240306105710_mig_2")]
    partial class mig_2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Coordinator.Models.Node", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Nodes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c75cfe57-e0ec-4605-8aa7-b773318d7bc9"),
                            Name = "Order.API"
                        },
                        new
                        {
                            Id = new Guid("5fe71db8-0c38-4bb9-b059-7c4d54ae923d"),
                            Name = "Stock.API"
                        },
                        new
                        {
                            Id = new Guid("9ab31ef7-0779-4727-bd3e-9840ba7db9e3"),
                            Name = "Payment.API"
                        });
                });

            modelBuilder.Entity("Coordinator.Models.NodeState", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("IsReady")
                        .HasColumnType("int");

                    b.Property<Guid>("NodeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TransactionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TransactionState")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NodeId");

                    b.ToTable("NodeStates");
                });

            modelBuilder.Entity("Coordinator.Models.NodeState", b =>
                {
                    b.HasOne("Coordinator.Models.Node", "Node")
                        .WithMany("NodeSatates")
                        .HasForeignKey("NodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Node");
                });

            modelBuilder.Entity("Coordinator.Models.Node", b =>
                {
                    b.Navigation("NodeSatates");
                });
#pragma warning restore 612, 618
        }
    }
}
