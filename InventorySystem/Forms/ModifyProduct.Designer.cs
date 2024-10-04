namespace InventorySystem
{
    partial class ModifyProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            saveButton = new Button();
            button2 = new Button();
            partGridView = new DataGridView();
            associatedGridView = new DataGridView();
            addPart = new Button();
            textBox7 = new TextBox();
            button4 = new Button();
            deletePartButton = new Button();
            ((System.ComponentModel.ISupportInitialize)partGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)associatedGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 22);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 0;
            label1.Text = "Modify Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 99);
            label2.Name = "label2";
            label2.Size = new Size(25, 21);
            label2.TabIndex = 3;
            label2.Text = "ID";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(140, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 23);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 134);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 5;
            label3.Text = "Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(140, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 23);
            textBox2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(45, 171);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 7;
            label4.Text = "Inventory";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(140, 173);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(140, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(140, 211);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(140, 23);
            textBox4.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(45, 211);
            label5.Name = "label5";
            label5.Size = new Size(89, 21);
            label5.TabIndex = 10;
            label5.Text = "Price / Cost";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(109, 261);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(69, 23);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(241, 261);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(69, 23);
            textBox6.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(196, 261);
            label6.Name = "label6";
            label6.Size = new Size(39, 21);
            label6.TabIndex = 13;
            label6.Text = "Max";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(45, 259);
            label7.Name = "label7";
            label7.Size = new Size(37, 21);
            label7.TabIndex = 14;
            label7.Text = "Min";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(936, 493);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(53, 33);
            saveButton.TabIndex = 17;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(1011, 493);
            button2.Name = "button2";
            button2.Size = new Size(53, 33);
            button2.TabIndex = 18;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // partGridView
            // 
            partGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            partGridView.Location = new Point(588, 64);
            partGridView.Name = "partGridView";
            partGridView.Size = new Size(493, 151);
            partGridView.TabIndex = 19;
            // 
            // associatedGridView
            // 
            associatedGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            associatedGridView.Location = new Point(586, 274);
            associatedGridView.Name = "associatedGridView";
            associatedGridView.Size = new Size(495, 155);
            associatedGridView.TabIndex = 20;
            // 
            // addPart
            // 
            addPart.Location = new Point(1023, 234);
            addPart.Name = "addPart";
            addPart.Size = new Size(58, 23);
            addPart.TabIndex = 21;
            addPart.Text = "Add";
            addPart.UseVisualStyleBackColor = true;
            addPart.Click += addPart_Click_1;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(948, 27);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(133, 23);
            textBox7.TabIndex = 22;
            // 
            // button4
            // 
            button4.Location = new Point(884, 27);
            button4.Name = "button4";
            button4.Size = new Size(58, 23);
            button4.TabIndex = 23;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // deletePartButton
            // 
            deletePartButton.Location = new Point(1023, 451);
            deletePartButton.Name = "deletePartButton";
            deletePartButton.Size = new Size(58, 23);
            deletePartButton.TabIndex = 25;
            deletePartButton.Text = "Delete";
            deletePartButton.UseVisualStyleBackColor = true;
            deletePartButton.Click += deletePartButton_Click_1;
            // 
            // ModifyProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 538);
            Controls.Add(deletePartButton);
            Controls.Add(button4);
            Controls.Add(textBox7);
            Controls.Add(addPart);
            Controls.Add(associatedGridView);
            Controls.Add(partGridView);
            Controls.Add(button2);
            Controls.Add(saveButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ModifyProduct";
            Text = "Product";
            ((System.ComponentModel.ISupportInitialize)partGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)associatedGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label6;
        private Label label7;
        private Button saveButton;
        private Button button2;
        private DataGridView partGridView;
        private DataGridView associatedGridView;
        private Button addPart;
        private TextBox textBox7;
        private Button button4;
        private Button deletePartButton;
    }
}