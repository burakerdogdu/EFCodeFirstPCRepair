using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstPCRepair.Models.ORM
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [MaxLength(25)]
        public string CustomerFirstName { get; set; }
        [MaxLength(25)]
        public string CustomerLastName { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        [MaxLength(150)]
        public string Adress { get; set; }
        
    }
}
