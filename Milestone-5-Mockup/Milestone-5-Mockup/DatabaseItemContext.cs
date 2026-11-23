using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Milestone_5_Mockup
{
    public class DatabaseItemContext : DbContext
    {
        public DatabaseItemContext()
        { }

        public DatabaseItemContext(DbContextOptions<DatabaseItemContext> options) 
                : base(options)
            { }

        public DbSet<DatabaseItem> DatabaseItems { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DatabaseItemDb;Trusted_Connection=true;");
            }   

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<DatabaseItem>().HasData(
                new DatabaseItem
                {
                    ItemId = 1,
                    ItemName = "Apache NetBeans",
                    ItemVersion = "Latest",
                    TextbookOrSoftware = "Software",
                    Publisher = "Apache Software Foundation",
                    VpatStatus = "Yes",
                    ClassRequesting = "CITC 1310/1311",
                    IndividualRequesting = "Meili Charles",
                    VpatRequestDate = "11-15-2026",
                    VpatLink = "",
                    VpatOutreachDate = "11-15-2026",
                    OutsideRiskAssessment = "Pending",
                    InternalRiskAssessment = "Pending",
                    FinalApproval = "Pending",
                }
                );
        }
    }
}
