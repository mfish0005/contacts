﻿// <auto-generated />
using ContactsApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ContactsApi.Migrations
{
    [DbContext(typeof(ContactsApiContext))]
    [Migration("20200727175638_Second")]
    partial class Second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ContactsApi.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "bob@bob.com",
                            Name = "Bob Johnson"
                        },
                        new
                        {
                            Id = 2,
                            Email = "bob@bob.com",
                            Name = "Lucy Liu"
                        },
                        new
                        {
                            Id = 3,
                            Email = "bob@bob.com",
                            Name = "Robert Redford"
                        },
                        new
                        {
                            Id = 4,
                            Email = "bob@bob.com",
                            Name = "Lucy Liu"
                        },
                        new
                        {
                            Id = 5,
                            Email = "bob@bob.com",
                            Name = "Robert Redford"
                        },
                        new
                        {
                            Id = 6,
                            Email = "bob@bob.com",
                            Name = "Lucy Liu"
                        },
                        new
                        {
                            Id = 7,
                            Email = "bob@bob.com",
                            Name = "Robert Redford"
                        },
                        new
                        {
                            Id = 8,
                            Email = "bob@bob.com",
                            Name = "Lucy Liu"
                        },
                        new
                        {
                            Id = 9,
                            Email = "bob@bob.com",
                            Name = "Robert Redford"
                        },
                        new
                        {
                            Id = 10,
                            Email = "bob@bob.com",
                            Name = "Bob Johnson"
                        },
                        new
                        {
                            Id = 11,
                            Email = "bob@bob.com",
                            Name = "Bob Johnson"
                        },
                        new
                        {
                            Id = 12,
                            Email = "bob@bob.com",
                            Name = "Lucy Liu"
                        },
                        new
                        {
                            Id = 13,
                            Email = "bob@bob.com",
                            Name = "Robert Redford"
                        },
                        new
                        {
                            Id = 14,
                            Email = "bob@bob.com",
                            Name = "Lucy Liu"
                        },
                        new
                        {
                            Id = 15,
                            Email = "bob@bob.com",
                            Name = "Robert Redford"
                        },
                        new
                        {
                            Id = 16,
                            Email = "bob@bob.com",
                            Name = "Lucy Liu"
                        },
                        new
                        {
                            Id = 17,
                            Email = "bob@bob.com",
                            Name = "Robert Redford"
                        },
                        new
                        {
                            Id = 18,
                            Email = "bob@bob.com",
                            Name = "Lucy Liu"
                        },
                        new
                        {
                            Id = 19,
                            Email = "bob@bob.com",
                            Name = "Robert Redford"
                        },
                        new
                        {
                            Id = 20,
                            Email = "bob@bob.com",
                            Name = "Bob Johnson"
                        },
                        new
                        {
                            Id = 21,
                            Email = "bob@bob.com",
                            Name = "Lucy Liu"
                        },
                        new
                        {
                            Id = 22,
                            Email = "bob@bob.com",
                            Name = "Robert Redford"
                        },
                        new
                        {
                            Id = 23,
                            Email = "bob@bob.com",
                            Name = "Lucy Liu"
                        },
                        new
                        {
                            Id = 24,
                            Email = "bob@bob.com",
                            Name = "Robert Redford"
                        },
                        new
                        {
                            Id = 26,
                            Email = "bob@bob.com",
                            Name = "Lucy Liu"
                        },
                        new
                        {
                            Id = 27,
                            Email = "bob@bob.com",
                            Name = "Robert Redford"
                        },
                        new
                        {
                            Id = 28,
                            Email = "bob@bob.com",
                            Name = "Lucy Liu"
                        },
                        new
                        {
                            Id = 29,
                            Email = "bob@bob.com",
                            Name = "Robert Redford"
                        },
                        new
                        {
                            Id = 30,
                            Email = "bob@bob.com",
                            Name = "Bob Johnson"
                        },
                        new
                        {
                            Id = 31,
                            Email = "bob@bob.com",
                            Name = "Robert Redford"
                        },
                        new
                        {
                            Id = 32,
                            Email = "bob@bob.com",
                            Name = "Lucy Liu"
                        },
                        new
                        {
                            Id = 33,
                            Email = "bob@bob.com",
                            Name = "Robert Redford"
                        },
                        new
                        {
                            Id = 34,
                            Email = "bob@bob.com",
                            Name = "Lucy Liu"
                        },
                        new
                        {
                            Id = 35,
                            Email = "bob@bob.com",
                            Name = "Robert Redford"
                        },
                        new
                        {
                            Id = 36,
                            Email = "bob@bob.com",
                            Name = "Lucy Liu"
                        },
                        new
                        {
                            Id = 37,
                            Email = "bob@bob.com",
                            Name = "Robert Redford"
                        },
                        new
                        {
                            Id = 38,
                            Email = "bob@bob.com",
                            Name = "Lucy Liu"
                        },
                        new
                        {
                            Id = 39,
                            Email = "bob@bob.com",
                            Name = "Robert Redford"
                        },
                        new
                        {
                            Id = 40,
                            Email = "bob@bob.com",
                            Name = "Bob Johnson"
                        },
                        new
                        {
                            Id = 41,
                            Email = "bob@bob.com",
                            Name = "Robert Redford"
                        },
                        new
                        {
                            Id = 42,
                            Email = "bob@bob.com",
                            Name = "Lucy Liu"
                        },
                        new
                        {
                            Id = 43,
                            Email = "bob@bob.com",
                            Name = "Robert Redford"
                        },
                        new
                        {
                            Id = 44,
                            Email = "bob@bob.com",
                            Name = "Lucy Liu"
                        },
                        new
                        {
                            Id = 45,
                            Email = "bob@bob.com",
                            Name = "Robert Redford"
                        },
                        new
                        {
                            Id = 46,
                            Email = "bob@bob.com",
                            Name = "Lucy Liu"
                        },
                        new
                        {
                            Id = 47,
                            Email = "bob@bob.com",
                            Name = "Robert Redford"
                        },
                        new
                        {
                            Id = 48,
                            Email = "bob@bob.com",
                            Name = "Lucy Liu"
                        },
                        new
                        {
                            Id = 49,
                            Email = "bob@bob.com",
                            Name = "Robert Redford"
                        },
                        new
                        {
                            Id = 50,
                            Email = "bob@bob.com",
                            Name = "Bob Johnson"
                        },
                        new
                        {
                            Id = 51,
                            Email = "bob@bob.com",
                            Name = "Robert Redford"
                        },
                        new
                        {
                            Id = 52,
                            Email = "bob@bob.com",
                            Name = "Lucy Liu"
                        },
                        new
                        {
                            Id = 53,
                            Email = "bob@bob.com",
                            Name = "Robert Redford"
                        },
                        new
                        {
                            Id = 54,
                            Email = "bob@bob.com",
                            Name = "Lucy Liu"
                        },
                        new
                        {
                            Id = 55,
                            Email = "bob@bob.com",
                            Name = "Robert Redford"
                        },
                        new
                        {
                            Id = 56,
                            Email = "bob@bob.com",
                            Name = "Lucy Liu"
                        },
                        new
                        {
                            Id = 57,
                            Email = "bob@bob.com",
                            Name = "Robert Redford"
                        },
                        new
                        {
                            Id = 58,
                            Email = "bob@bob.com",
                            Name = "Lucy Liu"
                        },
                        new
                        {
                            Id = 59,
                            Email = "bob@bob.com",
                            Name = "Robert Redford"
                        },
                        new
                        {
                            Id = 60,
                            Email = "bob@bob.com",
                            Name = "Bob Johnson"
                        },
                        new
                        {
                            Id = 61,
                            Email = "bob@bob.com",
                            Name = "Lucy Liu"
                        },
                        new
                        {
                            Id = 62,
                            Email = "bob@bob.com",
                            Name = "Lucy Liu"
                        },
                        new
                        {
                            Id = 63,
                            Email = "bob@bob.com",
                            Name = "Robert Redford"
                        },
                        new
                        {
                            Id = 64,
                            Email = "bob@bob.com",
                            Name = "Lucy Liu"
                        },
                        new
                        {
                            Id = 65,
                            Email = "bob@bob.com",
                            Name = "Robert Redford"
                        },
                        new
                        {
                            Id = 66,
                            Email = "bob@bob.com",
                            Name = "Lucy Liu"
                        },
                        new
                        {
                            Id = 67,
                            Email = "bob@bob.com",
                            Name = "Robert Redford"
                        },
                        new
                        {
                            Id = 68,
                            Email = "bob@bob.com",
                            Name = "Lucy Liu"
                        },
                        new
                        {
                            Id = 69,
                            Email = "bob@bob.com",
                            Name = "Robert Redford"
                        },
                        new
                        {
                            Id = 70,
                            Email = "bob@bob.com",
                            Name = "Bob Johnson"
                        },
                        new
                        {
                            Id = 71,
                            Email = "bob@bob.com",
                            Name = "Lucy Liu"
                        },
                        new
                        {
                            Id = 72,
                            Email = "bob@bob.com",
                            Name = "Robert Redford"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
