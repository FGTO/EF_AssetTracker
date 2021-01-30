using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EF_AssetTracker.Domain;

namespace EF_AssetTracker.Data
{
    class VehicleContext : DbContext
    {
        public DbSet<Computer> Computer { get; set; }
        public DbSet<Phone> Phone { get; set; }
        public DbSet<Office> Office { get; set; }
    
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
            optionsBuilder.UseSqlServer(@"Server=.,1433;Initial Catalog=AssetTracking;Persist Security Info=False;User ID=sa;Password=YABqaLw-7QL2;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30");
        }
    }
}
