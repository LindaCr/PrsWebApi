using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrsWebApi.Models;

namespace PrsWebApi.Data
{
    public class PrsWebApiAppDbContext : DbContext
    {
        public PrsWebApiAppDbContext(DbContextOptions<PrsWebApiAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<PrsWebApi.Models.User> Users { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<LineItem> LineItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>(e => { e.HasIndex(p => p.Username).IsUnique(); });
            builder.Entity<Vendor>(e => { e.HasIndex(p => p.Code).IsUnique(); });
            builder.Entity<Product>(e => { e.HasIndex(p => p.PartNumber).IsUnique(); });
        }



    }
}
