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

        int partNumber = 0;
        int productNumber = 0;

        public void addProduct(Product product)
        {
            product.ProductID = generateProductID();
            Products.Add(product);
        }
        public bool removeProduct(int ID)
        {
            Product productToRemove = lookupProduct(ID);
            return Products.Remove(productToRemove);
        }

        public Product lookupProduct(int ID)
        {
            foreach(Product product in Products)
            {
                if (product.ProductID == ID)
                {
                    return product;
                }
            }
            return new Product();
        }

        public void updateProduct(int productID, Product updatedProduct)
        {
            // Find the part in AllParts with the matching PartID
            int index = Products.ToList().FindIndex(p => p.ProductID == productID);

            // Check if the part was found
            if (index != -1)
            {
                // Update the part while keeping the existing PartID
                updatedProduct.ProductID = productID; // Preserve the existing PartID
                Products[index] = updatedProduct; // Replace the part at the found index
            }
            else
            {
                throw new ArgumentException("Part with the specified ID not found.");
            }
        }

        public void addPart(Part part)
        {
            part.PartID = generatePartID();
            AllParts.Add(part);
        }

        public bool deletePart(Part part)
        {
            foreach (Product product in Products)
            {
                if (product.AssociatedParts.Any(p => p.PartID == part.PartID))
                {
                    // Part is associated with a product; prevent deletion
                    MessageBox.Show("This part is associated with one or more products and cannot be deleted.", "Delete Part", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            Part partToRemove = lookupPart(part.PartID);
            return AllParts.Remove(partToRemove);
        }

        public Part lookupPart(int ID)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == ID)
                {
                    return part;
                }
            }
            return new InHousePart();
            
        }

        public void updatePart(int partID, Part updatedPart)
        {
            // Find the part in AllParts with the matching PartID
            int index = AllParts.ToList().FindIndex(p => p.PartID == partID);

            // Check if the part was found
            if (index != -1)
            {
                // Update the part while keeping the existing PartID
                updatedPart.PartID = partID; // Preserve the existing PartID
                AllParts[index] = updatedPart; // Replace the part at the found index
            }
            else
            {
                throw new ArgumentException("Part with the specified ID not found.");
            }
        }

        public void populateDefaultValues()
        {
            Product product = new Product("Example Product", 10.99m, 5, 5, 7);
            addProduct(product);
            Product product2 = new Product("Second Product", 15.99m, 6, 5, 6);
            addProduct(product2);

            OutSourcedPart outSourcedPart = new OutSourcedPart("Flux Capacitor", 5.99m, 3, 15, 13, "GE");
            addPart(outSourcedPart);
            InHousePart inHousePart = new InHousePart("Transformer", 17.99m, 12, 29, 13, 07318);
            addPart(inHousePart);
            InHousePart inHousePart2 = new InHousePart("Conduit", 17.99m, 12, 29, 13, 07318);
            addPart(inHousePart2);
        }

        public int generatePartID()
        {                     
            return partNumber++;
        }

        public int generateProductID()
        {
            return productNumber++;
        }

    }
}
