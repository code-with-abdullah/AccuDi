namespace UPVC_Inventory
{
    partial class PopUpForUomForm
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
            this.NewUomTB = new System.Windows.Forms.TextBox();
            this.AddNewUomBTN = new System.Windows.Forms.Button();
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
            this.CancelBTN.Location = new System.Drawing.Point(37, 173);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(108, 33);
            this.CancelBTN.TabIndex = 29;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = false;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // CloseNewCategoryBTN
            // 
            this.CloseNewCategoryBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseNewCategoryBTN.AutoSize = true;
            this.CloseNewCategoryBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseNewCategoryBTN.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.CloseNewCategoryBTN.Location = new System.Drawing.Point(313, 11);
            this.CloseNewCategoryBTN.Name = "CloseNewCategoryBTN";
            this.CloseNewCategoryBTN.Size = new System.Drawing.Size(23, 28);
            this.CloseNewCategoryBTN.TabIndex = 27;
            this.CloseNewCategoryBTN.Text = "x";
            this.CloseNewCategoryBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseNewCategoryBTN.Click += new System.EventHandler(this.CloseNewCategoryBTN_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(33, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 21);
            this.label6.TabIndex = 28;
            this.label6.Text = "Add new UOM";
            // 
            // NewUomTB
            // 
            this.NewUomTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewUomTB.BackColor = System.Drawing.SystemColors.Control;
            this.NewUomTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewUomTB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.NewUomTB.Location = new System.Drawing.Point(37, 116);
            this.NewUomTB.Name = "NewUomTB";
            this.NewUomTB.Size = new System.Drawing.Size(272, 27);
            this.NewUomTB.TabIndex = 25;
            // 
            // AddNewUomBTN
            // 
            this.AddNewUomBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddNewUomBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.AddNewUomBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNewUomBTN.FlatAppearance.BorderSize = 0;
            this.AddNewUomBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewUomBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.AddNewUomBTN.ForeColor = System.Drawing.Color.White;
            this.AddNewUomBTN.Location = new System.Drawing.Point(201, 173);
            this.AddNewUomBTN.Name = "AddNewUomBTN";
            this.AddNewUomBTN.Size = new System.Drawing.Size(108, 33);
            this.AddNewUomBTN.TabIndex = 26;
            this.AddNewUomBTN.Text = "Save";
            this.AddNewUomBTN.UseVisualStyleBackColor = false;
            this.AddNewUomBTN.Click += new System.EventHandler(this.AddNewUomBTN_Click);
            // 
            // PopUpForUomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(349, 261);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.CloseNewCategoryBTN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NewUomTB);
            this.Controls.Add(this.AddNewUomBTN);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PopUpForUomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopUpForUomForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.Label CloseNewCategoryBTN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NewUomTB;
        private System.Windows.Forms.Button AddNewUomBTN;
    }
}