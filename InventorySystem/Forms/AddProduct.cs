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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace InventorySystem
{
    public partial class AddProduct : Form
    {
        private Inventory _inventory;
        private Product _product = new Product();
        internal AddProduct(Inventory inventory)
        {
            InitializeComponent();
            _inventory = inventory;

            var partDataSource = new BindingSource();
            partDataSource.DataSource = inventory.AllParts;
            partGridView.DataSource = partDataSource;

            var associatedDataSource = new BindingSource();
            associatedDataSource.DataSource = _product.AssociatedParts;
            associatedGridView.DataSource = associatedDataSource;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addPart_Click(object sender, EventArgs e)
        {
            if (partGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = partGridView.SelectedRows[0];
                // Cast the DataBoundItem to a Part object
                Part selectedPart = (Part)selectedRow.DataBoundItem;
                _product.addAssociatedPart(selectedPart);
            }
        }

        private void deletePartButton_Click(object sender, EventArgs e)
        {
            if (associatedGridView.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show($"Are you sure you want to delete the selected Part?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Confirm before deleting (optional)
                    foreach (DataGridViewRow row in associatedGridView.SelectedRows)
                    {
                        _product.removeAssociatedPart(row.Index);
                    }
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int inStock;
            decimal Price;
            int Min;
            int Max;
            
            try
            {
                inStock = int.Parse(textBox3.Text);
                Price = decimal.Parse(textBox4.Text);
                Min = int.Parse(textBox5.Text);
                Max = int.Parse(textBox6.Text);
            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Max and Min text fields must be numeric values.");
                return;
            }

            if (Min > Max)
            {
                MessageBox.Show("Error: Min can not be larger than Max.");
                return;
            }

            if (inStock > Max || inStock < Min)
            {
                MessageBox.Show("Error: Inventory must be between Min and Max values.");
                return;
            }

            string Name = textBox2.Text;


            Product product = new Product(Name, Price, Min, Max, inStock);
            product.AssociatedParts = _product.AssociatedParts;
            _inventory.addProduct(product);
            Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox7.Text.Length > 0)
            {

                try
                {
                    int searchID = int.Parse(textBox7.Text);

                    try
                    {
                        Part foundPart = _product.lookupAssociatedPart(searchID);
                        if (foundPart.Name == null)
                        {
                            throw new ArgumentException("Part ID");
                        }
                        var filteredList = new BindingList<Part> { foundPart };

                        // Update the BindingSource DataSource with the filtered list
                        associatedGridView.DataSource = filteredList;
                    }
                    catch
                    {
                        MessageBox.Show($"Error: No Matching Part ID Found.", "Error", MessageBoxButtons.OK);
                    }
                }
                catch
                {
                    MessageBox.Show($"Please enter a Part ID to query for.", "Error", MessageBoxButtons.OK);
                }

            }
            else
            {
                associatedGridView.DataSource = _product.AssociatedParts;
            }
        }
    }
}
