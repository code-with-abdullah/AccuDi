using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVC_Inventory
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            // Adding color toggle to left navigation panel buttons
            foreach (Control control in this.NavigationPNL.Controls)
            {
                if (control is Button)
                {
                    control.MouseEnter += mouseEnteringButton;
                    control.MouseLeave += mouseLeavingButton;
                }
            }
        }

        #region Top right buttons
        private void ClosePB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit application ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MaximizePB_Click(object sender, EventArgs e)
        {
            // Toggle form window state
            if (this.WindowState== FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void MinimizePB_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion


        #region Utility functions
        private void mouseEnteringButton(object sender, EventArgs e)
        {
            Button button = sender as Button;

            button.BackColor = Color.FromArgb(178, 8, 25);
            button.ForeColor = Color.FromArgb(11, 7, 17);
        }
        private void mouseLeavingButton(object sender, EventArgs e)
        {
            Button button = sender as Button;

            button.BackColor = Color.FromArgb(11, 7, 17);
            button.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void clearMainPNL()
        {
            foreach (Control control in this.WorkAreaPNL.Controls)
            {
                if (control is Form)
                {
                    control.Dispose();
                }
            }
            WorkAreaPNL.Controls.Clear();
        }

        #endregion
        private void ItemsBTN_Click(object sender, EventArgs e)
        {
            ItemForm itemForm = new ItemForm();

            clearMainPNL();

            itemForm.TopLevel = false;
            itemForm.TopMost = false;

            WorkAreaPNL.Controls.Add(itemForm);
            itemForm.Show();
        }

        private void StoreBTN_Click(object sender, EventArgs e)
        {
            WarehouseForm storeForm = new WarehouseForm();

            clearMainPNL();

            storeForm.TopLevel = false;
            storeForm.TopMost = false;

            WorkAreaPNL.Controls.Add(storeForm);
            storeForm.Show();
        }

        private void VendorBTN_Click(object sender, EventArgs e)
        {
            VendorForm vendorForm = new VendorForm();

            clearMainPNL();

            vendorForm.TopLevel = false;
            vendorForm.TopMost = false;

            WorkAreaPNL.Controls.Add(vendorForm);
            vendorForm.Show();
        }

        private void InventoryBTN_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm();

            clearMainPNL();

            inventoryForm.TopLevel = false;
            inventoryForm.TopMost = false;

            WorkAreaPNL.Controls.Add(inventoryForm);
            inventoryForm.Show();
        }

        private void CustomerBTN_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();

            clearMainPNL();

            customerForm.TopLevel = false;
            customerForm.TopMost = false;

            WorkAreaPNL.Controls.Add(customerForm);
            customerForm.Show();
        }
    }
}
