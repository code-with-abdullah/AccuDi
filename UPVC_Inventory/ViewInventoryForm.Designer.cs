namespace UPVC_Inventory
{
    partial class ViewInventoryForm
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
            this.InventoriesGB = new System.Windows.Forms.GroupBox();
            this.DisplayInventoriesDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ItemCB = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.InventoriesGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayInventoriesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.InventoriesGB, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CategoryCB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ItemCB, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(990, 547);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // InventoriesGB
            // 
            this.InventoriesGB.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.InventoriesGB, 4);
            this.InventoriesGB.Controls.Add(this.DisplayInventoriesDGV);
            this.InventoriesGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoriesGB.Location = new System.Drawing.Point(3, 57);
            this.InventoriesGB.Name = "InventoriesGB";
            this.InventoriesGB.Size = new System.Drawing.Size(984, 487);
            this.InventoriesGB.TabIndex = 28;
            this.InventoriesGB.TabStop = false;
            this.InventoriesGB.Text = "Added inventories";
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
            this.DisplayInventoriesDGV.ReadOnly = true;
            this.DisplayInventoriesDGV.Size = new System.Drawing.Size(978, 459);
            this.DisplayInventoriesDGV.TabIndex = 0;
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
            this.label1.Size = new System.Drawing.Size(142, 54);
            this.label1.TabIndex = 9;
            this.label1.Text = "Category";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.CategoryCB.Location = new System.Drawing.Point(151, 9);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.Size = new System.Drawing.Size(340, 36);
            this.CategoryCB.TabIndex = 1;
            this.CategoryCB.SelectedIndexChanged += new System.EventHandler(this.CategoryCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.label3.Location = new System.Drawing.Point(497, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 54);
            this.label3.TabIndex = 13;
            this.label3.Text = "Item";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemCB
            // 
            this.ItemCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ItemCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ItemCB.BackColor = System.Drawing.SystemColors.Control;
            this.ItemCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemCB.Enabled = false;
            this.ItemCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemCB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.ItemCB.FormattingEnabled = true;
            this.ItemCB.Location = new System.Drawing.Point(645, 9);
            this.ItemCB.Name = "ItemCB";
            this.ItemCB.Size = new System.Drawing.Size(342, 36);
            this.ItemCB.TabIndex = 2;
            this.ItemCB.SelectedIndexChanged += new System.EventHandler(this.ItemCB_SelectedIndexChanged);
            // 
            // ViewInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 547);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewInventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.InventoriesGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayInventoriesDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CategoryCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox InventoriesGB;
        private System.Windows.Forms.DataGridView DisplayInventoriesDGV;
        private System.Windows.Forms.ComboBox ItemCB;
    }
}