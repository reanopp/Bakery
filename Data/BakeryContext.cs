using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bakery.Models; //refer to the models namespace here
using Bakery.Data.Configurations; //refer to the configuration class

namespace Bakery.Data
{
    //Context is the DB interface
    public class BakeryContext : DbContext //inherits from DBcontext, required
    {
        public DbSet<Product> Products { get; set; }   //Products is the name of the DB table. <Product> is the model bound to it.
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source=Bakery.db");
        }

        //Refer to the model/DB configuration class
        protected override void OnModelCreating(ModelBuilder modelBuiler)
        {
            modelBuiler.ApplyConfiguration(new ProductConfiguration()).Seed(); //Apply configuration and seeds the DB
            //modelBuiler.ApplyConfiguration(new ProductConfiguration());   <-- this applies the configuration whithout seeding
        }


    }
}
