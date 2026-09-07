namespace Café_Ordering_and_Billing_System
{
    partial class Form1
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
            label1 = new Label();
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            numBottledWater = new NumericUpDown();
            numCoffee = new NumericUpDown();
            numIcedTea = new NumericUpDown();
            numSoftDrink = new NumericUpDown();
            chkBottledWater = new CheckBox();
            chkIcedTea = new CheckBox();
            chkCoffee = new CheckBox();
            chkSoftDrink = new CheckBox();
            groupBox2 = new GroupBox();
            numFrenchFries = new NumericUpDown();
            numSpaghetti = new NumericUpDown();
            numChickenSandwich = new NumericUpDown();
            numBurger = new NumericUpDown();
            chkFrenchFries = new CheckBox();
            chkChickenSandwich = new CheckBox();
            chkSpaghetti = new CheckBox();
            chkBurger = new CheckBox();
            panel2 = new Panel();
            btnClear = new Button();
            btnPay = new Button();
            btnCalculate = new Button();
            lblChange = new Label();
            label9 = new Label();
            txtCashPaid = new TextBox();
            label8 = new Label();
            lblTotal = new Label();
            cmbDiscount = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            lblSubtotal = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            txtReceipt = new TextBox();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBottledWater).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCoffee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIcedTea).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoftDrink).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numFrenchFries).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSpaghetti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numChickenSandwich).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBurger).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(223, 18);
            label1.Name = "label1";
            label1.Size = new Size(305, 25);
            label1.TabIndex = 0;
            label1.Text = "Café Ordering and Billing System";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Location = new Point(26, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 304);
            panel1.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(numBottledWater);
            groupBox3.Controls.Add(numCoffee);
            groupBox3.Controls.Add(numIcedTea);
            groupBox3.Controls.Add(numSoftDrink);
            groupBox3.Controls.Add(chkBottledWater);
            groupBox3.Controls.Add(chkIcedTea);
            groupBox3.Controls.Add(chkCoffee);
            groupBox3.Controls.Add(chkSoftDrink);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(3, 153);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(332, 144);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Drinks";
            // 
            // numBottledWater
            // 
            numBottledWater.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numBottledWater.Location = new Point(200, 93);
            numBottledWater.Name = "numBottledWater";
            numBottledWater.Size = new Size(72, 23);
            numBottledWater.TabIndex = 7;
            // 
            // numCoffee
            // 
            numCoffee.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numCoffee.Location = new Point(200, 68);
            numCoffee.Name = "numCoffee";
            numCoffee.Size = new Size(72, 23);
            numCoffee.TabIndex = 6;
            // 
            // numIcedTea
            // 
            numIcedTea.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numIcedTea.Location = new Point(200, 43);
            numIcedTea.Name = "numIcedTea";
            numIcedTea.Size = new Size(72, 23);
            numIcedTea.TabIndex = 5;
            // 
            // numSoftDrink
            // 
            numSoftDrink.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numSoftDrink.Location = new Point(200, 18);
            numSoftDrink.Name = "numSoftDrink";
            numSoftDrink.Size = new Size(72, 23);
            numSoftDrink.TabIndex = 4;
            // 
            // chkBottledWater
            // 
            chkBottledWater.AutoSize = true;
            chkBottledWater.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkBottledWater.Location = new Point(6, 97);
            chkBottledWater.Name = "chkBottledWater";
            chkBottledWater.Size = new Size(98, 19);
            chkBottledWater.TabIndex = 3;
            chkBottledWater.Text = "Bottled Water";
            chkBottledWater.UseVisualStyleBackColor = true;
            // 
            // chkIcedTea
            // 
            chkIcedTea.AutoSize = true;
            chkIcedTea.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkIcedTea.Location = new Point(6, 47);
            chkIcedTea.Name = "chkIcedTea";
            chkIcedTea.Size = new Size(69, 19);
            chkIcedTea.TabIndex = 2;
            chkIcedTea.Text = "Iced Tea";
            chkIcedTea.UseVisualStyleBackColor = true;
            // 
            // chkCoffee
            // 
            chkCoffee.AutoSize = true;
            chkCoffee.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkCoffee.Location = new Point(6, 72);
            chkCoffee.Name = "chkCoffee";
            chkCoffee.Size = new Size(61, 19);
            chkCoffee.TabIndex = 1;
            chkCoffee.Text = "Coffee";
            chkCoffee.UseVisualStyleBackColor = true;
            // 
            // chkSoftDrink
            // 
            chkSoftDrink.AutoSize = true;
            chkSoftDrink.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkSoftDrink.Location = new Point(6, 22);
            chkSoftDrink.Name = "chkSoftDrink";
            chkSoftDrink.Size = new Size(78, 19);
            chkSoftDrink.TabIndex = 0;
            chkSoftDrink.Text = "Soft Drink";
            chkSoftDrink.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numFrenchFries);
            groupBox2.Controls.Add(numSpaghetti);
            groupBox2.Controls.Add(numChickenSandwich);
            groupBox2.Controls.Add(numBurger);
            groupBox2.Controls.Add(chkFrenchFries);
            groupBox2.Controls.Add(chkChickenSandwich);
            groupBox2.Controls.Add(chkSpaghetti);
            groupBox2.Controls.Add(chkBurger);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(332, 144);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Food";
            // 
            // numFrenchFries
            // 
            numFrenchFries.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numFrenchFries.Location = new Point(200, 93);
            numFrenchFries.Name = "numFrenchFries";
            numFrenchFries.Size = new Size(72, 23);
            numFrenchFries.TabIndex = 7;
            // 
            // numSpaghetti
            // 
            numSpaghetti.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numSpaghetti.Location = new Point(200, 68);
            numSpaghetti.Name = "numSpaghetti";
            numSpaghetti.Size = new Size(72, 23);
            numSpaghetti.TabIndex = 6;
            // 
            // numChickenSandwich
            // 
            numChickenSandwich.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numChickenSandwich.Location = new Point(200, 43);
            numChickenSandwich.Name = "numChickenSandwich";
            numChickenSandwich.Size = new Size(72, 23);
            numChickenSandwich.TabIndex = 5;
            // 
            // numBurger
            // 
            numBurger.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numBurger.Location = new Point(200, 18);
            numBurger.Name = "numBurger";
            numBurger.Size = new Size(72, 23);
            numBurger.TabIndex = 4;
            // 
            // chkFrenchFries
            // 
            chkFrenchFries.AutoSize = true;
            chkFrenchFries.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkFrenchFries.Location = new Point(6, 97);
            chkFrenchFries.Name = "chkFrenchFries";
            chkFrenchFries.Size = new Size(89, 19);
            chkFrenchFries.TabIndex = 3;
            chkFrenchFries.Text = "French Fries";
            chkFrenchFries.UseVisualStyleBackColor = true;
            // 
            // chkChickenSandwich
            // 
            chkChickenSandwich.AutoSize = true;
            chkChickenSandwich.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkChickenSandwich.Location = new Point(6, 47);
            chkChickenSandwich.Name = "chkChickenSandwich";
            chkChickenSandwich.Size = new Size(123, 19);
            chkChickenSandwich.TabIndex = 2;
            chkChickenSandwich.Text = "Chicken Sandwich";
            chkChickenSandwich.UseVisualStyleBackColor = true;
            // 
            // chkSpaghetti
            // 
            chkSpaghetti.AutoSize = true;
            chkSpaghetti.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkSpaghetti.Location = new Point(6, 72);
            chkSpaghetti.Name = "chkSpaghetti";
            chkSpaghetti.Size = new Size(76, 19);
            chkSpaghetti.TabIndex = 1;
            chkSpaghetti.Text = "Spaghetti";
            chkSpaghetti.UseVisualStyleBackColor = true;
            // 
            // chkBurger
            // 
            chkBurger.AutoSize = true;
            chkBurger.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkBurger.Location = new Point(6, 22);
            chkBurger.Name = "chkBurger";
            chkBurger.Size = new Size(61, 19);
            chkBurger.TabIndex = 0;
            chkBurger.Text = "Burger";
            chkBurger.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnPay);
            panel2.Controls.Add(btnCalculate);
            panel2.Controls.Add(lblChange);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtCashPaid);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(cmbDiscount);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(lblSubtotal);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(370, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(203, 304);
            panel2.TabIndex = 3;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(20, 267);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(166, 23);
            btnClear.TabIndex = 13;
            btnClear.Text = "New Order / Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(20, 238);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(166, 23);
            btnPay.TabIndex = 12;
            btnPay.Text = "Process Payment";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(20, 209);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(166, 23);
            btnCalculate.TabIndex = 11;
            btnCalculate.Text = "Calculate Total";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Location = new Point(89, 179);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(28, 15);
            lblChange.TabIndex = 10;
            lblChange.Text = "0.00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 179);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 9;
            label9.Text = "Change:";
            // 
            // txtCashPaid
            // 
            txtCashPaid.Location = new Point(89, 139);
            txtCashPaid.Name = "txtCashPaid";
            txtCashPaid.Size = new Size(87, 23);
            txtCashPaid.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 142);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 7;
            label8.Text = "Cash paid:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(89, 104);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(28, 15);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "0.00";
            // 
            // cmbDiscount
            // 
            cmbDiscount.FormattingEnabled = true;
            cmbDiscount.Items.AddRange(new object[] { "0%", "5%", "10%", "20%" });
            cmbDiscount.Location = new Point(89, 59);
            cmbDiscount.Name = "cmbDiscount";
            cmbDiscount.Size = new Size(87, 23);
            cmbDiscount.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 104);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 4;
            label6.Text = "Total:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 62);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 3;
            label5.Text = "Discount:";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(89, 29);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(28, 15);
            lblSubtotal.TabIndex = 2;
            lblSubtotal.Text = "0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 29);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 1;
            label3.Text = "Subtotal:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 0;
            label2.Text = "Billing";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtReceipt);
            panel3.Location = new Point(579, 46);
            panel3.Name = "panel3";
            panel3.Size = new Size(291, 304);
            panel3.TabIndex = 4;
            // 
            // txtReceipt
            // 
            txtReceipt.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReceipt.Location = new Point(3, 3);
            txtReceipt.Multiline = true;
            txtReceipt.Name = "txtReceipt";
            txtReceipt.Size = new Size(285, 301);
            txtReceipt.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 523);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numBottledWater).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCoffee).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIcedTea).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoftDrink).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numFrenchFries).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSpaghetti).EndInit();
            ((System.ComponentModel.ISupportInitialize)numChickenSandwich).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBurger).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private GroupBox groupBox2;
        private NumericUpDown numFrenchFries;
        private NumericUpDown numSpaghetti;
        private NumericUpDown numChickenSandwich;
        private NumericUpDown numBurger;
        private CheckBox chkFrenchFries;
        private CheckBox chkChickenSandwich;
        private CheckBox chkSpaghetti;
        private CheckBox chkBurger;
        private GroupBox groupBox3;
        private NumericUpDown numBottledWater;
        private NumericUpDown numCoffee;
        private NumericUpDown numIcedTea;
        private NumericUpDown numSoftDrink;
        private CheckBox chkBottledWater;
        private CheckBox chkIcedTea;
        private CheckBox chkCoffee;
        private CheckBox chkSoftDrink;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Label lblChange;
        private Label label9;
        private TextBox txtCashPaid;
        private Label label8;
        private Label lblTotal;
        private ComboBox cmbDiscount;
        private Label label6;
        private Label label5;
        private Label lblSubtotal;
        private Button btnClear;
        private Button btnPay;
        private Button btnCalculate;
        private Panel panel3;
        private TextBox txtReceipt;
    }
}
