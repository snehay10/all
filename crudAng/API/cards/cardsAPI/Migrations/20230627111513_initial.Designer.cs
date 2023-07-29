﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cardsAPI.model;

#nullable disable

namespace cardsAPI.Migrations
{
    [DbContext(typeof(StudDbContext))]
    [Migration("20230627111513_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("cardsAPI.model.stud", b =>
                {
                    b.Property<Guid>("StudID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("StudC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudID");

                    b.ToTable("stud");
                });
#pragma warning restore 612, 618
        }
    }
}
