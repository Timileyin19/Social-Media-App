using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistent
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)        
        { 
        }

        public DbSet<Value> Values { get; set; }  


        protected override void OnModelCreating(ModelBuilder builder)      //  this is use to seed some data into the DB
        {
            builder.Entity<Value>()
                .HasData(
                    new Value {Id = 1, Name = "Ti Value"},
                    new Value {Id = 2, Name = "Ta Value"},
                    new Value {Id = 3, Name = "Tj Value"}
                );
        }   
    }
}
