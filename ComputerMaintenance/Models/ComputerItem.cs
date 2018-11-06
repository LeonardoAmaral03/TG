using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerMaintenance.Models
{
    public class ComputerItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public DateTime AcquisitionDate { get; set; }
        public Computer Computer { get; set; }
        public ICollection<Maintenance> Maintenances { get; set; } = new List<Maintenance>();

        public ComputerItem()
        {
        }

        public ComputerItem(int id, string name, string brand, string model, string description, DateTime acquisitionDate, Computer computer)
        {
            Id = id;
            Name = name;
            Brand = brand;
            Model = model;
            Description = description;
            AcquisitionDate = acquisitionDate;
            Computer = computer;
        }
    }
}
