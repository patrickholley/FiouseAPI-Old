﻿// <auto-generated />
using System;
using FiouseAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FiouseAPI.Migrations
{
    [DbContext(typeof(FiouseContext))]
    [Migration("20180619174237_AutoIncrementAll")]
    partial class AutoIncrementAll
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799");

            modelBuilder.Entity("FiouseAPI.Models.Budget", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Balance");

                    b.Property<byte>("LengthTypeId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("LengthTypeId");

                    b.ToTable("Budgets");
                });

            modelBuilder.Entity("FiouseAPI.Models.Expense", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("FiouseAPI.Models.LengthType", b =>
                {
                    b.Property<byte>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("LengthTypes");
                });

            modelBuilder.Entity("FiouseAPI.Models.Budget", b =>
                {
                    b.HasOne("FiouseAPI.Models.LengthType", "LengthType")
                        .WithMany()
                        .HasForeignKey("LengthTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
