namespace Music_playlist
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbDairy = new System.Windows.Forms.RadioButton();
            this.rbVegetable = new System.Windows.Forms.RadioButton();
            this.rbMeat = new System.Windows.Forms.RadioButton();
            this.rbFruit = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPriceAdd = new System.Windows.Forms.TextBox();
            this.tbNameAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRemoveProduct = new System.Windows.Forms.Label();
            this.tbNameRemove = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lbShownProducts = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbView = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.lblAmount = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(569, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digital shopping list";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.lblAmount);
            this.panel1.Controls.Add(this.nudAmount);
            this.panel1.Controls.Add(this.rbDairy);
            this.panel1.Controls.Add(this.rbVegetable);
            this.panel1.Controls.Add(this.rbMeat);
            this.panel1.Controls.Add(this.rbFruit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbPriceAdd);
            this.panel1.Controls.Add(this.tbNameAdd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(45, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 403);
            this.panel1.TabIndex = 1;
            // 
            // rbDairy
            // 
            this.rbDairy.AutoSize = true;
            this.rbDairy.Location = new System.Drawing.Point(384, 237);
            this.rbDairy.Name = "rbDairy";
            this.rbDairy.Size = new System.Drawing.Size(75, 29);
            this.rbDairy.TabIndex = 9;
            this.rbDairy.TabStop = true;
            this.rbDairy.Text = "dairy";
            this.rbDairy.UseVisualStyleBackColor = true;
            // 
            // rbVegetable
            // 
            this.rbVegetable.AutoSize = true;
            this.rbVegetable.Location = new System.Drawing.Point(148, 237);
            this.rbVegetable.Name = "rbVegetable";
            this.rbVegetable.Size = new System.Drawing.Size(118, 29);
            this.rbVegetable.TabIndex = 8;
            this.rbVegetable.TabStop = true;
            this.rbVegetable.Text = "vegetable";
            this.rbVegetable.UseVisualStyleBackColor = true;
            // 
            // rbMeat
            // 
            this.rbMeat.AutoSize = true;
            this.rbMeat.Location = new System.Drawing.Point(287, 237);
            this.rbMeat.Name = "rbMeat";
            this.rbMeat.Size = new System.Drawing.Size(76, 29);
            this.rbMeat.TabIndex = 7;
            this.rbMeat.TabStop = true;
            this.rbMeat.Text = "meat";
            this.rbMeat.UseVisualStyleBackColor = true;
            // 
            // rbFruit
            // 
            this.rbFruit.AutoSize = true;
            this.rbFruit.Location = new System.Drawing.Point(67, 237);
            this.rbFruit.Name = "rbFruit";
            this.rbFruit.Size = new System.Drawing.Size(64, 29);
            this.rbFruit.TabIndex = 6;
            this.rbFruit.TabStop = true;
            this.rbFruit.Text = "fruit";
            this.rbFruit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(323, 330);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 47);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Price: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name:  ";
            // 
            // tbPriceAdd
            // 
            this.tbPriceAdd.Location = new System.Drawing.Point(148, 168);
            this.tbPriceAdd.Name = "tbPriceAdd";
            this.tbPriceAdd.Size = new System.Drawing.Size(314, 30);
            this.tbPriceAdd.TabIndex = 2;
            // 
            // tbNameAdd
            // 
            this.tbNameAdd.Location = new System.Drawing.Point(148, 101);
            this.tbNameAdd.Name = "tbNameAdd";
            this.tbNameAdd.Size = new System.Drawing.Size(314, 30);
            this.tbNameAdd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(170, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add a product";
            // 
            // lblRemoveProduct
            // 
            this.lblRemoveProduct.AutoSize = true;
            this.lblRemoveProduct.Location = new System.Drawing.Point(35, 86);
            this.lblRemoveProduct.Name = "lblRemoveProduct";
            this.lblRemoveProduct.Size = new System.Drawing.Size(80, 25);
            this.lblRemoveProduct.TabIndex = 7;
            this.lblRemoveProduct.Text = "Name:  ";
            // 
            // tbNameRemove
            // 
            this.tbNameRemove.Location = new System.Drawing.Point(130, 86);
            this.tbNameRemove.Name = "tbNameRemove";
            this.tbNameRemove.Size = new System.Drawing.Size(332, 30);
            this.tbNameRemove.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbType);
            this.panel2.Controls.Add(this.lblTotalPrice);
            this.panel2.Controls.Add(this.lbShownProducts);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbView);
            this.panel2.Location = new System.Drawing.Point(671, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 643);
            this.panel2.TabIndex = 2;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTotalPrice.Location = new System.Drawing.Point(97, 530);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(111, 29);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "Total: $0";
            // 
            // lbShownProducts
            // 
            this.lbShownProducts.BackColor = System.Drawing.Color.AliceBlue;
            this.lbShownProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShownProducts.FormattingEnabled = true;
            this.lbShownProducts.ItemHeight = 29;
            this.lbShownProducts.Location = new System.Drawing.Point(102, 191);
            this.lbShownProducts.Name = "lbShownProducts";
            this.lbShownProducts.Size = new System.Drawing.Size(429, 294);
            this.lbShownProducts.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.Location = new System.Drawing.Point(219, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 36);
            this.label5.TabIndex = 1;
            this.label5.Text = "View products";
            // 
            // cbView
            // 
            this.cbView.FormattingEnabled = true;
            this.cbView.Items.AddRange(new object[] {
            "All products",
            "Commonly purchased",
            "Most expensive",
            "Cheapest"});
            this.cbView.Location = new System.Drawing.Point(102, 125);
            this.cbView.Name = "cbView";
            this.cbView.Size = new System.Drawing.Size(188, 33);
            this.cbView.TabIndex = 0;
            this.cbView.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label6.Location = new System.Drawing.Point(142, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 36);
            this.label6.TabIndex = 8;
            this.label6.Text = "Remove a product";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnRemove);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lblRemoveProduct);
            this.panel3.Controls.Add(this.tbNameRemove);
            this.panel3.Location = new System.Drawing.Point(45, 530);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(558, 215);
            this.panel3.TabIndex = 3;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(326, 136);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(136, 47);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "All types",
            "fruit",
            "vegetable",
            "meat",
            "dairy"});
            this.cbType.Location = new System.Drawing.Point(342, 125);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(188, 33);
            this.cbType.TabIndex = 4;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(337, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Type: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "View: ";
            // 
            // nudAmount
            // 
            this.nudAmount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudAmount.Location = new System.Drawing.Point(159, 295);
            this.nudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(86, 30);
            this.nudAmount.TabIndex = 10;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(62, 297);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(91, 25);
            this.lblAmount.TabIndex = 12;
            this.lblAmount.Text = "Amount: ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(301, 292);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(86, 30);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.TabStop = false;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1776, 879);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Digital shopping list";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPriceAdd;
        private System.Windows.Forms.TextBox tbNameAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lbShownProducts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblRemoveProduct;
        private System.Windows.Forms.TextBox tbNameRemove;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.RadioButton rbDairy;
        private System.Windows.Forms.RadioButton rbVegetable;
        private System.Windows.Forms.RadioButton rbMeat;
        private System.Windows.Forms.RadioButton rbFruit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

