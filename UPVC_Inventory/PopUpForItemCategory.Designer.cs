namespace UPVC_Inventory
{
    partial class PopUpForItemCategory
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
            this.CancelBTN = new System.Windows.Forms.Button();
            this.CloseNewCategoryBTN = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NewCategoryTB = new System.Windows.Forms.TextBox();
            this.AddNewItemCategoryBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CancelBTN
            // 
            this.CancelBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelBTN.BackColor = System.Drawing.Color.White;
            this.CancelBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBTN.FlatAppearance.BorderSize = 0;
            this.CancelBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CancelBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.CancelBTN.Location = new System.Drawing.Point(40, 171);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(108, 33);
            this.CancelBTN.TabIndex = 24;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = false;
            this.CancelBTN.Click += new System.EventHandler(this.CloseNewCategoryBTN_Click);
            // 
            // CloseNewCategoryBTN
            // 
            this.CloseNewCategoryBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseNewCategoryBTN.AutoSize = true;
            this.CloseNewCategoryBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseNewCategoryBTN.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.CloseNewCategoryBTN.Location = new System.Drawing.Point(316, 9);
            this.CloseNewCategoryBTN.Name = "CloseNewCategoryBTN";
            this.CloseNewCategoryBTN.Size = new System.Drawing.Size(23, 28);
            this.CloseNewCategoryBTN.TabIndex = 22;
            this.CloseNewCategoryBTN.Text = "x";
            this.CloseNewCategoryBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseNewCategoryBTN.Click += new System.EventHandler(this.CloseNewCategoryBTN_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(36, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "Add new category";
            // 
            // NewCategoryTB
            // 
            this.NewCategoryTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewCategoryTB.BackColor = System.Drawing.SystemColors.Control;
            this.NewCategoryTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewCategoryTB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.NewCategoryTB.Location = new System.Drawing.Point(40, 114);
            this.NewCategoryTB.Name = "NewCategoryTB";
            this.NewCategoryTB.Size = new System.Drawing.Size(272, 27);
            this.NewCategoryTB.TabIndex = 20;
            // 
            // AddNewItemCategoryBTN
            // 
            this.AddNewItemCategoryBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddNewItemCategoryBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.AddNewItemCategoryBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNewItemCategoryBTN.FlatAppearance.BorderSize = 0;
            this.AddNewItemCategoryBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewItemCategoryBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.AddNewItemCategoryBTN.ForeColor = System.Drawing.Color.White;
            this.AddNewItemCategoryBTN.Location = new System.Drawing.Point(204, 171);
            this.AddNewItemCategoryBTN.Name = "AddNewItemCategoryBTN";
            this.AddNewItemCategoryBTN.Size = new System.Drawing.Size(108, 33);
            this.AddNewItemCategoryBTN.TabIndex = 21;
            this.AddNewItemCategoryBTN.Text = "Save";
            this.AddNewItemCategoryBTN.UseVisualStyleBackColor = false;
            this.AddNewItemCategoryBTN.Click += new System.EventHandler(this.AddNewItemCategoryBTN_Click);
            // 
            // PopUpForItemCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(349, 261);
            this.ControlBox = false;
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.CloseNewCategoryBTN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NewCategoryTB);
            this.Controls.Add(this.AddNewItemCategoryBTN);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PopUpForItemCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.Label CloseNewCategoryBTN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NewCategoryTB;
        private System.Windows.Forms.Button AddNewItemCategoryBTN;
    }
}