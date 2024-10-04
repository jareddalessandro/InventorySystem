using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Models
{
    internal class InHousePart : Part
    {
        public int MachineID { get; set; }

        public InHousePart() { }
        public InHousePart(string name, decimal price, int min, int max, int instock, int machineid)
        {
            MachineID = machineid;
            Name = name;
            Price = price;
            Min = min;
            Max = max;
            InStock = instock;
        }

    }
}
