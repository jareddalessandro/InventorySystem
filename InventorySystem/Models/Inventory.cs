using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Models
{
    internal class Inventory
    {
        public BindingList<Product> Products  = new BindingList<Product>();
        public BindingList<Part> AllParts = new BindingList<Part>();

        public int nextPartID = 0;
        public int nextProductID = 0;

        public void addProduct(Product product)
        {
            product.ProductID = generateProductID();
            Products.Add(product);
        }
        public bool removeProduct(int ID)
        {
            if (Products.Remove(Products[ID]))
            {
                return true;
            }
            return false;
        }

        public Product lookupProduct(int ID)
        {
            return Products[ID];
        }

        public void updateProduct(int ID, Product product)
        {
            Products.RemoveAt(ID);
            product.ProductID = generateProductID();
            Products.Add(product);
        }

        public void addPart(Part part)
        {
            part.PartID = generatePartID();
            AllParts.Add(part);
        }

        public bool deletePart(int ID)
        {
            if (AllParts.Remove(AllParts[ID]))
            {
                return true;
            }
            return false;
        }

        public Part lookupPart(int ID)
        {
            return AllParts[ID];
        }

        public void updatePart(int ID, Part part)
        {
            AllParts.RemoveAt(ID);
            part.PartID = generatePartID();
            AllParts.Add(part);
        }

        public void populateDefaultValues()
        {
            Product product = new Product("Example Product", 10.99m, 3, 5, 7);
            Products.Add(product);

            OutSourcedPart outSourcedPart = new OutSourcedPart("Flux Capacitor", 5.99m, 3, 7, 13, "GE");
            AllParts.Add(outSourcedPart);

            InHousePart inHousePart = new InHousePart("Transformer", 17.99m, 12, 29, 9, 07318);
            AllParts.Add(inHousePart);
        }

        public int generatePartID()
        {
            return nextPartID++;
        }

        public int generateProductID()
        {
            return nextProductID++;
        }

    }
}
