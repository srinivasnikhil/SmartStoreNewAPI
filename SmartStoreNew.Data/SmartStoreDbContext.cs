using Microsoft.EntityFrameworkCore;
using SmartStoreNew.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStoreNew.Data
{
    public class SmartStoreDbContext : DbContext
    {
        public SmartStoreDbContext(DbContextOptions<SmartStoreDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configure your entity mappings here
            modelBuilder.Entity<User>().ToTable("Users");
        }

    }
}
