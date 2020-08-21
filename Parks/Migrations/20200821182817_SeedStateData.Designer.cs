﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parks.Models;

namespace Parks.Migrations
{
    [DbContext(typeof(ParksContext))]
    [Migration("20200821182817_SeedStateData")]
    partial class SeedStateData
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

                    b.HasData(
                        new
                        {
                            StateId = 1,
                            StateName = "New York",
                            StateParkName = "Niagara Falls State Park",
                            StateParkYear = 1885
                        },
                        new
                        {
                            StateId = 2,
                            StateName = "Michigan",
                            StateParkName = "Porcupine Mountains Wilderness State Park",
                            StateParkYear = 1944
                        },
                        new
                        {
                            StateId = 3,
                            StateName = "Oregon",
                            StateParkName = "Ecola State Park",
                            StateParkYear = 1932
                        },
                        new
                        {
                            StateId = 4,
                            StateName = "Minnesota",
                            StateParkName = "Tettegouche State Park",
                            StateParkYear = 1979
                        },
                        new
                        {
                            StateId = 5,
                            StateName = "Nevada",
                            StateParkName = "Valley of Fire State Park",
                            StateParkYear = 1935
                        });
                });
#pragma warning restore 612, 618
        }
    }
}