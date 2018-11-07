using ComputerMaintenance.Models;
using ComputerMaintenance.Services.Exceptions;
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

        public async Task InsertAsync(Maintenance obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Maintenance> FindByIdAsync(int id)
        {
            return await _context.Maintenance.FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Maintenance.FindAsync(id);
                _context.Maintenance.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException(e.Message + "\nCan't delete seller because he/she has sales");
            }
        }
    }
}
