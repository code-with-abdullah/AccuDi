namespace UPVC_Inventory
{
    partial class ProfileInvoiceForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerCB = new System.Windows.Forms.ComboBox();
            this.ItemsGB = new System.Windows.Forms.GroupBox();
            this.DisplayItemsDGV = new System.Windows.Forms.DataGridView();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Warehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.CategoryCB = new System.Windows.Forms.ComboBox();
            this.QuantityNUD = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TotalAvailableTB = new System.Windows.Forms.TextBox();
            this.ItemCB = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StoreCB = new System.Windows.Forms.ComboBox();
            this.AddToListBTN = new System.Windows.Forms.Button();
            this.GenerateInvoiceBTN = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.TotalPriceTB = new System.Windows.Forms.TextBox();
            this.TotalWeightTB = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InvoiceDateDTP = new System.Windows.Forms.DateTimePicker();
            this.WeightPerKgNUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.ItemsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayItemsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightPerKgNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.23232F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.23232F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.23232F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CustomerCB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ItemsGB, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label13, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.CategoryCB, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.QuantityNUD, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label14, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.TotalAvailableTB, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.ItemCB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.StoreCB, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.AddToListBTN, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.GenerateInvoiceBTN, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.label16, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.TotalPriceTB, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.TotalWeightTB, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.InvoiceDateDTP, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.WeightPerKgNUD, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1006, 563);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerCB
            // 
            this.CustomerCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CustomerCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CustomerCB.BackColor = System.Drawing.SystemColors.Control;
            this.CustomerCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerCB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.CustomerCB.FormattingEnabled = true;
            this.CustomerCB.Location = new System.Drawing.Point(104, 10);
            this.CustomerCB.Name = "CustomerCB";
            this.CustomerCB.Size = new System.Drawing.Size(227, 36);
            this.CustomerCB.TabIndex = 1;
            // 
            // ItemsGB
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ItemsGB, 6);
            this.ItemsGB.Controls.Add(this.DisplayItemsDGV);
            this.ItemsGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsGB.Location = new System.Drawing.Point(3, 171);
            this.ItemsGB.Name = "ItemsGB";
            this.ItemsGB.Size = new System.Drawing.Size(1000, 275);
            this.ItemsGB.TabIndex = 34;
            this.ItemsGB.TabStop = false;
            this.ItemsGB.Text = "Items Added to List";
            // 
            // DisplayItemsDGV
            // 
            this.DisplayItemsDGV.AllowUserToAddRows = false;
            this.DisplayItemsDGV.AllowUserToDeleteRows = false;
            this.DisplayItemsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DisplayItemsDGV.BackgroundColor = System.Drawing.Color.White;
            this.DisplayItemsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayItemsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.Warehouse,
            this.Code,
            this.UnitWeight,
            this.Quantity,
            this.TotalWeight});
            this.DisplayItemsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayItemsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.DisplayItemsDGV.Location = new System.Drawing.Point(3, 25);
            this.DisplayItemsDGV.Name = "DisplayItemsDGV";
            this.DisplayItemsDGV.ReadOnly = true;
            this.DisplayItemsDGV.Size = new System.Drawing.Size(994, 247);
            this.DisplayItemsDGV.TabIndex = 0;
            this.DisplayItemsDGV.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DisplayItemsDGV_CellEndEdit);
            this.DisplayItemsDGV.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DisplayItemsDGV_DataError);
            this.DisplayItemsDGV.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.DisplayItemsDGV_DefaultValuesNeeded);
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Warehouse
            // 
            this.Warehouse.HeaderText = "Warehouse";
            this.Warehouse.Name = "Warehouse";
            this.Warehouse.ReadOnly = true;
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // UnitWeight
            // 
            this.UnitWeight.HeaderText = "Unit Weight";
            this.UnitWeight.Name = "UnitWeight";
            this.UnitWeight.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // TotalWeight
            // 
            this.TotalWeight.HeaderText = "Total Weight";
            this.TotalWeight.Name = "TotalWeight";
            this.TotalWeight.ReadOnly = true;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(337, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 56);
            this.label13.TabIndex = 37;
            this.label13.Text = "Category";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.CategoryCB.Location = new System.Drawing.Point(438, 10);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.Size = new System.Drawing.Size(227, 36);
            this.CategoryCB.TabIndex = 2;
            this.CategoryCB.SelectedIndexChanged += new System.EventHandler(this.CategoryCB_SelectedIndexChanged);
            // 
            // QuantityNUD
            // 
            this.QuantityNUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.QuantityNUD.DecimalPlaces = 4;
            this.QuantityNUD.Location = new System.Drawing.Point(438, 69);
            this.QuantityNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.QuantityNUD.Name = "QuantityNUD";
            this.QuantityNUD.Size = new System.Drawing.Size(227, 29);
            this.QuantityNUD.TabIndex = 5;
            this.QuantityNUD.ValueChanged += new System.EventHandler(this.QuantityNUD_ValueChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(337, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 56);
            this.label11.TabIndex = 35;
            this.label11.Text = "Quantity";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(671, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 56);
            this.label14.TabIndex = 38;
            this.label14.Text = "Total Available";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalAvailableTB
            // 
            this.TotalAvailableTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalAvailableTB.BackColor = System.Drawing.SystemColors.Control;
            this.TotalAvailableTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalAvailableTB.Enabled = false;
            this.TotalAvailableTB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.TotalAvailableTB.Location = new System.Drawing.Point(772, 70);
            this.TotalAvailableTB.Name = "TotalAvailableTB";
            this.TotalAvailableTB.Size = new System.Drawing.Size(231, 27);
            this.TotalAvailableTB.TabIndex = 6;
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
            this.ItemCB.Location = new System.Drawing.Point(104, 66);
            this.ItemCB.Name = "ItemCB";
            this.ItemCB.Size = new System.Drawing.Size(227, 36);
            this.ItemCB.TabIndex = 4;
            this.ItemCB.SelectedIndexChanged += new System.EventHandler(this.ItemCB_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 56);
            this.label12.TabIndex = 36;
            this.label12.Text = "Item";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(671, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 56);
            this.label4.TabIndex = 50;
            this.label4.Text = "Warehouse";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.StoreCB.Location = new System.Drawing.Point(772, 10);
            this.StoreCB.Name = "StoreCB";
            this.StoreCB.Size = new System.Drawing.Size(231, 36);
            this.StoreCB.TabIndex = 3;
            this.StoreCB.SelectedIndexChanged += new System.EventHandler(this.StoreCB_SelectedIndexChanged);
            // 
            // AddToListBTN
            // 
            this.AddToListBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AddToListBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.AddToListBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddToListBTN.FlatAppearance.BorderSize = 0;
            this.AddToListBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToListBTN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AddToListBTN.ForeColor = System.Drawing.Color.White;
            this.AddToListBTN.Location = new System.Drawing.Point(772, 122);
            this.AddToListBTN.Name = "AddToListBTN";
            this.AddToListBTN.Size = new System.Drawing.Size(231, 36);
            this.AddToListBTN.TabIndex = 7;
            this.AddToListBTN.Text = "Add to List";
            this.AddToListBTN.UseVisualStyleBackColor = false;
            this.AddToListBTN.Click += new System.EventHandler(this.AddToListBTN_Click);
            // 
            // GenerateInvoiceBTN
            // 
            this.GenerateInvoiceBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateInvoiceBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.tableLayoutPanel1.SetColumnSpan(this.GenerateInvoiceBTN, 2);
            this.GenerateInvoiceBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenerateInvoiceBTN.FlatAppearance.BorderSize = 0;
            this.GenerateInvoiceBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateInvoiceBTN.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.GenerateInvoiceBTN.ForeColor = System.Drawing.Color.White;
            this.GenerateInvoiceBTN.Location = new System.Drawing.Point(671, 513);
            this.GenerateInvoiceBTN.Name = "GenerateInvoiceBTN";
            this.GenerateInvoiceBTN.Size = new System.Drawing.Size(332, 42);
            this.GenerateInvoiceBTN.TabIndex = 12;
            this.GenerateInvoiceBTN.Text = "Generate Invoice";
            this.GenerateInvoiceBTN.UseVisualStyleBackColor = false;
            this.GenerateInvoiceBTN.Click += new System.EventHandler(this.GenerateInvoiceBTN_Click);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(337, 505);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 58);
            this.label16.TabIndex = 41;
            this.label16.Text = "Total price";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalPriceTB
            // 
            this.TotalPriceTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalPriceTB.BackColor = System.Drawing.SystemColors.Control;
            this.TotalPriceTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalPriceTB.Cursor = System.Windows.Forms.Cursors.No;
            this.TotalPriceTB.Enabled = false;
            this.TotalPriceTB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.TotalPriceTB.Location = new System.Drawing.Point(438, 520);
            this.TotalPriceTB.Name = "TotalPriceTB";
            this.TotalPriceTB.Size = new System.Drawing.Size(227, 27);
            this.TotalPriceTB.TabIndex = 11;
            // 
            // TotalWeightTB
            // 
            this.TotalWeightTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalWeightTB.BackColor = System.Drawing.SystemColors.Control;
            this.TotalWeightTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalWeightTB.Cursor = System.Windows.Forms.Cursors.No;
            this.TotalWeightTB.Enabled = false;
            this.TotalWeightTB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.TotalWeightTB.Location = new System.Drawing.Point(104, 520);
            this.TotalWeightTB.Name = "TotalWeightTB";
            this.TotalWeightTB.Size = new System.Drawing.Size(227, 27);
            this.TotalWeightTB.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 505);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 58);
            this.label15.TabIndex = 39;
            this.label15.Text = "Total weight";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 56);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InvoiceDateDTP
            // 
            this.InvoiceDateDTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InvoiceDateDTP.CalendarFont = new System.Drawing.Font("Segoe UI", 12F);
            this.InvoiceDateDTP.CalendarForeColor = System.Drawing.Color.Coral;
            this.InvoiceDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.InvoiceDateDTP.Location = new System.Drawing.Point(104, 462);
            this.InvoiceDateDTP.Name = "InvoiceDateDTP";
            this.InvoiceDateDTP.Size = new System.Drawing.Size(227, 29);
            this.InvoiceDateDTP.TabIndex = 8;
            this.InvoiceDateDTP.Value = new System.DateTime(2021, 2, 13, 12, 20, 19, 0);
            // 
            // WeightPerKgNUD
            // 
            this.WeightPerKgNUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightPerKgNUD.DecimalPlaces = 4;
            this.WeightPerKgNUD.Location = new System.Drawing.Point(438, 462);
            this.WeightPerKgNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.WeightPerKgNUD.Name = "WeightPerKgNUD";
            this.WeightPerKgNUD.Size = new System.Drawing.Size(227, 29);
            this.WeightPerKgNUD.TabIndex = 9;
            this.WeightPerKgNUD.ValueChanged += new System.EventHandler(this.WeightPerKgNUD_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 56);
            this.label3.TabIndex = 5;
            this.label3.Text = "Weight Price Per KG";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProfileInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 563);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProfileInvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ItemsGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayItemsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightPerKgNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox CustomerCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker InvoiceDateDTP;
        private System.Windows.Forms.GroupBox ItemsGB;
        private System.Windows.Forms.DataGridView DisplayItemsDGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TotalWeightTB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TotalPriceTB;
        private System.Windows.Forms.ComboBox CategoryCB;
        private System.Windows.Forms.TextBox TotalAvailableTB;
        private System.Windows.Forms.ComboBox ItemCB;
        private System.Windows.Forms.NumericUpDown QuantityNUD;
        private System.Windows.Forms.Button AddToListBTN;
        private System.Windows.Forms.Button GenerateInvoiceBTN;
        private System.Windows.Forms.NumericUpDown WeightPerKgNUD;
        private System.Windows.Forms.ComboBox StoreCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Warehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalWeight;
    }
}