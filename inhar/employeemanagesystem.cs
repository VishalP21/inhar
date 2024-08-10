using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inhar
{
    public class employeemanagesystem : DbContext
    {
        public DbSet<employe> employes { get; set; }
       


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=VISAL\MSSQLSERVER02;Database=employeemanagesystem;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");

        }
    }
}
