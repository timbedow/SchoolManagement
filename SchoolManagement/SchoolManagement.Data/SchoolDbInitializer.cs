using Microsoft.EntityFrameworkCore;
using SchoolManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Data
{
    public static class SchoolDbInitializer
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData
            (
                //https://www.randomlists.com/random-celebrities?qty=25
                new Student { Id = 1, FirstName = "Harrison", LastName = "Ford", DateOfBirth = new DateTime(1942, 07, 13), ImageUrl = "https://www.randomlists.com/img/people/harrison_ford.jpg" },
                new Student { Id = 2, FirstName = "Carrie", LastName = "Underwood", DateOfBirth = new DateTime(1983, 03, 10), ImageUrl = "https://www.randomlists.com/img/people/carrie_underwood.jpg" },
                new Student { Id = 3, FirstName = "Ben", LastName = "Affleck", DateOfBirth = new DateTime(1972, 08, 15), ImageUrl = "https://www.randomlists.com/img/people/ben_affleck.jpg" },
                new Student { Id = 4, FirstName = "Johnny", LastName = "Depp", DateOfBirth = new DateTime(1963, 06, 09), ImageUrl = "https://www.randomlists.com/img/people/johnny_depp.jpg" }, //
                new Student { Id = 5, FirstName = "Natalie", LastName = "Portman", DateOfBirth = new DateTime(1981, 06, 09), ImageUrl = "https://www.randomlists.com/img/people/natalie_portman.jpg" }, //
                new Student { Id = 6, FirstName = "Adam", LastName = "Sandler", DateOfBirth = new DateTime(1966, 09, 09), ImageUrl = "https://www.randomlists.com/img/people/adam_sandler.jpg" },
                new Student { Id = 7, FirstName = "Bradley", LastName = "Cooper", DateOfBirth = new DateTime(1975, 01, 05), ImageUrl = "https://www.randomlists.com/img/people/bradley_cooper.jpg" },
                new Student { Id = 8, FirstName = "Keanu", LastName = "Reeves", DateOfBirth = new DateTime(1964, 09, 02), ImageUrl = "https://www.randomlists.com/img/people/keanu_reeves.jpg" }
            );

        }
    }
}
