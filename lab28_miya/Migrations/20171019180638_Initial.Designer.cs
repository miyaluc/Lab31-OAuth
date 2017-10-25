﻿// <auto-generated />
using lab28_miya.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace lab28_miya.Migrations
{
    [DbContext(typeof(lab28_miyaContext))]
    [Migration("20171019180638_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("lab28_miya.Models.CPS", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("HasCompassion");

                    b.Property<string>("Name");

                    b.Property<string>("Region");

                    b.Property<int>("YearsInService");

                    b.Property<string>("Zodiac");

                    b.HasKey("ID");

                    b.ToTable("CPS");
                });
#pragma warning restore 612, 618
        }
    }
}