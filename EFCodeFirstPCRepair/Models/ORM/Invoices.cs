using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstPCRepair.Models.ORM
{
    public class Invoices
    {
        [Key]
        public int InvoiceId { get; set; }
        public int ServiceId { get; set; }
        [ForeignKey("ServiceId")]
        public ServiceRecord ServiceRecord { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal totalAmount { get; set; }
    }
}
