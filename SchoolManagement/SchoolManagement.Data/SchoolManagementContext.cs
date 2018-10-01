using Microsoft.EntityFrameworkCore;
using SchoolManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Data
{
    public class SchoolManagementContext : DbContext
    {
        public SchoolManagementContext(DbContextOptions<SchoolManagementContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
