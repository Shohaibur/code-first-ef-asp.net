using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace code_first_ef_asp.net.EF.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int? Quantity { get; set; } // Use int? = nullable

    }
}