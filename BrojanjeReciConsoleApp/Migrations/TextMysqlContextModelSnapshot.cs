﻿// <auto-generated />
using BrojanjeReciConsoleApp.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BrojanjeReciConsoleApp.Migrations
{
    [DbContext(typeof(TextMysqlContext))]
    partial class TextMysqlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BrojanjeReciConsoleApp.Repository.Text", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("TextInput")
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("Text");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TextInput = "Lorem Ipsum is simply dummy text of the printing and typesetting industry."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
