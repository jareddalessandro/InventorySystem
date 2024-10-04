using InventorySystem.Models;
using System.ComponentModel;

namespace InventorySystem
{
    public partial class Mainpage : Form
    {
        Inventory inventory = new Inventory();
        public Mainpage()
        {
            InitializeComponent();


            inventory.populateDefaultValues();

            var productDataSource = new BindingSource();
            productDataSource.DataSource = inventory.Products;
            productsGridView.DataSource = productDataSource;

            var partDataSource = new BindingSource();
            partDataSource.DataSource = inventory.AllParts;
            partsGridView.DataSource = partDataSource;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddPart addPartForm = new AddPart(inventory);
            addPartForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (partsGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = partsGridView.SelectedRows[0];
                // Cast the DataBoundItem to a Part object
                Part selectedPart = (Part)selectedRow.DataBoundItem;
                ModifyPart modifyPartForm = new ModifyPart(inventory, selectedPart);
                modifyPartForm.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddProduct addProductForm = new AddProduct();
            addProductForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ModifyProduct modifyProductForm = new ModifyProduct(inventory);
            modifyProductForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (partsGridView.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show($"Are you sure you want to delete the selected Part?", "Confirm Deletion", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Confirm before deleting (optional)
                    foreach (DataGridViewRow row in partsGridView.SelectedRows)
                    {
                        partsGridView.Rows.RemoveAt(row.Index);
                    }
                }
            }
        }

        private void deleteProductsButton_Click(object sender, EventArgs e)
        {
            if (productsGridView.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show($"Are you sure you want to delete the selected Product?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Confirm before deleting (optional)
                    foreach (DataGridViewRow row in productsGridView.SelectedRows)
                    {
                        productsGridView.Rows.RemoveAt(row.Index);
                    }
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Length > 0)
            {

                try
                {
                    int searchID = int.Parse(searchTextBox.Text);

                    try
                    {
                        Part foundPart = inventory.lookupPart(searchID);
                        var filteredList = new BindingList<Part> { foundPart };

                        // Update the BindingSource DataSource with the filtered list
                        partsGridView.DataSource = filteredList;
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
                partsGridView.DataSource = inventory.AllParts;
            }



        }

        private void searchProductButton_Click(object sender, EventArgs e)
        {
            if (searchProductsTextBox.Text.Length > 0)
            {

                try
                {
                    int searchID = int.Parse(searchProductsTextBox.Text);

                    try
                    {
                        Product foundProduct = inventory.lookupProduct(searchID);
                        var filteredList = new BindingList<Product> { foundProduct };

                        // Update the BindingSource DataSource with the filtered list
                        productsGridView.DataSource = filteredList;
                    }
                    catch
                    {
                        MessageBox.Show($"Error: No Matching Product ID Found.", "Error", MessageBoxButtons.OK);
                    }
                }
                catch
                {
                    MessageBox.Show($"Please enter a Product ID to query for.", "Error", MessageBoxButtons.OK);
                }

            }
            else
            {
                productsGridView.DataSource = inventory.Products;
            }
        }
    }
}
