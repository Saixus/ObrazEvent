using ObrazEvent.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObrazEvent.Data
{
    // Wjen you create this class you may call code first migration for the project
    public class ObrazEventDbContext : DbContext
    {
        public ObrazEventDbContext() : base("DefaultConnection") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Use singular table names
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        // These properties are gates for code first migration
        public DbSet<Service> Services { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Video> Videos { get; set; }
    }
}
