using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstPCRepair.Models.ORM
{
    public class SpareParts
    {
        [Key]
        public int PartsId { get; set; }
        public string PartsName { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? QuantityOfStock { get; set; }
        public string Price { get; set; }
    }
}
