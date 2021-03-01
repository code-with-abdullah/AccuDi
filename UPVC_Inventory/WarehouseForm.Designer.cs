namespace UPVC_Inventory
{
    partial class WarehouseForm
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
            this.ItemsGB = new System.Windows.Forms.GroupBox();
            this.DisplayStoresDGV = new System.Windows.Forms.DataGridView();
            this.CodeTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.CityTB = new System.Windows.Forms.TextBox();
            this.AreaTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Area = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddItemBTN = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.storeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayStoresDGV)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemsGB
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ItemsGB, 4);
            this.ItemsGB.Controls.Add(this.DisplayStoresDGV);
            this.ItemsGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsGB.Location = new System.Drawing.Point(3, 168);
            this.ItemsGB.Name = "ItemsGB";
            this.ItemsGB.Size = new System.Drawing.Size(958, 383);
            this.ItemsGB.TabIndex = 27;
            this.ItemsGB.TabStop = false;
            this.ItemsGB.Text = "Added stores";
            // 
            // DisplayStoresDGV
            // 
            this.DisplayStoresDGV.AllowUserToAddRows = false;
            this.DisplayStoresDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DisplayStoresDGV.BackgroundColor = System.Drawing.Color.White;
            this.DisplayStoresDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayStoresDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayStoresDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.DisplayStoresDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.DisplayStoresDGV.Location = new System.Drawing.Point(3, 25);
            this.DisplayStoresDGV.Name = "DisplayStoresDGV";
            this.DisplayStoresDGV.Size = new System.Drawing.Size(952, 355);
            this.DisplayStoresDGV.TabIndex = 0;
            this.DisplayStoresDGV.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DisplayStoresDGV_CellEndEdit);
            this.DisplayStoresDGV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DisplayStoresDGV_KeyDown);
            // 
            // CodeTB
            // 
            this.CodeTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CodeTB.BackColor = System.Drawing.SystemColors.Control;
            this.CodeTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CodeTB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.CodeTB.ForeColor = System.Drawing.Color.Black;
            this.CodeTB.Location = new System.Drawing.Point(628, 69);
            this.CodeTB.Name = "CodeTB";
            this.CodeTB.Size = new System.Drawing.Size(333, 27);
            this.CodeTB.TabIndex = 4;
            // 
            // NameTB
            // 
            this.NameTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTB.BackColor = System.Drawing.SystemColors.Control;
            this.NameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.NameTB.ForeColor = System.Drawing.Color.Black;
            this.NameTB.Location = new System.Drawing.Point(147, 14);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(331, 27);
            this.NameTB.TabIndex = 1;
            // 
            // CityTB
            // 
            this.CityTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CityTB.BackColor = System.Drawing.SystemColors.Control;
            this.CityTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CityTB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.CityTB.ForeColor = System.Drawing.Color.Black;
            this.CityTB.Location = new System.Drawing.Point(628, 14);
            this.CityTB.Name = "CityTB";
            this.CityTB.Size = new System.Drawing.Size(333, 27);
            this.CityTB.TabIndex = 2;
            // 
            // AreaTB
            // 
            this.AreaTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AreaTB.BackColor = System.Drawing.SystemColors.Control;
            this.AreaTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AreaTB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.AreaTB.ForeColor = System.Drawing.Color.Black;
            this.AreaTB.Location = new System.Drawing.Point(147, 69);
            this.AreaTB.Name = "AreaTB";
            this.AreaTB.Size = new System.Drawing.Size(331, 27);
            this.AreaTB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label4.Location = new System.Drawing.Point(484, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 55);
            this.label4.TabIndex = 32;
            this.label4.Text = "Code";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Area
            // 
            this.Area.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Area.AutoSize = true;
            this.Area.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.Area.Location = new System.Drawing.Point(3, 55);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(138, 55);
            this.Area.TabIndex = 30;
            this.Area.Text = "Area";
            this.Area.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label2.Location = new System.Drawing.Point(484, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 55);
            this.label2.TabIndex = 29;
            this.label2.Text = "City";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 55);
            this.label1.TabIndex = 28;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.AddItemBTN.Location = new System.Drawing.Point(628, 116);
            this.AddItemBTN.Name = "AddItemBTN";
            this.AddItemBTN.Size = new System.Drawing.Size(333, 42);
            this.AddItemBTN.TabIndex = 5;
            this.AddItemBTN.Text = "Add warehouse";
            this.AddItemBTN.UseVisualStyleBackColor = false;
            this.AddItemBTN.Click += new System.EventHandler(this.AddItemBTN_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.ItemsGB, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.AddItemBTN, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.NameTB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CodeTB, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.AreaTB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CityTB, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Area, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(964, 554);
            this.tableLayoutPanel1.TabIndex = 37;
            // 
            // storeBindingSource
            // 
            this.storeBindingSource.DataMember = "Store";
            // 
            // WarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 554);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WarehouseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StoreForm";
            this.ItemsGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayStoresDGV)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ItemsGB;
        private System.Windows.Forms.DataGridView DisplayStoresDGV;
        private System.Windows.Forms.TextBox CodeTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox CityTB;
        private System.Windows.Forms.TextBox AreaTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Area;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddItemBTN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource storeBindingSource;
    }
}