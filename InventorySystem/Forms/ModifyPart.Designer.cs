namespace InventorySystem
{
    partial class ModifyPart
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label2 = new Label();
            idTextBox = new TextBox();
            label3 = new Label();
            nameTextBox = new TextBox();
            label4 = new Label();
            inventoryTextBox = new TextBox();
            priceTextBox = new TextBox();
            label5 = new Label();
            minTextBox = new TextBox();
            maxTextBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            machineOrCompanyTextBox = new TextBox();
            dynamicPartLabel = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(153, 19);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 0;
            label1.Text = "Modify Part";
            label1.Click += label1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(77, 50);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(74, 19);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "In-House";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(241, 50);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(87, 19);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Outsourced";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(109, 99);
            label2.Name = "label2";
            label2.Size = new Size(25, 21);
            label2.TabIndex = 3;
            label2.Text = "ID";
            // 
            // idTextBox
            // 
            idTextBox.Enabled = false;
            idTextBox.Location = new Point(140, 99);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(140, 23);
            idTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(82, 136);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 5;
            label3.Text = "Name";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(140, 136);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(140, 23);
            nameTextBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(58, 171);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 7;
            label4.Text = "Inventory";
            // 
            // inventoryTextBox
            // 
            inventoryTextBox.Location = new Point(140, 173);
            inventoryTextBox.Name = "inventoryTextBox";
            inventoryTextBox.Size = new Size(140, 23);
            inventoryTextBox.TabIndex = 8;
            inventoryTextBox.TextChanged += textBox3_TextChanged;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(140, 211);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(140, 23);
            priceTextBox.TabIndex = 9;
            priceTextBox.TextChanged += textBox4_TextChanged;
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
            // minTextBox
            // 
            minTextBox.Location = new Point(109, 261);
            minTextBox.Name = "minTextBox";
            minTextBox.Size = new Size(69, 23);
            minTextBox.TabIndex = 11;
            // 
            // maxTextBox
            // 
            maxTextBox.Location = new Point(241, 261);
            maxTextBox.Name = "maxTextBox";
            maxTextBox.Size = new Size(69, 23);
            maxTextBox.TabIndex = 12;
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
            label7.Location = new Point(64, 261);
            label7.Name = "label7";
            label7.Size = new Size(37, 21);
            label7.TabIndex = 14;
            label7.Text = "Min";
            // 
            // machineOrCompanyTextBox
            // 
            machineOrCompanyTextBox.Location = new Point(226, 312);
            machineOrCompanyTextBox.Name = "machineOrCompanyTextBox";
            machineOrCompanyTextBox.Size = new Size(140, 23);
            machineOrCompanyTextBox.TabIndex = 15;
            // 
            // dynamicPartLabel
            // 
            dynamicPartLabel.AutoSize = true;
            dynamicPartLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dynamicPartLabel.Location = new Point(45, 314);
            dynamicPartLabel.Name = "dynamicPartLabel";
            dynamicPartLabel.Size = new Size(88, 21);
            dynamicPartLabel.TabIndex = 16;
            dynamicPartLabel.Text = "Machine ID";
            // 
            // button1
            // 
            button1.Location = new Point(241, 361);
            button1.Name = "button1";
            button1.Size = new Size(53, 33);
            button1.TabIndex = 17;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(313, 361);
            button2.Name = "button2";
            button2.Size = new Size(53, 33);
            button2.TabIndex = 18;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ModifyPart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 416);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dynamicPartLabel);
            Controls.Add(machineOrCompanyTextBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(maxTextBox);
            Controls.Add(minTextBox);
            Controls.Add(label5);
            Controls.Add(priceTextBox);
            Controls.Add(inventoryTextBox);
            Controls.Add(label4);
            Controls.Add(nameTextBox);
            Controls.Add(label3);
            Controls.Add(idTextBox);
            Controls.Add(label2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Name = "ModifyPart";
            Text = "Part";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label2;
        private TextBox idTextBox;
        private Label label3;
        private TextBox nameTextBox;
        private Label label4;
        private TextBox inventoryTextBox;
        private TextBox priceTextBox;
        private Label label5;
        private TextBox minTextBox;
        private TextBox maxTextBox;
        private Label label6;
        private Label label7;
        private TextBox machineOrCompanyTextBox;
        private Label dynamicPartLabel;
        private Button button1;
        private Button button2;
    }
}