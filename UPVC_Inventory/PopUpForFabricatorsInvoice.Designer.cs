namespace UPVC_Inventory
{
    partial class PopUpForFabricatorsInvoice
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
            this.label6 = new System.Windows.Forms.Label();
            this.CustomerCB = new System.Windows.Forms.ComboBox();
            this.ProjectSiteTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AttenTB = new System.Windows.Forms.TextBox();
            this.GenerateInvoiceBTN = new System.Windows.Forms.Button();
            this.WarehouseCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label6.Location = new System.Drawing.Point(37, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 28);
            this.label6.TabIndex = 24;
            this.label6.Text = "Select customer";
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
            this.CustomerCB.Location = new System.Drawing.Point(42, 77);
            this.CustomerCB.Name = "CustomerCB";
            this.CustomerCB.Size = new System.Drawing.Size(353, 36);
            this.CustomerCB.TabIndex = 1;
            // 
            // ProjectSiteTB
            // 
            this.ProjectSiteTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectSiteTB.BackColor = System.Drawing.SystemColors.Control;
            this.ProjectSiteTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProjectSiteTB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.ProjectSiteTB.Location = new System.Drawing.Point(42, 271);
            this.ProjectSiteTB.Name = "ProjectSiteTB";
            this.ProjectSiteTB.Size = new System.Drawing.Size(353, 27);
            this.ProjectSiteTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label1.Location = new System.Drawing.Point(37, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "Project site";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label2.Location = new System.Drawing.Point(37, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 28);
            this.label2.TabIndex = 28;
            this.label2.Text = "Atten";
            // 
            // AttenTB
            // 
            this.AttenTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AttenTB.BackColor = System.Drawing.SystemColors.Control;
            this.AttenTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AttenTB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.AttenTB.Location = new System.Drawing.Point(42, 363);
            this.AttenTB.Name = "AttenTB";
            this.AttenTB.Size = new System.Drawing.Size(353, 27);
            this.AttenTB.TabIndex = 4;
            // 
            // GenerateInvoiceBTN
            // 
            this.GenerateInvoiceBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GenerateInvoiceBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.GenerateInvoiceBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenerateInvoiceBTN.FlatAppearance.BorderSize = 0;
            this.GenerateInvoiceBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateInvoiceBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.GenerateInvoiceBTN.ForeColor = System.Drawing.Color.White;
            this.GenerateInvoiceBTN.Location = new System.Drawing.Point(218, 444);
            this.GenerateInvoiceBTN.Name = "GenerateInvoiceBTN";
            this.GenerateInvoiceBTN.Size = new System.Drawing.Size(177, 33);
            this.GenerateInvoiceBTN.TabIndex = 5;
            this.GenerateInvoiceBTN.Text = "Generate Invoice";
            this.GenerateInvoiceBTN.UseVisualStyleBackColor = false;
            this.GenerateInvoiceBTN.Click += new System.EventHandler(this.GenerateInvoiceBTN_Click);
            // 
            // WarehouseCB
            // 
            this.WarehouseCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WarehouseCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.WarehouseCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.WarehouseCB.BackColor = System.Drawing.SystemColors.Control;
            this.WarehouseCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WarehouseCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WarehouseCB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.WarehouseCB.FormattingEnabled = true;
            this.WarehouseCB.Location = new System.Drawing.Point(42, 173);
            this.WarehouseCB.Name = "WarehouseCB";
            this.WarehouseCB.Size = new System.Drawing.Size(353, 36);
            this.WarehouseCB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label3.Location = new System.Drawing.Point(37, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 28);
            this.label3.TabIndex = 31;
            this.label3.Text = "Select warehouse";
            // 
            // PopUpForFabricatorsInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 524);
            this.Controls.Add(this.WarehouseCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GenerateInvoiceBTN);
            this.Controls.Add(this.AttenTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProjectSiteTB);
            this.Controls.Add(this.CustomerCB);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PopUpForFabricatorsInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CustomerCB;
        private System.Windows.Forms.TextBox ProjectSiteTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AttenTB;
        private System.Windows.Forms.Button GenerateInvoiceBTN;
        private System.Windows.Forms.ComboBox WarehouseCB;
        private System.Windows.Forms.Label label3;
    }
}