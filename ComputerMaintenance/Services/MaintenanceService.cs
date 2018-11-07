using ComputerMaintenance.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerMaintenance.Services
{
    public class MaintenanceService
    {
        private readonly ComputerMaintenanceContext _context;

        public MaintenanceService(ComputerMaintenanceContext context)
        {
            _context = context;
        }

        public async Task<List<Maintenance>> FindAllAsync()
        {
            return await _context.Maintenance.ToListAsync();
        }
    }
}
