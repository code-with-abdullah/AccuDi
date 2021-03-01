namespace UPVC_Inventory
{
    partial class InventoryForm
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
            this.VendorCB = new System.Windows.Forms.ComboBox();
            this.CategoryCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddInventoryBTN = new System.Windows.Forms.Button();
            this.ItemCB = new System.Windows.Forms.ComboBox();
            this.ItemsGB = new System.Windows.Forms.GroupBox();
            this.DisplayInventoriesDGV = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.StoreCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SerialNoTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.QuantityTB = new System.Windows.Forms.NumericUpDown();
            this.ExpiryDateDTP = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PurchasePriceNUD = new System.Windows.Forms.NumericUpDown();
            this.SalePriceNUD = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.ItemsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayInventoriesDGV)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchasePriceNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalePriceNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // VendorCB
            // 
            this.VendorCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VendorCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.VendorCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.VendorCB.BackColor = System.Drawing.SystemColors.Control;
            this.VendorCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VendorCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VendorCB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.VendorCB.FormattingEnabled = true;
            this.VendorCB.Location = new System.Drawing.Point(655, 15);
            this.VendorCB.Name = "VendorCB";
            this.VendorCB.Size = new System.Drawing.Size(348, 36);
            this.VendorCB.TabIndex = 2;
            // 
            // CategoryCB
            // 
            this.CategoryCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CategoryCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CategoryCB.BackColor = System.Drawing.SystemColors.Control;
            this.CategoryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryCB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.CategoryCB.FormattingEnabled = true;
            this.CategoryCB.Location = new System.Drawing.Point(153, 15);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.Size = new System.Drawing.Size(346, 36);
            this.CategoryCB.TabIndex = 1;
            this.CategoryCB.SelectedIndexChanged += new System.EventHandler(this.CategoryCB_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.label4.Location = new System.Drawing.Point(505, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 67);
            this.label4.TabIndex = 14;
            this.label4.Text = "Quantity";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.label3.Location = new System.Drawing.Point(3, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 67);
            this.label3.TabIndex = 12;
            this.label3.Text = "Item";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.label2.Location = new System.Drawing.Point(505, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 67);
            this.label2.TabIndex = 10;
            this.label2.Text = "Vendor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 67);
            this.label1.TabIndex = 8;
            this.label1.Text = "Category";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddInventoryBTN
            // 
            this.AddInventoryBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AddInventoryBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.AddInventoryBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddInventoryBTN.FlatAppearance.BorderSize = 0;
            this.AddInventoryBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddInventoryBTN.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.AddInventoryBTN.ForeColor = System.Drawing.Color.White;
            this.AddInventoryBTN.Location = new System.Drawing.Point(655, 279);
            this.AddInventoryBTN.Name = "AddInventoryBTN";
            this.AddInventoryBTN.Size = new System.Drawing.Size(348, 45);
            this.AddInventoryBTN.TabIndex = 10;
            this.AddInventoryBTN.Text = "Add inventory";
            this.AddInventoryBTN.UseVisualStyleBackColor = false;
            this.AddInventoryBTN.Click += new System.EventHandler(this.AddInventoryBTN_Click);
            // 
            // ItemCB
            // 
            this.ItemCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ItemCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ItemCB.BackColor = System.Drawing.SystemColors.Control;
            this.ItemCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemCB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.ItemCB.FormattingEnabled = true;
            this.ItemCB.Location = new System.Drawing.Point(153, 82);
            this.ItemCB.Name = "ItemCB";
            this.ItemCB.Size = new System.Drawing.Size(346, 36);
            this.ItemCB.TabIndex = 3;
            // 
            // ItemsGB
            // 
            this.ItemsGB.Controls.Add(this.DisplayInventoriesDGV);
            this.ItemsGB.Location = new System.Drawing.Point(505, 271);
            this.ItemsGB.Name = "ItemsGB";
            this.ItemsGB.Size = new System.Drawing.Size(144, 61);
            this.ItemsGB.TabIndex = 27;
            this.ItemsGB.TabStop = false;
            this.ItemsGB.Text = "Added inventories";
            this.ItemsGB.Visible = false;
            // 
            // DisplayInventoriesDGV
            // 
            this.DisplayInventoriesDGV.AllowUserToAddRows = false;
            this.DisplayInventoriesDGV.AllowUserToDeleteRows = false;
            this.DisplayInventoriesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DisplayInventoriesDGV.BackgroundColor = System.Drawing.Color.White;
            this.DisplayInventoriesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayInventoriesDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayInventoriesDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.DisplayInventoriesDGV.Location = new System.Drawing.Point(3, 25);
            this.DisplayInventoriesDGV.Name = "DisplayInventoriesDGV";
            this.DisplayInventoriesDGV.Size = new System.Drawing.Size(138, 33);
            this.DisplayInventoriesDGV.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ItemCB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.VendorCB, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.CategoryCB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.StoreCB, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.SerialNoTB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.AddInventoryBTN, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.QuantityTB, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.ItemsGB, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.ExpiryDateDTP, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.PurchasePriceNUD, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.SalePriceNUD, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1006, 563);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // StoreCB
            // 
            this.StoreCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StoreCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.StoreCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.StoreCB.BackColor = System.Drawing.SystemColors.Control;
            this.StoreCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StoreCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StoreCB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.StoreCB.FormattingEnabled = true;
            this.StoreCB.Location = new System.Drawing.Point(655, 82);
            this.StoreCB.Name = "StoreCB";
            this.StoreCB.Size = new System.Drawing.Size(348, 36);
            this.StoreCB.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.label5.Location = new System.Drawing.Point(505, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 67);
            this.label5.TabIndex = 29;
            this.label5.Text = "Warehouse";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SerialNoTB
            // 
            this.SerialNoTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SerialNoTB.BackColor = System.Drawing.SystemColors.Control;
            this.SerialNoTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SerialNoTB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.SerialNoTB.Location = new System.Drawing.Point(153, 154);
            this.SerialNoTB.Name = "SerialNoTB";
            this.SerialNoTB.Size = new System.Drawing.Size(346, 27);
            this.SerialNoTB.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.label6.Location = new System.Drawing.Point(3, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 67);
            this.label6.TabIndex = 31;
            this.label6.Text = "Serial No";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuantityTB
            // 
            this.QuantityTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.QuantityTB.BackColor = System.Drawing.SystemColors.Control;
            this.QuantityTB.DecimalPlaces = 4;
            this.QuantityTB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTB.Location = new System.Drawing.Point(655, 150);
            this.QuantityTB.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.QuantityTB.Name = "QuantityTB";
            this.QuantityTB.Size = new System.Drawing.Size(348, 34);
            this.QuantityTB.TabIndex = 6;
            // 
            // ExpiryDateDTP
            // 
            this.ExpiryDateDTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpiryDateDTP.CalendarFont = new System.Drawing.Font("Segoe UI", 15F);
            this.ExpiryDateDTP.CalendarForeColor = System.Drawing.Color.Coral;
            this.ExpiryDateDTP.Location = new System.Drawing.Point(153, 287);
            this.ExpiryDateDTP.Name = "ExpiryDateDTP";
            this.ExpiryDateDTP.Size = new System.Drawing.Size(346, 29);
            this.ExpiryDateDTP.TabIndex = 9;
            this.ExpiryDateDTP.Value = new System.DateTime(2021, 2, 13, 12, 20, 19, 0);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.label7.Location = new System.Drawing.Point(3, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 67);
            this.label7.TabIndex = 32;
            this.label7.Text = "Expiry date";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.label8.Location = new System.Drawing.Point(3, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 67);
            this.label8.TabIndex = 33;
            this.label8.Text = "Purchase price";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PurchasePriceNUD
            // 
            this.PurchasePriceNUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PurchasePriceNUD.BackColor = System.Drawing.SystemColors.Control;
            this.PurchasePriceNUD.DecimalPlaces = 4;
            this.PurchasePriceNUD.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchasePriceNUD.Location = new System.Drawing.Point(153, 217);
            this.PurchasePriceNUD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.PurchasePriceNUD.Name = "PurchasePriceNUD";
            this.PurchasePriceNUD.Size = new System.Drawing.Size(346, 34);
            this.PurchasePriceNUD.TabIndex = 7;
            // 
            // SalePriceNUD
            // 
            this.SalePriceNUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SalePriceNUD.BackColor = System.Drawing.SystemColors.Control;
            this.SalePriceNUD.DecimalPlaces = 4;
            this.SalePriceNUD.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalePriceNUD.Location = new System.Drawing.Point(655, 217);
            this.SalePriceNUD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.SalePriceNUD.Name = "SalePriceNUD";
            this.SalePriceNUD.Size = new System.Drawing.Size(348, 34);
            this.SalePriceNUD.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.label9.Location = new System.Drawing.Point(505, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 67);
            this.label9.TabIndex = 36;
            this.label9.Text = "Sale price";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 563);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryForm";
            this.ItemsGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayInventoriesDGV)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchasePriceNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalePriceNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox VendorCB;
        private System.Windows.Forms.ComboBox CategoryCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddInventoryBTN;
        private System.Windows.Forms.ComboBox ItemCB;
        private System.Windows.Forms.GroupBox ItemsGB;
        private System.Windows.Forms.DataGridView DisplayInventoriesDGV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox StoreCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SerialNoTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ExpiryDateDTP;
        private System.Windows.Forms.NumericUpDown QuantityTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown PurchasePriceNUD;
        private System.Windows.Forms.NumericUpDown SalePriceNUD;
        private System.Windows.Forms.Label label9;
    }
}