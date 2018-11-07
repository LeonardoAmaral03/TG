using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ComputerMaintenance.Models;
using ComputerMaintenance.Services;

namespace ComputerMaintenance.Controllers
{
    public class MaintenancesController : Controller
    {
        private readonly MaintenanceService _maintenanceService;

        public MaintenancesController(MaintenanceService maintenanceService)
        {
            _maintenanceService = maintenanceService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _maintenanceService.FindAllAsync();

            return View(list);
        }
    }
}
