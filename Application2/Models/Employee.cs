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

        [InverseProperty("EmployeeToMakeSales")]
        public ICollection<Sale> SalesMaker { get; set; }

        [InverseProperty("EmployeeToApproveSales")]
        public ICollection<Sale> SalesApprover { get; set; }
    }
}