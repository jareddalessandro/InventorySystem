using InventorySystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class ModifyPart : Form
    {
        private Inventory _inventory;
        internal ModifyPart(Inventory inventory, Part part)
        {
            InitializeComponent();
            _inventory = inventory;
            idTextBox.Text = Convert.ToString(part.PartID);
            nameTextBox.Text = part.Name;
            inventoryTextBox.Text = Convert.ToString(part.InStock);
            priceTextBox.Text = Convert.ToString(part.Price);
            minTextBox.Text = Convert.ToString(part.Min);
            maxTextBox.Text = Convert.ToString(part.Max);

            // Check if the part is of type InHousePart
            if (part is InHousePart inHousePart)
            {
                machineOrCompanyTextBox.Text = inHousePart.MachineID.ToString();
                // Set the UI to show InHousePart-specific fields
                radioButton1.Checked = true;
            }
            // Check if the part is of type OutSourcedPart
            else if (part is OutSourcedPart outsourcedPart)
            {
                machineOrCompanyTextBox.Text = outsourcedPart.CompanyName;
                // Set the UI to show OutSourcedPart-specific fields
                radioButton2.Checked = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dynamicPartLabel.Text = "Machine ID";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dynamicPartLabel.Text = "Company Name";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int inStock;
            decimal Price;
            int Min;
            int Max;
            int MachineID;

            try
            {
                inStock = int.Parse(inventoryTextBox.Text);
                Price = decimal.Parse(priceTextBox.Text);
                Min = int.Parse(minTextBox.Text);
                Max = int.Parse(maxTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Max and Min text fields must be numeric values.");
                return;
            }

            string Name = nameTextBox.Text;
            if (radioButton1.Checked)
            {
                try
                {
                    MachineID = int.Parse(machineOrCompanyTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Error: Machine ID text fields must be numeric values.");
                    return;
                }

                InHousePart part = new InHousePart(Name, Price, Min, Max, inStock, MachineID);
                _inventory.updatePart(part.PartID, part);
                Close();
            }
            else
            {
                string CompanyName = machineOrCompanyTextBox.Text;
                OutSourcedPart part = new OutSourcedPart(Name, Price, Min, Max, inStock, CompanyName);
                _inventory.updatePart(part.PartID, part);
                Close();
            }
        }
    }
}
