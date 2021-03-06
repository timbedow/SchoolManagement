﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolManagement.Data;

namespace SchoolManagement.Data.Migrations
{
    [DbContext(typeof(SchoolManagementContext))]
    [Migration("20181001051558_Seed_Data_03")]
    partial class Seed_Data_03
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SchoolManagement.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new { Id = 1, DateOfBirth = new DateTime(1942, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Harrison", ImageUrl = "https://www.randomlists.com/img/people/harrison_ford.jpg", LastName = "Ford" },
                        new { Id = 2, DateOfBirth = new DateTime(1983, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Carrie", ImageUrl = "https://www.randomlists.com/img/people/carrie_underwood.jpg", LastName = "Underwood" },
                        new { Id = 3, DateOfBirth = new DateTime(1972, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Ben", ImageUrl = "https://www.randomlists.com/img/people/ben_affleck.jpg", LastName = "Affleck" },
                        new { Id = 4, DateOfBirth = new DateTime(1963, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Johnny", ImageUrl = "https://www.randomlists.com/img/people/johnny_depp.jpg", LastName = "Depp" },
                        new { Id = 5, DateOfBirth = new DateTime(1981, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Natalie", ImageUrl = "https://www.randomlists.com/img/people/natalie_portman.jpg", LastName = "Portman" },
                        new { Id = 6, DateOfBirth = new DateTime(1966, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Adam", ImageUrl = "https://www.randomlists.com/img/people/adam_sandler.jpg", LastName = "Sandler" },
                        new { Id = 7, DateOfBirth = new DateTime(1975, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Bradley", ImageUrl = "https://www.randomlists.com/img/people/bradley_cooper.jpg", LastName = "Cooper" },
                        new { Id = 8, DateOfBirth = new DateTime(1964, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Keanu", ImageUrl = "https://www.randomlists.com/img/people/keanu_reeves.jpg", LastName = "Portman" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
