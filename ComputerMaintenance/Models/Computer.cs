using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerMaintenance.Models
{
    public class Computer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<ComputerItem> Items { get; set; } = new List<ComputerItem>();

        public Computer()
        {
        }

        public Computer(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}
