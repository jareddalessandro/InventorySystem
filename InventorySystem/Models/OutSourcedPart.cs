using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Models
{
    internal class OutSourcedPart : Part
    {
        public string CompanyName { get; set; }

        public OutSourcedPart() { }
        public OutSourcedPart(string name, decimal price, int min, int max, int instock, string companyname)
        {
            CompanyName = companyname;
            Name = name;
            Price = price;
            Min = min;
            Max = max;
            InStock = instock;               
        }
    }
}
