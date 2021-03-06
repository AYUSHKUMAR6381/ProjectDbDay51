﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppDay51.Data;

namespace WebAppDay51.Migrations
{
    [DbContext(typeof(PlayersContext))]
    [Migration("20201207103857_myMig")]
    partial class myMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("WebAppDay51.Models.Player", b =>
                {
                    b.Property<int>("PId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("PCategory")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PTeam")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("PId");

                    b.ToTable("PPicModel");
                });
#pragma warning restore 612, 618
        }
    }
}
