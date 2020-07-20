using System;
using System.Collections.Generic;
using System.Text;
using MeteMarketting.Entity.SomutNesnelerim;
using Microsoft.EntityFrameworkCore;

namespace MeteMarketting.Data.Concreate.EntityFramework
{
    public class EcommerceContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-UOB2H8R\SQLEXPRESS;Database=ECommerce; Trusted_Connection=true");
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Category>  Categories { get; set; }

       
    }
}
