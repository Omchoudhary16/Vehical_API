using DAL.Veh.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Veh
{
    public class VehDbContext : DbContext
    {
        public VehDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Vehicle> vehicles { get; set; }
    }
}
