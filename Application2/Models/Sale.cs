using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application2.Models.Classes
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTimeOffset Date { get; set; }

        public Customer CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public StoreLocation StoreLocationId { get; set; }
        public virtual StoreLocation StoreLocation { get; set; }

        public string EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        public string EmployeeToApproveSalesId { get; set; }
        public virtual Employee EmployeeToApproveSales { get; set; }

        public virtual ICollection<Product> Products { get; set; }

  
    }
}