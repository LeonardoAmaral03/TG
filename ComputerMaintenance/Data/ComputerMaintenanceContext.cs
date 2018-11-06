using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ComputerMaintenance.Models
{
    public class ComputerMaintenanceContext : DbContext
    {
        public ComputerMaintenanceContext (DbContextOptions<ComputerMaintenanceContext> options)
            : base(options)
        {
        }

        public DbSet<Maintenance> Maintenance { get; set; }
        public DbSet<ComputerItem> ComputerItem { get; set; }
        public DbSet<Computer> Computer { get; set; }
    }
}
