using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatAdekunle.Models;

namespace RecruitCatAdekunle.Data
{
    public class RecruitCatAdekunleContext : DbContext
    {
        internal IEnumerable JobTitles;

        public RecruitCatAdekunleContext (DbContextOptions<RecruitCatAdekunleContext> options)
            : base(options)
        {
        }

        // Your DbSet Properties go here
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Candidate>()
                .Property(c => c.TargetSalary)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Company>()
                .Property(c => c.MinSalary)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Company>()
                .Property(c => c.MaxSalary)
                .HasPrecision(18, 2);

            modelBuilder.Entity<JobTitle>()
                .Property(j => j.MinSalary)
                .HasPrecision(18, 2);

            modelBuilder.Entity<JobTitle>()
                .Property(j => j.MaxSalary)
                .HasPrecision(18, 2);

            // Seed data for the JobTitles table
            modelBuilder.Entity<JobTitle>().HasData(
                new JobTitle
                {
                    Id = 1, // Make sure the Ids are unique
                    Title = "Software Engineer",
                    MinSalary = 60000m,
                    MaxSalary = 120000m,
                    JobDescription = "Develop and maintain software applications."
                },
                new JobTitle
                {
                    Id = 2,
                    Title = "Data Analyst",
                    MinSalary = 50000m,
                    MaxSalary = 100000m,
                    JobDescription = "Analyze and interpret data to drive decision-making."
                },
                new JobTitle
                {
                    Id = 3,
                    Title = "Product Manager",
                    MinSalary = 70000m,
                    MaxSalary = 130000m,
                    JobDescription = "Manage product development and lead teams."
                }
            );

            base.OnModelCreating(modelBuilder);
        }
      
        public DbSet<RecruitCatAdekunle.Models.Candidate> Candidate { get; set; } = default!;
        public DbSet<RecruitCatAdekunle.Models.Company> Company { get; set; } = default!;
        public DbSet<RecruitCatAdekunle.Models.Industry> Industry { get; set; } = default!;
        public DbSet<RecruitCatAdekunle.Models.JobTitle> JobTitle { get; set; } = default!;
    }
}
