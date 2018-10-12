using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Application2.Models.Classes
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegistrationNumber { get; set; }

        [InverseProperty("SaleMaker")]
        public ICollection<Sale> MakerSales { get; set; }

        [InverseProperty("SaleAprover")]
        public ICollection<Sale> AproverSales { get; set; }
    }
}