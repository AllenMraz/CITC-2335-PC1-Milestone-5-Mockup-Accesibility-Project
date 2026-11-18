using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Milestone_5_Mockup
{
    public class DatabaseItemContext : DbContext
    {
        public DatabaseItemContext(DbContextOptions<DatabaseItemContext> options) 
                : base(options) 
            { }

        public DbSet<DatabaseItem> DatabaseItems { get; set; } = null!;
    }
}
