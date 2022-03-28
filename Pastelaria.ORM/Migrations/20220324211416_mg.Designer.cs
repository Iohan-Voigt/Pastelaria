﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pastelaria.ORM;

namespace Pastelaria.ORM.Migrations
{
    [DbContext(typeof(PastelariaDBContext))]
    [Migration("20220324211416_mg")]
    partial class mg
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Pastelaria.Domain.Costumer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("IndentityDocument")
                        .HasColumnType("VARCHAR(14)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(75)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("VARCHAR(20)");

                    b.HasKey("Id");

                    b.ToTable("TBCOSTUMER");
                });

            modelBuilder.Entity("Pastelaria.Domain.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AcessUser")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)");

                    b.Property<int>("EmployeeActiveEnum")
                        .HasColumnType("INT");

                    b.Property<int>("EmployeePermissionsEnum")
                        .HasColumnType("INT");

                    b.Property<string>("IndentityDocument")
                        .IsRequired()
                        .HasColumnType("VARCHAR(14)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(75)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("Registration")
                        .IsRequired()
                        .HasColumnType("VARCHAR(30)");

                    b.HasKey("Id");

                    b.ToTable("TBEMPLOYEE");
                });
#pragma warning restore 612, 618
        }
    }
}