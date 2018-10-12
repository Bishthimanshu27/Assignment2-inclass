using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application2.Models.Classes
{
    public class StoreLocation
    {
        public int Id { get; set; }
        public string LocationName { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}