namespace UPVC_Inventory
{
    partial class ViewProfileInvoicesForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.FromDTP = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.StatusCB = new System.Windows.Forms.ComboBox();
            this.ToDTP = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemsGB = new System.Windows.Forms.GroupBox();
            this.DisplayInvoicesDGV = new System.Windows.Forms.DataGridView();
            this.PrintBTN = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.ItemsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayInvoicesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CustomerCB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.FromDTP, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.StatusCB, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.ToDTP, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ItemsGB, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.PrintBTN, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 558);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.label1.Size = new System.Drawing.Size(145, 55);
            this.label1.TabIndex = 10;
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
            this.CustomerCB.Location = new System.Drawing.Point(154, 9);
            this.CustomerCB.Name = "CustomerCB";
            this.CustomerCB.Size = new System.Drawing.Size(346, 36);
            this.CustomerCB.TabIndex = 1;
            this.CustomerCB.SelectedIndexChanged += new System.EventHandler(this.CustomerCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 55);
            this.label3.TabIndex = 14;
            this.label3.Text = "From";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FromDTP
            // 
            this.FromDTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FromDTP.CalendarFont = new System.Drawing.Font("Segoe UI", 12F);
            this.FromDTP.CalendarForeColor = System.Drawing.Color.Coral;
            this.FromDTP.Location = new System.Drawing.Point(154, 68);
            this.FromDTP.Name = "FromDTP";
            this.FromDTP.Size = new System.Drawing.Size(346, 29);
            this.FromDTP.TabIndex = 3;
            this.FromDTP.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.FromDTP.ValueChanged += new System.EventHandler(this.FromDTP_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.label4.Location = new System.Drawing.Point(506, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 55);
            this.label4.TabIndex = 15;
            this.label4.Text = "Status";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusCB
            // 
            this.StatusCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.StatusCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.StatusCB.BackColor = System.Drawing.SystemColors.Control;
            this.StatusCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusCB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.StatusCB.FormattingEnabled = true;
            this.StatusCB.Items.AddRange(new object[] {
            "All",
            "Open",
            "Closed"});
            this.StatusCB.Location = new System.Drawing.Point(657, 9);
            this.StatusCB.Name = "StatusCB";
            this.StatusCB.Size = new System.Drawing.Size(348, 36);
            this.StatusCB.TabIndex = 2;
            this.StatusCB.SelectedIndexChanged += new System.EventHandler(this.StatusCB_SelectedIndexChanged);
            // 
            // ToDTP
            // 
            this.ToDTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ToDTP.CalendarFont = new System.Drawing.Font("Segoe UI", 12F);
            this.ToDTP.CalendarForeColor = System.Drawing.Color.Coral;
            this.ToDTP.Location = new System.Drawing.Point(657, 68);
            this.ToDTP.Name = "ToDTP";
            this.ToDTP.Size = new System.Drawing.Size(348, 29);
            this.ToDTP.TabIndex = 4;
            this.ToDTP.Value = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.ToDTP.ValueChanged += new System.EventHandler(this.ToDTP_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.label2.Location = new System.Drawing.Point(506, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 55);
            this.label2.TabIndex = 37;
            this.label2.Text = "To";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemsGB
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ItemsGB, 4);
            this.ItemsGB.Controls.Add(this.DisplayInvoicesDGV);
            this.ItemsGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsGB.Location = new System.Drawing.Point(3, 168);
            this.ItemsGB.Name = "ItemsGB";
            this.ItemsGB.Size = new System.Drawing.Size(1002, 387);
            this.ItemsGB.TabIndex = 35;
            this.ItemsGB.TabStop = false;
            this.ItemsGB.Text = "Invoices";
            // 
            // DisplayInvoicesDGV
            // 
            this.DisplayInvoicesDGV.AllowUserToAddRows = false;
            this.DisplayInvoicesDGV.AllowUserToDeleteRows = false;
            this.DisplayInvoicesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DisplayInvoicesDGV.BackgroundColor = System.Drawing.Color.White;
            this.DisplayInvoicesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayInvoicesDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayInvoicesDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.DisplayInvoicesDGV.Location = new System.Drawing.Point(3, 25);
            this.DisplayInvoicesDGV.Name = "DisplayInvoicesDGV";
            this.DisplayInvoicesDGV.ReadOnly = true;
            this.DisplayInvoicesDGV.Size = new System.Drawing.Size(996, 359);
            this.DisplayInvoicesDGV.TabIndex = 0;
            this.DisplayInvoicesDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DisplayInvoicesDGV_CellClick);
            // 
            // PrintBTN
            // 
            this.PrintBTN.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PrintBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.PrintBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintBTN.FlatAppearance.BorderSize = 0;
            this.PrintBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintBTN.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.PrintBTN.ForeColor = System.Drawing.Color.White;
            this.PrintBTN.Location = new System.Drawing.Point(881, 119);
            this.PrintBTN.Name = "PrintBTN";
            this.PrintBTN.Size = new System.Drawing.Size(124, 36);
            this.PrintBTN.TabIndex = 5;
            this.PrintBTN.TabStop = false;
            this.PrintBTN.Text = "Print";
            this.PrintBTN.UseVisualStyleBackColor = false;
            this.PrintBTN.Visible = false;
            this.PrintBTN.Click += new System.EventHandler(this.PrintBTN_Click);
            // 
            // ViewProfileInvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 558);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewProfileInvoicesForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ItemsGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayInvoicesDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CustomerCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker FromDTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox StatusCB;
        private System.Windows.Forms.GroupBox ItemsGB;
        private System.Windows.Forms.DataGridView DisplayInvoicesDGV;
        private System.Windows.Forms.DateTimePicker ToDTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PrintBTN;
    }
}