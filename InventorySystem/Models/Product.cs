using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Models
{
    internal class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min {  get; set; }
        public int Max { get; set; }

        public Product() { }
        public Product(string name, decimal price, int inStock, int min, int max)
        {
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            AssociatedParts = new BindingList<Part>(); // Initialize if needed in specific constructor
        }

        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part); 
        }
        public bool removeAssociatedPart(int ID) {

            Part foundPart = lookupAssociatedPart(ID);
            if (AssociatedParts.Remove(foundPart))
            {
                return true;
            }
            else { return false; }
        }

        public Part lookupAssociatedPart(int ID)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == ID)
                {
                    return part;
                }
            }
            return new InHousePart();
        }
    }
}
