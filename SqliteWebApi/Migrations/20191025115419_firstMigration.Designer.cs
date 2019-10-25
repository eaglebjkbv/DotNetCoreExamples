﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SqliteWebApi.Data;

namespace SqliteWebApi.Migrations
{
    [DbContext(typeof(WebSiteDbContext))]
    [Migration("20191025115419_firstMigration")]
    partial class firstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("SqliteWebApi.Models.WebSite", b =>
                {
                    b.Property<int>("WebSiteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("WebSiteId");

                    b.ToTable("WebSites");
                });
#pragma warning restore 612, 618
        }
    }
}