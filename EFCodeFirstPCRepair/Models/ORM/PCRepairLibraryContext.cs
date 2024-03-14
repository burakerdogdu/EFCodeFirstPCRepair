using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EFCodeFirstPCRepair.Models.ORM
{
    public class PCRepairLibraryContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=WTRISTHDESK023\\SQLEXPRESS;Database=PCRepair;Trusted_Connection=True;TrustServerCertificate=True");       
        }
        public DbSet<Customer> customer { get; set; }
        public DbSet<Invoices> invoices { get; set; }
        public DbSet<ServiceRecord> serviceRecords { get; set; }

        public DbSet<ServiceStatus> serviceStatus { get; set; }

        public DbSet<SpareParts> spareParts { get; set; }
        public DbSet<Staff> staff { get; set; }
    }
   
}
