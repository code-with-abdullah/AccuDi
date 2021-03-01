namespace UPVC_Inventory
{
    partial class CustomerForm
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
            this.SuppliersGB = new System.Windows.Forms.GroupBox();
            this.DisplayCustomersDGV = new System.Windows.Forms.DataGridView();
            this.AddCustomerBTN = new System.Windows.Forms.Button();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.NtnTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CityTB = new System.Windows.Forms.TextBox();
            this.PhoneTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AreaTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuppliersGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayCustomersDGV)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SuppliersGB
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.SuppliersGB, 4);
            this.SuppliersGB.Controls.Add(this.DisplayCustomersDGV);
            this.SuppliersGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SuppliersGB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SuppliersGB.Location = new System.Drawing.Point(3, 171);
            this.SuppliersGB.Name = "SuppliersGB";
            this.tableLayoutPanel1.SetRowSpan(this.SuppliersGB, 3);
            this.SuppliersGB.Size = new System.Drawing.Size(1000, 389);
            this.SuppliersGB.TabIndex = 43;
            this.SuppliersGB.TabStop = false;
            this.SuppliersGB.Text = "Customers";
            // 
            // DisplayCustomersDGV
            // 
            this.DisplayCustomersDGV.AllowUserToAddRows = false;
            this.DisplayCustomersDGV.AllowUserToDeleteRows = false;
            this.DisplayCustomersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DisplayCustomersDGV.BackgroundColor = System.Drawing.Color.White;
            this.DisplayCustomersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayCustomersDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayCustomersDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.DisplayCustomersDGV.Location = new System.Drawing.Point(3, 25);
            this.DisplayCustomersDGV.Name = "DisplayCustomersDGV";
            this.DisplayCustomersDGV.Size = new System.Drawing.Size(994, 361);
            this.DisplayCustomersDGV.TabIndex = 0;
            this.DisplayCustomersDGV.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DisplayCustomersDGV_CellEndEdit);
            this.DisplayCustomersDGV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DisplayCustomersDGV_KeyDown);
            // 
            // AddCustomerBTN
            // 
            this.AddCustomerBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCustomerBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.AddCustomerBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCustomerBTN.FlatAppearance.BorderSize = 0;
            this.AddCustomerBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCustomerBTN.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.AddCustomerBTN.ForeColor = System.Drawing.Color.White;
            this.AddCustomerBTN.Location = new System.Drawing.Point(655, 119);
            this.AddCustomerBTN.Name = "AddCustomerBTN";
            this.AddCustomerBTN.Size = new System.Drawing.Size(348, 42);
            this.AddCustomerBTN.TabIndex = 10;
            this.AddCustomerBTN.Text = "Add customer";
            this.AddCustomerBTN.UseVisualStyleBackColor = false;
            this.AddCustomerBTN.Click += new System.EventHandler(this.AddCustomerBTN_Click);
            // 
            // NameTB
            // 
            this.NameTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTB.BackColor = System.Drawing.SystemColors.Control;
            this.NameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.NameTB.Location = new System.Drawing.Point(153, 14);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(346, 27);
            this.NameTB.TabIndex = 1;
            // 
            // NtnTB
            // 
            this.NtnTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NtnTB.BackColor = System.Drawing.SystemColors.Control;
            this.NtnTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NtnTB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.NtnTB.Location = new System.Drawing.Point(153, 126);
            this.NtnTB.Name = "NtnTB";
            this.NtnTB.Size = new System.Drawing.Size(346, 27);
            this.NtnTB.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label8.Location = new System.Drawing.Point(3, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 56);
            this.label8.TabIndex = 34;
            this.label8.Text = "NTN No";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CityTB
            // 
            this.CityTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CityTB.BackColor = System.Drawing.SystemColors.Control;
            this.CityTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CityTB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.CityTB.Location = new System.Drawing.Point(655, 70);
            this.CityTB.Name = "CityTB";
            this.CityTB.Size = new System.Drawing.Size(348, 27);
            this.CityTB.TabIndex = 5;
            // 
            // PhoneTB
            // 
            this.PhoneTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneTB.BackColor = System.Drawing.SystemColors.Control;
            this.PhoneTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneTB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.PhoneTB.Location = new System.Drawing.Point(655, 14);
            this.PhoneTB.Name = "PhoneTB";
            this.PhoneTB.Size = new System.Drawing.Size(348, 27);
            this.PhoneTB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label4.Location = new System.Drawing.Point(505, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 56);
            this.label4.TabIndex = 30;
            this.label4.Text = "City";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label3.Location = new System.Drawing.Point(505, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 56);
            this.label3.TabIndex = 28;
            this.label3.Text = "Phone Number";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.label1.Size = new System.Drawing.Size(144, 56);
            this.label1.TabIndex = 26;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.NameTB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PhoneTB, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AreaTB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CityTB, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.NtnTB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.AddCustomerBTN, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.SuppliersGB, 0, 3);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1006, 563);
            this.tableLayoutPanel1.TabIndex = 44;
            // 
            // AreaTB
            // 
            this.AreaTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AreaTB.BackColor = System.Drawing.SystemColors.Control;
            this.AreaTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AreaTB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.AreaTB.Location = new System.Drawing.Point(153, 70);
            this.AreaTB.Name = "AreaTB";
            this.AreaTB.Size = new System.Drawing.Size(346, 27);
            this.AreaTB.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label9.Location = new System.Drawing.Point(3, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 56);
            this.label9.TabIndex = 45;
            this.label9.Text = "Area";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 563);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerForm";
            this.SuppliersGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayCustomersDGV)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SuppliersGB;
        private System.Windows.Forms.DataGridView DisplayCustomersDGV;
        private System.Windows.Forms.Button AddCustomerBTN;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox NtnTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CityTB;
        private System.Windows.Forms.TextBox PhoneTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox AreaTB;
        private System.Windows.Forms.Label label9;
    }
}