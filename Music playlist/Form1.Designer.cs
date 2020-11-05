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
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.lblDiscountPrice = new System.Windows.Forms.Label();
            this.cbProductType = new System.Windows.Forms.ComboBox();
            this.tbDiscount = new System.Windows.Forms.TextBox();
            this.chbAddToDiscounted = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chbAddToCommonList = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chbAddToShoppingList = new System.Windows.Forms.CheckBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNameAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRemoveProduct = new System.Windows.Forms.Label();
            this.tbNameRemove = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSelectCommon = new System.Windows.Forms.Button();
            this.lbCommonProducts = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lbShownProducts = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbView = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbRemoveFromDiscounted = new System.Windows.Forms.RadioButton();
            this.rbRemoveFromShoppingList = new System.Windows.Forms.RadioButton();
            this.rbRemoveFromCommon = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(138)))), ((int)(((byte)(178)))));
            this.label1.Location = new System.Drawing.Point(628, -5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(334, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digital shopping list";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.nudPrice);
            this.panel1.Controls.Add(this.lblDiscountPrice);
            this.panel1.Controls.Add(this.cbProductType);
            this.panel1.Controls.Add(this.tbDiscount);
            this.panel1.Controls.Add(this.chbAddToDiscounted);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.chbAddToCommonList);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.chbAddToShoppingList);
            this.panel1.Controls.Add(this.lblAmount);
            this.panel1.Controls.Add(this.nudAmount);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbNameAdd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(40, 82);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 445);
            this.panel1.TabIndex = 1;
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudPrice.Location = new System.Drawing.Point(136, 132);
            this.nudPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(120, 26);
            this.nudPrice.TabIndex = 20;
            // 
            // lblDiscountPrice
            // 
            this.lblDiscountPrice.AutoSize = true;
            this.lblDiscountPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountPrice.Location = new System.Drawing.Point(54, 362);
            this.lblDiscountPrice.Name = "lblDiscountPrice";
            this.lblDiscountPrice.Size = new System.Drawing.Size(158, 20);
            this.lblDiscountPrice.TabIndex = 19;
            this.lblDiscountPrice.Text = "Discounted price:";
            // 
            // cbProductType
            // 
            this.cbProductType.FormattingEnabled = true;
            this.cbProductType.Items.AddRange(new object[] {
            "fruit",
            "vegetable",
            "meat",
            "dairy",
            "other"});
            this.cbProductType.Location = new System.Drawing.Point(188, 186);
            this.cbProductType.Name = "cbProductType";
            this.cbProductType.Size = new System.Drawing.Size(121, 28);
            this.cbProductType.TabIndex = 18;
            // 
            // tbDiscount
            // 
            this.tbDiscount.Location = new System.Drawing.Point(59, 390);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.ReadOnly = true;
            this.tbDiscount.Size = new System.Drawing.Size(112, 26);
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
            this.lblAmount.Location = new System.Drawing.Point(293, 237);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(84, 20);
            this.lblAmount.TabIndex = 12;
            this.lblAmount.Text = "Amount: ";
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(297, 267);
            this.nudAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(80, 26);
            this.nudAmount.TabIndex = 10;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(138)))), ((int)(((byte)(178)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(393, 378);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 38);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
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
            // tbNameAdd
            // 
            this.tbNameAdd.Location = new System.Drawing.Point(132, 81);
            this.tbNameAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNameAdd.Name = "tbNameAdd";
            this.tbNameAdd.Size = new System.Drawing.Size(245, 26);
            this.tbNameAdd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(53, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add a product";
            // 
            // lblRemoveProduct
            // 
            this.lblRemoveProduct.AutoSize = true;
            this.lblRemoveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveProduct.Location = new System.Drawing.Point(54, 159);
            this.lblRemoveProduct.Name = "lblRemoveProduct";
            this.lblRemoveProduct.Size = new System.Drawing.Size(75, 20);
            this.lblRemoveProduct.TabIndex = 7;
            this.lblRemoveProduct.Text = "Name:  ";
            // 
            // tbNameRemove
            // 
            this.tbNameRemove.Location = new System.Drawing.Point(128, 159);
            this.tbNameRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNameRemove.Name = "tbNameRemove";
            this.tbNameRemove.Size = new System.Drawing.Size(249, 26);
            this.tbNameRemove.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnSelectCommon);
            this.panel2.Controls.Add(this.lbCommonProducts);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbType);
            this.panel2.Controls.Add(this.lbShownProducts);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbView);
            this.panel2.Location = new System.Drawing.Point(628, 82);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 686);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDiscount);
            this.groupBox1.Controls.Add(this.lblTotalPrice);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(62, 535);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 109);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(28, 69);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(223, 20);
            this.lblDiscount.TabIndex = 5;
            this.lblDiscount.Text = "Total($0) - discount($0) = $0";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(138)))), ((int)(((byte)(178)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(318, 32);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(41, 29);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "$0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label13.Location = new System.Drawing.Point(28, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(342, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "The products in your shopping list will cost:  ";
            // 
            // btnSelectCommon
            // 
            this.btnSelectCommon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(138)))), ((int)(((byte)(178)))));
            this.btnSelectCommon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectCommon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelectCommon.Location = new System.Drawing.Point(543, 463);
            this.btnSelectCommon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectCommon.Name = "btnSelectCommon";
            this.btnSelectCommon.Size = new System.Drawing.Size(238, 54);
            this.btnSelectCommon.TabIndex = 9;
            this.btnSelectCommon.Text = "Select";
            this.btnSelectCommon.UseVisualStyleBackColor = false;
            this.btnSelectCommon.Click += new System.EventHandler(this.btnSelectCommon_Click);
            // 
            // lbCommonProducts
            // 
            this.lbCommonProducts.BackColor = System.Drawing.Color.AliceBlue;
            this.lbCommonProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCommonProducts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbCommonProducts.FormattingEnabled = true;
            this.lbCommonProducts.ItemHeight = 25;
            this.lbCommonProducts.Location = new System.Drawing.Point(543, 190);
            this.lbCommonProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbCommonProducts.Name = "lbCommonProducts";
            this.lbCommonProducts.Size = new System.Drawing.Size(238, 254);
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
            "dairy",
            "other"});
            this.cbType.Location = new System.Drawing.Point(288, 137);
            this.cbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(168, 28);
            this.cbType.TabIndex = 4;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
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
            this.label5.Location = new System.Drawing.Point(56, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 36);
            this.label5.TabIndex = 1;
            this.label5.Text = "My Shopping list";
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
            this.label6.Location = new System.Drawing.Point(47, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 36);
            this.label6.TabIndex = 8;
            this.label6.Text = "Remove a product";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.rbRemoveFromDiscounted);
            this.panel3.Controls.Add(this.rbRemoveFromShoppingList);
            this.panel3.Controls.Add(this.rbRemoveFromCommon);
            this.panel3.Controls.Add(this.label10);
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
            // rbRemoveFromDiscounted
            // 
            this.rbRemoveFromDiscounted.AutoSize = true;
            this.rbRemoveFromDiscounted.Location = new System.Drawing.Point(126, 109);
            this.rbRemoveFromDiscounted.Name = "rbRemoveFromDiscounted";
            this.rbRemoveFromDiscounted.Size = new System.Drawing.Size(115, 24);
            this.rbRemoveFromDiscounted.TabIndex = 22;
            this.rbRemoveFromDiscounted.TabStop = true;
            this.rbRemoveFromDiscounted.Text = "Discounted";
            this.rbRemoveFromDiscounted.UseVisualStyleBackColor = true;
            // 
            // rbRemoveFromShoppingList
            // 
            this.rbRemoveFromShoppingList.AutoSize = true;
            this.rbRemoveFromShoppingList.Location = new System.Drawing.Point(126, 81);
            this.rbRemoveFromShoppingList.Name = "rbRemoveFromShoppingList";
            this.rbRemoveFromShoppingList.Size = new System.Drawing.Size(126, 24);
            this.rbRemoveFromShoppingList.TabIndex = 21;
            this.rbRemoveFromShoppingList.TabStop = true;
            this.rbRemoveFromShoppingList.Text = "Shopping list";
            this.rbRemoveFromShoppingList.UseVisualStyleBackColor = true;
            // 
            // rbRemoveFromCommon
            // 
            this.rbRemoveFromCommon.AutoSize = true;
            this.rbRemoveFromCommon.Location = new System.Drawing.Point(258, 81);
            this.rbRemoveFromCommon.Name = "rbRemoveFromCommon";
            this.rbRemoveFromCommon.Size = new System.Drawing.Size(124, 24);
            this.rbRemoveFromCommon.TabIndex = 20;
            this.rbRemoveFromCommon.TabStop = true;
            this.rbRemoveFromCommon.Text = "Common list";
            this.rbRemoveFromCommon.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(55, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "From:";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemove.Location = new System.Drawing.Point(393, 151);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(121, 40);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.CheckBox chbAddToCommonList;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbDiscount;
        private System.Windows.Forms.CheckBox chbAddToDiscounted;
        private System.Windows.Forms.RadioButton rbRemoveFromDiscounted;
        private System.Windows.Forms.RadioButton rbRemoveFromShoppingList;
        private System.Windows.Forms.RadioButton rbRemoveFromCommon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbProductType;
        private System.Windows.Forms.Label lblDiscountPrice;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label lblDiscount;
    }
}

