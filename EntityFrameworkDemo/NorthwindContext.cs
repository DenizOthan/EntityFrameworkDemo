using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo
{
    class NorthwindContext:DbContext    //veri tabanına bağlantı açmamızı sağlayan yer. //DbCOntext=entity framework classı.
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true"); 
        }
        public DbSet<Product> Products { get; set; }

    }
}
