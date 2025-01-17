﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using projectclass.Models;

#nullable disable

namespace projectclass.Migrations
{
    [DbContext(typeof(mydb))]
    partial class mydbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("projectclass.Models.register", b =>
                {
                    b.Property<int>("r_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("r_id"));

                    b.Property<string>("r_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("r_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("r_pass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("r_id");

                    b.ToTable("registers");
                });
#pragma warning restore 612, 618
        }
    }
}
