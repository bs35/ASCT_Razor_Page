using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASCT_API.Models
{
    public class AircraftDBContext : DbContext
    {
        public AircraftDBContext(DbContextOptions<AircraftDBContext> options) : base(options)
        {

        }

        public DbSet<Aircraft> Aircrafts { get; set; } 
       
    }
}
