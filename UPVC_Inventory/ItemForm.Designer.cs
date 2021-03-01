namespace UPVC_Inventory
{
    partial class ItemForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.CodeTB = new System.Windows.Forms.TextBox();
            this.CategoryCB = new System.Windows.Forms.ComboBox();
            this.AddItemCategoryBTN = new System.Windows.Forms.Label();
            this.ItemsGB = new System.Windows.Forms.GroupBox();
            this.DisplayItemsDGV = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AddItemBTN = new System.Windows.Forms.Button();
            this.SerialNoTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ValueTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LengthTB = new System.Windows.Forms.NumericUpDown();
            this.WidthTB = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VendorCB = new System.Windows.Forms.ComboBox();
            this.AddItemUomBTN = new System.Windows.Forms.Label();
            this.UomCB = new System.Windows.Forms.ComboBox();
            this.tool_tip = new System.Windows.Forms.ToolTip(this.components);
            this.ItemsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayItemsDGV)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LengthTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthTB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(530, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 56);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 56);
            this.label4.TabIndex = 3;
            this.label4.Text = "Item Code";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameTB
            // 
            this.NameTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTB.BackColor = System.Drawing.SystemColors.Control;
            this.NameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.NameTB.Location = new System.Drawing.Point(630, 14);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(373, 27);
            this.NameTB.TabIndex = 2;
            // 
            // CodeTB
            // 
            this.CodeTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CodeTB.BackColor = System.Drawing.SystemColors.Control;
            this.CodeTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CodeTB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.CodeTB.Location = new System.Drawing.Point(103, 70);
            this.CodeTB.Name = "CodeTB";
            this.CodeTB.Size = new System.Drawing.Size(371, 27);
            this.CodeTB.TabIndex = 3;
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
            this.CategoryCB.Location = new System.Drawing.Point(103, 10);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.Size = new System.Drawing.Size(371, 36);
            this.CategoryCB.TabIndex = 1;
            // 
            // AddItemCategoryBTN
            // 
            this.AddItemCategoryBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddItemCategoryBTN.AutoSize = true;
            this.AddItemCategoryBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddItemCategoryBTN.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.AddItemCategoryBTN.Location = new System.Drawing.Point(480, 0);
            this.AddItemCategoryBTN.Name = "AddItemCategoryBTN";
            this.AddItemCategoryBTN.Size = new System.Drawing.Size(44, 56);
            this.AddItemCategoryBTN.TabIndex = 7;
            this.AddItemCategoryBTN.Text = "+";
            this.AddItemCategoryBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddItemCategoryBTN.Click += new System.EventHandler(this.AddItemCategoryBTN_Click);
            // 
            // ItemsGB
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ItemsGB, 5);
            this.ItemsGB.Controls.Add(this.DisplayItemsDGV);
            this.ItemsGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsGB.Location = new System.Drawing.Point(3, 283);
            this.ItemsGB.Name = "ItemsGB";
            this.ItemsGB.Size = new System.Drawing.Size(1000, 277);
            this.ItemsGB.TabIndex = 26;
            this.ItemsGB.TabStop = false;
            this.ItemsGB.Text = "Added items";
            // 
            // DisplayItemsDGV
            // 
            this.DisplayItemsDGV.AllowUserToAddRows = false;
            this.DisplayItemsDGV.AllowUserToDeleteRows = false;
            this.DisplayItemsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DisplayItemsDGV.BackgroundColor = System.Drawing.Color.White;
            this.DisplayItemsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayItemsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayItemsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.DisplayItemsDGV.Location = new System.Drawing.Point(3, 25);
            this.DisplayItemsDGV.Name = "DisplayItemsDGV";
            this.DisplayItemsDGV.Size = new System.Drawing.Size(994, 249);
            this.DisplayItemsDGV.TabIndex = 0;
            this.DisplayItemsDGV.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DisplayItemsDGV_CellEndEdit);
            this.DisplayItemsDGV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DisplayItemsDGV_KeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ItemsGB, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.AddItemBTN, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.NameTB, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CodeTB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.SerialNoTB, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ValueTB, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LengthTB, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.WidthTB, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.VendorCB, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.AddItemCategoryBTN, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.AddItemUomBTN, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.CategoryCB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.UomCB, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1006, 563);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // AddItemBTN
            // 
            this.AddItemBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AddItemBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.AddItemBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddItemBTN.FlatAppearance.BorderSize = 0;
            this.AddItemBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItemBTN.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.AddItemBTN.ForeColor = System.Drawing.Color.White;
            this.AddItemBTN.Location = new System.Drawing.Point(630, 231);
            this.AddItemBTN.Name = "AddItemBTN";
            this.AddItemBTN.Size = new System.Drawing.Size(373, 42);
            this.AddItemBTN.TabIndex = 9;
            this.AddItemBTN.Text = "Add item";
            this.AddItemBTN.UseVisualStyleBackColor = false;
            this.AddItemBTN.Click += new System.EventHandler(this.AddItemBTN_Click);
            // 
            // SerialNoTB
            // 
            this.SerialNoTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SerialNoTB.BackColor = System.Drawing.SystemColors.Control;
            this.SerialNoTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SerialNoTB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.SerialNoTB.Location = new System.Drawing.Point(630, 70);
            this.SerialNoTB.Name = "SerialNoTB";
            this.SerialNoTB.Size = new System.Drawing.Size(373, 27);
            this.SerialNoTB.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(530, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 56);
            this.label5.TabIndex = 4;
            this.label5.Text = "Serial No";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 56);
            this.label6.TabIndex = 27;
            this.label6.Text = "UOM";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tool_tip.SetToolTip(this.label6, "Unit of Measure");
            // 
            // ValueTB
            // 
            this.ValueTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueTB.BackColor = System.Drawing.SystemColors.Control;
            this.ValueTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ValueTB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.ValueTB.Location = new System.Drawing.Point(630, 126);
            this.ValueTB.Name = "ValueTB";
            this.ValueTB.Size = new System.Drawing.Size(373, 27);
            this.ValueTB.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(530, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 56);
            this.label7.TabIndex = 29;
            this.label7.Text = "Value";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tool_tip.SetToolTip(this.label7, "Unit of Measure");
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 56);
            this.label8.TabIndex = 32;
            this.label8.Text = "Length";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LengthTB
            // 
            this.LengthTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LengthTB.BackColor = System.Drawing.SystemColors.Control;
            this.LengthTB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.LengthTB.Location = new System.Drawing.Point(103, 179);
            this.LengthTB.Name = "LengthTB";
            this.LengthTB.Size = new System.Drawing.Size(371, 34);
            this.LengthTB.TabIndex = 7;
            // 
            // WidthTB
            // 
            this.WidthTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WidthTB.BackColor = System.Drawing.SystemColors.Control;
            this.WidthTB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.WidthTB.Location = new System.Drawing.Point(630, 179);
            this.WidthTB.Name = "WidthTB";
            this.WidthTB.Size = new System.Drawing.Size(373, 34);
            this.WidthTB.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(530, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 56);
            this.label9.TabIndex = 33;
            this.label9.Text = "Width";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 56);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vendor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // VendorCB
            // 
            this.VendorCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VendorCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.VendorCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.VendorCB.BackColor = System.Drawing.SystemColors.Control;
            this.VendorCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VendorCB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.VendorCB.FormattingEnabled = true;
            this.VendorCB.Location = new System.Drawing.Point(103, 234);
            this.VendorCB.Name = "VendorCB";
            this.VendorCB.Size = new System.Drawing.Size(371, 36);
            this.VendorCB.TabIndex = 2;
            this.VendorCB.Visible = false;
            // 
            // AddItemUomBTN
            // 
            this.AddItemUomBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddItemUomBTN.AutoSize = true;
            this.AddItemUomBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddItemUomBTN.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.AddItemUomBTN.Location = new System.Drawing.Point(480, 112);
            this.AddItemUomBTN.Name = "AddItemUomBTN";
            this.AddItemUomBTN.Size = new System.Drawing.Size(44, 56);
            this.AddItemUomBTN.TabIndex = 36;
            this.AddItemUomBTN.Text = "+";
            this.AddItemUomBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddItemUomBTN.Click += new System.EventHandler(this.AddItemUomBTN_Click);
            // 
            // UomCB
            // 
            this.UomCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UomCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.UomCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.UomCB.BackColor = System.Drawing.SystemColors.Control;
            this.UomCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UomCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UomCB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.UomCB.FormattingEnabled = true;
            this.UomCB.Location = new System.Drawing.Point(103, 122);
            this.UomCB.Name = "UomCB";
            this.UomCB.Size = new System.Drawing.Size(371, 36);
            this.UomCB.TabIndex = 5;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 563);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ItemsGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayItemsDGV)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LengthTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthTB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox CodeTB;
        private System.Windows.Forms.ComboBox CategoryCB;
        private System.Windows.Forms.Label AddItemCategoryBTN;
        private System.Windows.Forms.GroupBox ItemsGB;
        private System.Windows.Forms.DataGridView DisplayItemsDGV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button AddItemBTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SerialNoTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip tool_tip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ValueTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown LengthTB;
        private System.Windows.Forms.NumericUpDown WidthTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox VendorCB;
        private System.Windows.Forms.Label AddItemUomBTN;
        private System.Windows.Forms.ComboBox UomCB;
    }
}