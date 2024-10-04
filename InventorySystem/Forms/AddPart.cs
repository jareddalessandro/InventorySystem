using InventorySystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class AddPart : Form
    {
        private Inventory _inventory;
        internal AddPart(Inventory inventory)
        {
            InitializeComponent();
            _inventory = inventory;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dynamicPartLabel.Text = "Machine ID";
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dynamicPartLabel.Text = "Company Name";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {            
            int inStock;
            decimal Price;
            int Min;
            int Max;
            int MachineID;

            try
            {
                inStock = int.Parse(inventoryTextBox.Text);
                Price = int.Parse(PriceTextBox.Text);
                Min = int.Parse(minTextBox.Text);
                Max = int.Parse(maxTextBox.Text);
            }
            catch {
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
                _inventory.addPart(part);
                Close();
            }
            else
            {
                string CompanyName = machineOrCompanyTextBox.Text;
                OutSourcedPart part = new OutSourcedPart(Name, Price, Min, Max, inStock, CompanyName);
                _inventory.addPart(part);
                Close();
            }
            

        }
    }
}
