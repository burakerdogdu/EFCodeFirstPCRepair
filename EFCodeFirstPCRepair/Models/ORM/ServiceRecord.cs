using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstPCRepair.Models.ORM
{
    public class ServiceRecord
    {
        [Key]
        public int ServiceId { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        [MaxLength(30)]
        public string DeviceType { get; set; }
        [MaxLength(30)]
        public string Brand { get; set; }
        [MaxLength(30)]
        public string Model { get; set; }
        public int SerialNo { get; set; }
        [MaxLength(200)]
        public string FaultDescription { get; set; }
        public DateTime DateAdmission { get; set; }
        public DateTime EstimatedCompletionDate { get; set;}
        public int StatusId { get; set; }
        [ForeignKey("StatusId")]
        public ServiceStatus Status { get; set; }

    }
}
