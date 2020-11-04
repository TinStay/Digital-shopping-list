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
            this.chbAddToCommon = new System.Windows.Forms.CheckBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
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
            this.lbCommonProducts = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lbShownProducts = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbView = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSelectCommon = new System.Windows.Forms.Button();
            this.chbRemoveFromShoppingList = new System.Windows.Forms.CheckBox();
            this.chbRemoveFromCommonList = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(569, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digital shopping list";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.chbAddToCommon);
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
            this.panel1.Size = new System.Drawing.Size(558, 462);
            this.panel1.TabIndex = 1;
            // 
            // chbAddToCommon
            // 
            this.chbAddToCommon.AutoSize = true;
            this.chbAddToCommon.Location = new System.Drawing.Point(67, 368);
            this.chbAddToCommon.Name = "chbAddToCommon";
            this.chbAddToCommon.Size = new System.Drawing.Size(206, 24);
            this.chbAddToCommon.TabIndex = 13;
            this.chbAddToCommon.Text = "Add to common products";
            this.chbAddToCommon.UseVisualStyleBackColor = true;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(62, 297);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(73, 20);
            this.lblAmount.TabIndex = 12;
            this.lblAmount.Text = "Amount: ";
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(159, 295);
            this.nudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(86, 26);
            this.nudAmount.TabIndex = 10;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbDairy
            // 
            this.rbDairy.AutoSize = true;
            this.rbDairy.Location = new System.Drawing.Point(384, 237);
            this.rbDairy.Name = "rbDairy";
            this.rbDairy.Size = new System.Drawing.Size(60, 24);
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
            this.rbVegetable.Size = new System.Drawing.Size(96, 24);
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
            this.rbMeat.Size = new System.Drawing.Size(63, 24);
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
            this.rbFruit.Size = new System.Drawing.Size(54, 24);
            this.rbFruit.TabIndex = 6;
            this.rbFruit.TabStop = true;
            this.rbFruit.Text = "fruit";
            this.rbFruit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(384, 368);
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
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Price: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name:  ";
            // 
            // tbPriceAdd
            // 
            this.tbPriceAdd.Location = new System.Drawing.Point(148, 168);
            this.tbPriceAdd.Name = "tbPriceAdd";
            this.tbPriceAdd.Size = new System.Drawing.Size(314, 26);
            this.tbPriceAdd.TabIndex = 2;
            // 
            // tbNameAdd
            // 
            this.tbNameAdd.Location = new System.Drawing.Point(148, 101);
            this.tbNameAdd.Name = "tbNameAdd";
            this.tbNameAdd.Size = new System.Drawing.Size(314, 26);
            this.tbNameAdd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(170, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add a product";
            // 
            // lblRemoveProduct
            // 
            this.lblRemoveProduct.AutoSize = true;
            this.lblRemoveProduct.Location = new System.Drawing.Point(51, 71);
            this.lblRemoveProduct.Name = "lblRemoveProduct";
            this.lblRemoveProduct.Size = new System.Drawing.Size(63, 20);
            this.lblRemoveProduct.TabIndex = 7;
            this.lblRemoveProduct.Text = "Name:  ";
            // 
            // tbNameRemove
            // 
            this.tbNameRemove.Location = new System.Drawing.Point(130, 71);
            this.tbNameRemove.Name = "tbNameRemove";
            this.tbNameRemove.Size = new System.Drawing.Size(332, 26);
            this.tbNameRemove.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnSelectCommon);
            this.panel2.Controls.Add(this.lbCommonProducts);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbType);
            this.panel2.Controls.Add(this.lblTotalPrice);
            this.panel2.Controls.Add(this.lbShownProducts);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbView);
            this.panel2.Location = new System.Drawing.Point(648, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 711);
            this.panel2.TabIndex = 2;
            // 
            // lbCommonProducts
            // 
            this.lbCommonProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbCommonProducts.FormattingEnabled = true;
            this.lbCommonProducts.ItemHeight = 24;
            this.lbCommonProducts.Location = new System.Drawing.Point(546, 123);
            this.lbCommonProducts.Name = "lbCommonProducts";
            this.lbCommonProducts.Size = new System.Drawing.Size(263, 292);
            this.lbCommonProducts.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(564, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(226, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Commonly purchased ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "View: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Type: ";
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
            this.cbType.Location = new System.Drawing.Point(311, 125);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(188, 28);
            this.cbType.TabIndex = 4;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTotalPrice.Location = new System.Drawing.Point(97, 530);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(89, 25);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "Total: $0";
            // 
            // lbShownProducts
            // 
            this.lbShownProducts.BackColor = System.Drawing.Color.AliceBlue;
            this.lbShownProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShownProducts.FormattingEnabled = true;
            this.lbShownProducts.ItemHeight = 24;
            this.lbShownProducts.Location = new System.Drawing.Point(71, 191);
            this.lbShownProducts.Name = "lbShownProducts";
            this.lbShownProducts.Size = new System.Drawing.Size(429, 292);
            this.lbShownProducts.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.Location = new System.Drawing.Point(182, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "View Shopping list";
            // 
            // cbView
            // 
            this.cbView.FormattingEnabled = true;
            this.cbView.Items.AddRange(new object[] {
            "All products",
            "Most expensive",
            "Cheapest",
            "Discounted"});
            this.cbView.Location = new System.Drawing.Point(71, 125);
            this.cbView.Name = "cbView";
            this.cbView.Size = new System.Drawing.Size(188, 28);
            this.cbView.TabIndex = 0;
            this.cbView.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label6.Location = new System.Drawing.Point(154, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Remove a product";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.chbRemoveFromCommonList);
            this.panel3.Controls.Add(this.chbRemoveFromShoppingList);
            this.panel3.Controls.Add(this.btnRemove);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lblRemoveProduct);
            this.panel3.Controls.Add(this.tbNameRemove);
            this.panel3.Location = new System.Drawing.Point(45, 582);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(558, 231);
            this.panel3.TabIndex = 3;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(384, 151);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(136, 47);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSelectCommon
            // 
            this.btnSelectCommon.Location = new System.Drawing.Point(546, 431);
            this.btnSelectCommon.Name = "btnSelectCommon";
            this.btnSelectCommon.Size = new System.Drawing.Size(263, 52);
            this.btnSelectCommon.TabIndex = 9;
            this.btnSelectCommon.Text = "Select";
            this.btnSelectCommon.UseVisualStyleBackColor = true;
            this.btnSelectCommon.Click += new System.EventHandler(this.btnSelectCommon_Click);
            // 
            // chbRemoveFromShoppingList
            // 
            this.chbRemoveFromShoppingList.AutoSize = true;
            this.chbRemoveFromShoppingList.Location = new System.Drawing.Point(160, 114);
            this.chbRemoveFromShoppingList.Name = "chbRemoveFromShoppingList";
            this.chbRemoveFromShoppingList.Size = new System.Drawing.Size(119, 24);
            this.chbRemoveFromShoppingList.TabIndex = 9;
            this.chbRemoveFromShoppingList.Text = "Shopping list";
            this.chbRemoveFromShoppingList.UseVisualStyleBackColor = true;
            // 
            // chbRemoveFromCommonList
            // 
            this.chbRemoveFromCommonList.AutoSize = true;
            this.chbRemoveFromCommonList.Location = new System.Drawing.Point(160, 152);
            this.chbRemoveFromCommonList.Name = "chbRemoveFromCommonList";
            this.chbRemoveFromCommonList.Size = new System.Drawing.Size(181, 24);
            this.chbRemoveFromCommonList.TabIndex = 10;
            this.chbRemoveFromCommonList.Text = "Commonly purchased";
            this.chbRemoveFromCommonList.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Remove from:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1540, 845);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.CheckBox chbAddToCommon;
        private System.Windows.Forms.ListBox lbCommonProducts;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSelectCommon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chbRemoveFromCommonList;
        private System.Windows.Forms.CheckBox chbRemoveFromShoppingList;
    }
}

