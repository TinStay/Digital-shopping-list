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
            this.tbDiscount = new System.Windows.Forms.TextBox();
            this.chbAddToDiscounted = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chbAddToCommonList = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chbAddToShoppingList = new System.Windows.Forms.CheckBox();
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
            this.btnSelectCommon = new System.Windows.Forms.Button();
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
            this.chbRemoveFromDiscounted = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chbRemoveFromCommonList = new System.Windows.Forms.CheckBox();
            this.chbRemoveFromShoppingList = new System.Windows.Forms.CheckBox();
            this.btnRemove = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(506, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digital shopping list";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tbDiscount);
            this.panel1.Controls.Add(this.chbAddToDiscounted);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.chbAddToCommonList);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.chbAddToShoppingList);
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
            this.panel1.Location = new System.Drawing.Point(40, 82);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 445);
            this.panel1.TabIndex = 1;
            // 
            // tbDiscount
            // 
            this.tbDiscount.Location = new System.Drawing.Point(181, 322);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.ReadOnly = true;
            this.tbDiscount.Size = new System.Drawing.Size(84, 26);
            this.tbDiscount.TabIndex = 17;
            // 
            // chbAddToDiscounted
            // 
            this.chbAddToDiscounted.AutoSize = true;
            this.chbAddToDiscounted.Location = new System.Drawing.Point(59, 325);
            this.chbAddToDiscounted.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbAddToDiscounted.Name = "chbAddToDiscounted";
            this.chbAddToDiscounted.Size = new System.Drawing.Size(116, 24);
            this.chbAddToDiscounted.TabIndex = 16;
            this.chbAddToDiscounted.Text = "Discounted";
            this.chbAddToDiscounted.UseVisualStyleBackColor = true;
            this.chbAddToDiscounted.CheckedChanged += new System.EventHandler(this.chbAddToDiscounted_CheckedChanged_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(55, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Product type: ";
            // 
            // chbAddToCommonList
            // 
            this.chbAddToCommonList.AutoSize = true;
            this.chbAddToCommonList.Location = new System.Drawing.Point(58, 297);
            this.chbAddToCommonList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbAddToCommonList.Name = "chbAddToCommonList";
            this.chbAddToCommonList.Size = new System.Drawing.Size(193, 24);
            this.chbAddToCommonList.TabIndex = 14;
            this.chbAddToCommonList.Text = "Commonly purchased";
            this.chbAddToCommonList.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(55, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Add to:";
            // 
            // chbAddToShoppingList
            // 
            this.chbAddToShoppingList.AutoSize = true;
            this.chbAddToShoppingList.Location = new System.Drawing.Point(58, 269);
            this.chbAddToShoppingList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbAddToShoppingList.Name = "chbAddToShoppingList";
            this.chbAddToShoppingList.Size = new System.Drawing.Size(127, 24);
            this.chbAddToShoppingList.TabIndex = 13;
            this.chbAddToShoppingList.Text = "Shopping list";
            this.chbAddToShoppingList.UseVisualStyleBackColor = true;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(55, 387);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(84, 20);
            this.lblAmount.TabIndex = 12;
            this.lblAmount.Text = "Amount: ";
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(141, 385);
            this.nudAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(76, 26);
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
            this.rbDairy.Location = new System.Drawing.Point(473, 190);
            this.rbDairy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbDairy.Name = "rbDairy";
            this.rbDairy.Size = new System.Drawing.Size(66, 24);
            this.rbDairy.TabIndex = 9;
            this.rbDairy.TabStop = true;
            this.rbDairy.Text = "dairy";
            this.rbDairy.UseVisualStyleBackColor = true;
            // 
            // rbVegetable
            // 
            this.rbVegetable.AutoSize = true;
            this.rbVegetable.Location = new System.Drawing.Point(264, 190);
            this.rbVegetable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbVegetable.Name = "rbVegetable";
            this.rbVegetable.Size = new System.Drawing.Size(101, 24);
            this.rbVegetable.TabIndex = 8;
            this.rbVegetable.TabStop = true;
            this.rbVegetable.Text = "vegetable";
            this.rbVegetable.UseVisualStyleBackColor = true;
            // 
            // rbMeat
            // 
            this.rbMeat.AutoSize = true;
            this.rbMeat.Location = new System.Drawing.Point(387, 190);
            this.rbMeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMeat.Name = "rbMeat";
            this.rbMeat.Size = new System.Drawing.Size(67, 24);
            this.rbMeat.TabIndex = 7;
            this.rbMeat.TabStop = true;
            this.rbMeat.Text = "meat";
            this.rbMeat.UseVisualStyleBackColor = true;
            // 
            // rbFruit
            // 
            this.rbFruit.AutoSize = true;
            this.rbFruit.Location = new System.Drawing.Point(192, 190);
            this.rbFruit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFruit.Name = "rbFruit";
            this.rbFruit.Size = new System.Drawing.Size(59, 24);
            this.rbFruit.TabIndex = 6;
            this.rbFruit.TabStop = true;
            this.rbFruit.Text = "fruit";
            this.rbFruit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(393, 378);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 38);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Price: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name:  ";
            // 
            // tbPriceAdd
            // 
            this.tbPriceAdd.Location = new System.Drawing.Point(132, 134);
            this.tbPriceAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPriceAdd.Name = "tbPriceAdd";
            this.tbPriceAdd.Size = new System.Drawing.Size(280, 26);
            this.tbPriceAdd.TabIndex = 2;
            // 
            // tbNameAdd
            // 
            this.tbNameAdd.Location = new System.Drawing.Point(132, 81);
            this.tbNameAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNameAdd.Name = "tbNameAdd";
            this.tbNameAdd.Size = new System.Drawing.Size(280, 26);
            this.tbNameAdd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(151, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add a product";
            // 
            // lblRemoveProduct
            // 
            this.lblRemoveProduct.AutoSize = true;
            this.lblRemoveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveProduct.Location = new System.Drawing.Point(43, 159);
            this.lblRemoveProduct.Name = "lblRemoveProduct";
            this.lblRemoveProduct.Size = new System.Drawing.Size(75, 20);
            this.lblRemoveProduct.TabIndex = 7;
            this.lblRemoveProduct.Text = "Name:  ";
            // 
            // tbNameRemove
            // 
            this.tbNameRemove.Location = new System.Drawing.Point(130, 159);
            this.tbNameRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNameRemove.Name = "tbNameRemove";
            this.tbNameRemove.Size = new System.Drawing.Size(249, 26);
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
            this.panel2.Location = new System.Drawing.Point(628, 82);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 686);
            this.panel2.TabIndex = 2;
            // 
            // btnSelectCommon
            // 
            this.btnSelectCommon.Location = new System.Drawing.Point(543, 475);
            this.btnSelectCommon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectCommon.Name = "btnSelectCommon";
            this.btnSelectCommon.Size = new System.Drawing.Size(240, 42);
            this.btnSelectCommon.TabIndex = 9;
            this.btnSelectCommon.Text = "Select";
            this.btnSelectCommon.UseVisualStyleBackColor = true;
            this.btnSelectCommon.Click += new System.EventHandler(this.btnSelectCommon_Click);
            // 
            // lbCommonProducts
            // 
            this.lbCommonProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCommonProducts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbCommonProducts.FormattingEnabled = true;
            this.lbCommonProducts.ItemHeight = 25;
            this.lbCommonProducts.Location = new System.Drawing.Point(543, 190);
            this.lbCommonProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbCommonProducts.Name = "lbCommonProducts";
            this.lbCommonProducts.Size = new System.Drawing.Size(239, 254);
            this.lbCommonProducts.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(538, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(253, 29);
            this.label9.TabIndex = 7;
            this.label9.Text = "Commonly purchased ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(58, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "View: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(284, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Product type: ";
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
            this.cbType.Location = new System.Drawing.Point(288, 137);
            this.cbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(168, 28);
            this.cbType.TabIndex = 4;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTotalPrice.Location = new System.Drawing.Point(57, 561);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(111, 29);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "Total: $0";
            // 
            // lbShownProducts
            // 
            this.lbShownProducts.BackColor = System.Drawing.Color.AliceBlue;
            this.lbShownProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShownProducts.FormattingEnabled = true;
            this.lbShownProducts.ItemHeight = 25;
            this.lbShownProducts.Location = new System.Drawing.Point(62, 190);
            this.lbShownProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbShownProducts.Name = "lbShownProducts";
            this.lbShownProducts.Size = new System.Drawing.Size(394, 329);
            this.lbShownProducts.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.Location = new System.Drawing.Point(270, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 36);
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
            this.cbView.Location = new System.Drawing.Point(62, 137);
            this.cbView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbView.Name = "cbView";
            this.cbView.Size = new System.Drawing.Size(168, 28);
            this.cbView.TabIndex = 0;
            this.cbView.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label6.Location = new System.Drawing.Point(137, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 36);
            this.label6.TabIndex = 8;
            this.label6.Text = "Remove a product";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.chbRemoveFromDiscounted);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.chbRemoveFromCommonList);
            this.panel3.Controls.Add(this.chbRemoveFromShoppingList);
            this.panel3.Controls.Add(this.btnRemove);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lblRemoveProduct);
            this.panel3.Controls.Add(this.tbNameRemove);
            this.panel3.Location = new System.Drawing.Point(40, 547);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(558, 221);
            this.panel3.TabIndex = 3;
            // 
            // chbRemoveFromDiscounted
            // 
            this.chbRemoveFromDiscounted.AutoSize = true;
            this.chbRemoveFromDiscounted.Location = new System.Drawing.Point(387, 68);
            this.chbRemoveFromDiscounted.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbRemoveFromDiscounted.Name = "chbRemoveFromDiscounted";
            this.chbRemoveFromDiscounted.Size = new System.Drawing.Size(116, 24);
            this.chbRemoveFromDiscounted.TabIndex = 19;
            this.chbRemoveFromDiscounted.Text = "Discounted";
            this.chbRemoveFromDiscounted.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(49, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Remove from:";
            // 
            // chbRemoveFromCommonList
            // 
            this.chbRemoveFromCommonList.AutoSize = true;
            this.chbRemoveFromCommonList.Location = new System.Drawing.Point(186, 96);
            this.chbRemoveFromCommonList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbRemoveFromCommonList.Name = "chbRemoveFromCommonList";
            this.chbRemoveFromCommonList.Size = new System.Drawing.Size(193, 24);
            this.chbRemoveFromCommonList.TabIndex = 10;
            this.chbRemoveFromCommonList.Text = "Commonly purchased";
            this.chbRemoveFromCommonList.UseVisualStyleBackColor = true;
            // 
            // chbRemoveFromShoppingList
            // 
            this.chbRemoveFromShoppingList.AutoSize = true;
            this.chbRemoveFromShoppingList.Location = new System.Drawing.Point(186, 68);
            this.chbRemoveFromShoppingList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbRemoveFromShoppingList.Name = "chbRemoveFromShoppingList";
            this.chbRemoveFromShoppingList.Size = new System.Drawing.Size(127, 24);
            this.chbRemoveFromShoppingList.TabIndex = 9;
            this.chbRemoveFromShoppingList.Text = "Shopping list";
            this.chbRemoveFromShoppingList.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(396, 159);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(118, 26);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1902, 786);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.CheckBox chbAddToShoppingList;
        private System.Windows.Forms.ListBox lbCommonProducts;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSelectCommon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chbRemoveFromCommonList;
        private System.Windows.Forms.CheckBox chbRemoveFromShoppingList;
        private System.Windows.Forms.CheckBox chbAddToCommonList;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbDiscount;
        private System.Windows.Forms.CheckBox chbAddToDiscounted;
        private System.Windows.Forms.CheckBox chbRemoveFromDiscounted;
    }
}

