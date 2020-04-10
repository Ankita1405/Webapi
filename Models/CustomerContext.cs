using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerApi.Models
{
    public class CustomerContext:DbContext
    {
        public CustomerContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Customer>Customers { get; set; }
        protected override void OnModelCreating
    (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer { CId = 1,CName = "sam", CDob = new DateTime(day: 02, month: 12, year: 2019),CPIN =1234 },
                  new Customer { CId = 2, CName = "sami", CDob = new DateTime(day: 03, month: 12, year: 2019), CPIN =4562},
                    new Customer { CId = 3, CName = "sameer", CDob= new DateTime(day: 04, month: 12, year: 2019), CPIN =7894}
                );
        }


    }
}
