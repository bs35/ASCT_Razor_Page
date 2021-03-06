﻿// <auto-generated />
using ASCT_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASCT_API.Migrations
{
    [DbContext(typeof(AircraftDBContext))]
    partial class AircraftDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASCT_API.Models.Aircraft", b =>
                {
                    b.Property<string>("Tail_Number")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("EC_Number")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Fleet_Type")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LRU_Name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LRU_Part_Number")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PRE_POST_Notes")
                        .HasColumnType("text");

                    b.Property<string>("Software_Name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Software_Part_Number")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Tail_Number");

                    b.ToTable("Aircrafts");
                });
#pragma warning restore 612, 618
        }
    }
}
