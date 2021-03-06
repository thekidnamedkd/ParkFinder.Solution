﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parks.Models;

namespace Parks.Migrations
{
    [DbContext(typeof(ParksContext))]
    [Migration("20200821171426_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Parks.Models.National", b =>
                {
                    b.Property<int>("NationalId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NationalName");

                    b.Property<string>("NationalParkName");

                    b.Property<int>("NationalParkYear");

                    b.HasKey("NationalId");

                    b.ToTable("Nationals");
                });

            modelBuilder.Entity("Parks.Models.State", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("StateName");

                    b.Property<string>("StateParkName");

                    b.Property<int>("StateParkYear");

                    b.HasKey("StateId");

                    b.ToTable("States");
                });
#pragma warning restore 612, 618
        }
    }
}
