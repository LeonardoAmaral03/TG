using ComputerMaintenance.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerMaintenance.Models
{
    public class Maintenance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Activity { get; set; }
        public int Period { get; set; }
        public MaintenanceStatus Status { get; set; }
        public ComputerItem Item { get; set; }

        public Maintenance()
        {
        }

        public Maintenance(int id, string name, string activity, int period, MaintenanceStatus status, ComputerItem item)
        {
            Id = id;
            Name = name;
            Activity = activity;
            Period = period;
            Status = status;
            Item = item;
        }
    }
}
