﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parks.Models;

namespace Parks.Migrations
{
    [DbContext(typeof(ParksContext))]
    [Migration("20200821175037_SeedNationalData")]
    partial class SeedNationalData
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

                    b.HasData(
                        new
                        {
                            NationalId = 1,
                            NationalName = "USA",
                            NationalParkName = "Glacier National Park",
                            NationalParkYear = 1910
                        },
                        new
                        {
                            NationalId = 2,
                            NationalName = "USA",
                            NationalParkName = "Grand Canyon National Park",
                            NationalParkYear = 1919
                        },
                        new
                        {
                            NationalId = 3,
                            NationalName = "USA",
                            NationalParkName = "Crater Lake National Park",
                            NationalParkYear = 1902
                        },
                        new
                        {
                            NationalId = 4,
                            NationalName = "USA",
                            NationalParkName = "Yellowstone National Park",
                            NationalParkYear = 1872
                        },
                        new
                        {
                            NationalId = 5,
                            NationalName = "USA",
                            NationalParkName = "Yosemite National Park",
                            NationalParkYear = 1890
                        });
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
