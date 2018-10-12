using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application2.Models.Classes
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}