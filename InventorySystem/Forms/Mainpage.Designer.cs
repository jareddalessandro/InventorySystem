namespace InventorySystem
{
    partial class Mainpage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            partsGridView = new DataGridView();
            productsGridView = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            searchButton = new Button();
            searchTextBox = new TextBox();
            button3 = new Button();
            button4 = new Button();
            deleteProductsButton = new Button();
            DeletePartButton = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            ((System.ComponentModel.ISupportInitialize)partsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsGridView).BeginInit();
            SuspendLayout();
            // 
            // partsGridView
            // 
            partsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            partsGridView.Location = new Point(37, 149);
            partsGridView.Name = "partsGridView";
            partsGridView.Size = new Size(638, 275);
            partsGridView.TabIndex = 0;
            // 
            // productsGridView
            // 
            productsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsGridView.Location = new Point(750, 149);
            productsGridView.Name = "productsGridView";
            productsGridView.Size = new Size(641, 275);
            productsGridView.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 9);
            label1.Name = "label1";
            label1.Size = new Size(320, 30);
            label1.TabIndex = 2;
            label1.Text = "Inventory Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 115);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 3;
            label2.Text = "Parts";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(750, 115);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 4;
            label3.Text = "Products";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(1227, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(1161, 113);
            button1.Name = "button1";
            button1.Size = new Size(60, 23);
            button1.TabIndex = 6;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(445, 111);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(60, 23);
            searchButton.TabIndex = 7;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchTextBox.Location = new Point(511, 111);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(164, 23);
            searchTextBox.TabIndex = 8;
            searchTextBox.TextChanged += textBox2_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(1199, 430);
            button3.Name = "button3";
            button3.Size = new Size(60, 23);
            button3.TabIndex = 9;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1265, 430);
            button4.Name = "button4";
            button4.Size = new Size(60, 23);
            button4.TabIndex = 10;
            button4.Text = "Modify";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // deleteProductsButton
            // 
            deleteProductsButton.Location = new Point(1331, 430);
            deleteProductsButton.Name = "deleteProductsButton";
            deleteProductsButton.Size = new Size(60, 23);
            deleteProductsButton.TabIndex = 11;
            deleteProductsButton.Text = "Delete";
            deleteProductsButton.UseVisualStyleBackColor = true;
            deleteProductsButton.Click += deleteProductsButton_Click;
            // 
            // DeletePartButton
            // 
            DeletePartButton.Location = new Point(615, 430);
            DeletePartButton.Name = "DeletePartButton";
            DeletePartButton.Size = new Size(60, 23);
            DeletePartButton.TabIndex = 12;
            DeletePartButton.Text = "Delete";
            DeletePartButton.UseVisualStyleBackColor = true;
            DeletePartButton.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(549, 430);
            button7.Name = "button7";
            button7.Size = new Size(60, 23);
            button7.TabIndex = 13;
            button7.Text = "Modify";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(483, 430);
            button8.Name = "button8";
            button8.Size = new Size(60, 23);
            button8.TabIndex = 14;
            button8.Text = "Add";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(1315, 544);
            button9.Name = "button9";
            button9.Size = new Size(76, 30);
            button9.TabIndex = 15;
            button9.Text = "Exit";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // Mainpage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1415, 604);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(DeletePartButton);
            Controls.Add(deleteProductsButton);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(searchTextBox);
            Controls.Add(searchButton);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(productsGridView);
            Controls.Add(partsGridView);
            Name = "Mainpage";
            Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)partsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView partsGridView;
        private DataGridView productsGridView;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private Button searchButton;
        private TextBox searchTextBox;
        private Button button3;
        private Button button4;
        private Button deleteProductsButton;
        private Button DeletePartButton;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}
