using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Bakery.Data;
using Bakery.Models;

namespace Bakery.Pages
{
    public class IndexModel : PageModel
    {
        //from tutorial:  https://www.learnrazorpages.com/razor-pages/tutorial/bakery/working-with-data

        //constructor using dependency injection
        private readonly BakeryContext db;
        public IndexModel(BakeryContext db) => this.db = db;
        
        //could also be written as:
        // private readonly BakeryContext db;
        // public IndexModel(BakeryContext db)
        // {
        //   db = this.db
        // }
        //it creates an empty object of type BakeryContext, then populates it with the context that was regsitered as a service in startup.cs
        
        public List<Product> Products { get; set; } = new List<Product>();   //declare list to hold db data (still empty)
        public Product FeaturedProduct { get; set; }  //declare product object for featured product (still empty)
        
        public async Task OnGetAsync()
        {
            Products = await db.Products.ToListAsync();  //load DB Products table contents into Products class instance
            FeaturedProduct = Products.ElementAt(new Random().Next(Products.Count()));  //Load DB data for record into FeaturedProduct class instance
        }
    }
}
