using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Database
{
    public class DataDBContext : DbContext
    {
        public DbSet<ZFormat> ProductData { get; set; }

        public DataDBContext(DbContextOptions<DataDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ZFormat>().HasKey(x => x.Id);
        }
    }
}
