using code_first_ef_asp.net.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace code_first_ef_asp.net.EF
{
    public class PMSContext:DbContext
    {
        public DbSet<Category>Categories { get; set; }
        public DbSet<Product>Products { get; set; }
        public DbSet<Users>Users { get; set; }
    }
}