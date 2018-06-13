using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class StdClass
    {
        string name;
        int floor;
        int maxCapicity;
        string description;

        public StdClass()
        {

        }
        public StdClass(string name, int floor, int maxCapicity, string description)
        {
            this.name = name;
            this.floor = floor;
            this.maxCapicity = maxCapicity;
            this.description = description;
        }

        public string Name { get => name; set => name = value; }
        public int Floor { get => floor; set => floor = value; }
        public int MaxCapicity { get => maxCapicity; set => maxCapicity = value; }
        public string Description { get => description; set => description = value; }
    }
}
