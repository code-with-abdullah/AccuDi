namespace UPVC_Inventory
{
    partial class PopUpOfNegativeItems
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
            this.ItemsGB = new System.Windows.Forms.GroupBox();
            this.DisplayNegativeItemsDGV = new System.Windows.Forms.DataGridView();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.ItemsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayNegativeItemsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.label6.Location = new System.Drawing.Point(95, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 28);
            this.label6.TabIndex = 25;
            this.label6.Text = "Items with negative inventory";
            // 
            // ItemsGB
            // 
            this.ItemsGB.Controls.Add(this.DisplayNegativeItemsDGV);
            this.ItemsGB.Location = new System.Drawing.Point(12, 52);
            this.ItemsGB.Name = "ItemsGB";
            this.ItemsGB.Size = new System.Drawing.Size(426, 428);
            this.ItemsGB.TabIndex = 27;
            this.ItemsGB.TabStop = false;
            this.ItemsGB.Text = "Added items";
            // 
            // DisplayNegativeItemsDGV
            // 
            this.DisplayNegativeItemsDGV.AllowUserToAddRows = false;
            this.DisplayNegativeItemsDGV.AllowUserToDeleteRows = false;
            this.DisplayNegativeItemsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DisplayNegativeItemsDGV.BackgroundColor = System.Drawing.Color.White;
            this.DisplayNegativeItemsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayNegativeItemsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayNegativeItemsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.DisplayNegativeItemsDGV.Location = new System.Drawing.Point(3, 25);
            this.DisplayNegativeItemsDGV.Name = "DisplayNegativeItemsDGV";
            this.DisplayNegativeItemsDGV.Size = new System.Drawing.Size(420, 400);
            this.DisplayNegativeItemsDGV.TabIndex = 0;
            // 
            // CloseBTN
            // 
            this.CloseBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.CloseBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBTN.FlatAppearance.BorderSize = 0;
            this.CloseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CloseBTN.ForeColor = System.Drawing.Color.White;
            this.CloseBTN.Location = new System.Drawing.Point(261, 486);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(177, 33);
            this.CloseBTN.TabIndex = 28;
            this.CloseBTN.Text = "Close";
            this.CloseBTN.UseVisualStyleBackColor = false;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // PopUpOfNegativeItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 524);
            this.Controls.Add(this.CloseBTN);
            this.Controls.Add(this.ItemsGB);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PopUpOfNegativeItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopUpOfNegativeItems";
            this.ItemsGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayNegativeItemsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox ItemsGB;
        private System.Windows.Forms.DataGridView DisplayNegativeItemsDGV;
        private System.Windows.Forms.Button CloseBTN;
    }
}