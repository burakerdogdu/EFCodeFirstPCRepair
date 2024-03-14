using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstPCRepair.Models.ORM
{
    public class ServiceStatus
    {
        [Key]
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public string? Description { get; set; }
    }
}
