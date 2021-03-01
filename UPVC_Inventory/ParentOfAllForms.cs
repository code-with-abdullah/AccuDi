using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using LogicLayer;

namespace UPVC_Inventory
{
    public partial class ParentOfAllForms : Form
    {
        Button previousMainBtn;
        Button previousDropdownBtn;
        ReadFromDB readFromDB;
        Utils utils;

        FabricatorsForm fabricatorsForm;

        public string GetMACAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card  
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            return sMacAddress;
        }

        public ParentOfAllForms()
        {
            if (!("90324B8E9651" == GetMACAddress()
                || "54BF641B0D4F" == GetMACAddress()
                || "0A002700000E" == GetMACAddress()
                || "A2159C28C06C" == GetMACAddress()))        // mine
            //if (!("78843CA6EF3B" == GetMACAddress() || "9439E5A61D9B" == GetMACAddress() || "00FF418AE9D6" == GetMACAddress())) // ammar bhai
            //if (!("28B2BDB06350" == GetMACAddress()
            //    || "54EE75271E42" == GetMACAddress()))           // naveed
            {
                MessageBox.Show("Kindly get a licence for this product\n\nFor more info reach out at koncept-solutions\n\nOr email at support@koncept-solutions.com\n\nOr reach at OfficialAbdullahAslam@gmail.com", "Product has not been registered for this PC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(0);
            }

            InitializeComponent();

            fabricatorsForm = new FabricatorsForm();

            utils = new Utils();
            readFromDB = new ReadFromDB();
            addFormToWorkArea(new DashboardForm());

            previousMainBtn = DashboardBTN;
            previousDropdownBtn = AddInventoryBTN;

            // Adding color toggle to left navigation panel buttons
            foreach (Control control in this.NavigationPNL.Controls)
            {
                if (control is Button)
                {
                    control.MouseEnter += mouseEnteringMainButton;
                    control.MouseLeave += mouseLeavingMainButton;
                    control.MouseClick += mouseClickOnMainButton;
                }
            }
            foreach (Control control in this.DropDownItemsPNL.Controls)
            {
                if (control is Button)
                {
                    control.MouseEnter += mouseEnteringDropdownButton;
                    control.MouseLeave += mouseLeavingDropdownButton;
                    control.MouseClick += mouseClickOnDropdownButton;
                }
            }
        }

        #region utility functions

        private void mouseEnteringMainButton(object sender, EventArgs e)
        {
            Button button = sender as Button;

            button.BackColor = Color.FromArgb(178, 8, 25);
            button.ForeColor = Color.FromArgb(11, 7, 17);
        }
        private void mouseLeavingMainButton(object sender, EventArgs e)
        {
            Button button = sender as Button;

            button.BackColor = Color.FromArgb(11, 7, 17);
            button.ForeColor = Color.FromArgb(255, 255, 255);
        }
        private void mouseClickOnMainButton(object sender, EventArgs e)
        {
            if((sender as Button).Text == "Add Items")
            {
                DropDownItemsPNL.Visible = true;
            }
            else
            {
                DropDownItemsPNL.Visible = false;
                previousDropdownBtn.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            }

            previousMainBtn.Font = new Font("Segoe UI", 15, FontStyle.Regular);
            (sender as Button).Font = new Font("Segoe UI", 18, FontStyle.Bold);
            previousMainBtn = (sender as Button);
        }

        private void mouseEnteringDropdownButton(object sender, EventArgs e)
        {
            Button button = sender as Button;

            button.BackColor = Color.FromArgb(178, 8, 25);
            button.ForeColor = Color.FromArgb(15, 15, 28);
        }
        private void mouseLeavingDropdownButton(object sender, EventArgs e)
        {
            Button button = sender as Button;

            button.BackColor = Color.FromArgb(15, 15, 28);
            button.ForeColor = Color.FromArgb(255, 255, 255);
        }
        private void mouseClickOnDropdownButton(object sender, EventArgs e)
        {
            previousDropdownBtn.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            (sender as Button).Font = new Font("Segoe UI", 14, FontStyle.Bold);
            previousDropdownBtn = (sender as Button);
        }

        private void clearMainPNL()
        {
            foreach (Control control in this.WorkAreaPNL.Controls)
            {
                if (control is Form)
                {
                    if (control is FabricatorsForm)
                    {
                        (control as FabricatorsForm).resetAllInputs();
                        control.Hide();
                    }
                    else
                    {
                        control.Dispose();
                    }
                }
            }
            WorkAreaPNL.Controls.Clear();
        }

        private void addFormToWorkArea(Form formToAdd)
        {
            clearMainPNL();

            formToAdd.TopLevel = false;
            formToAdd.TopMost = false;
            formToAdd.Dock = DockStyle.Fill;

            WorkAreaPNL.Controls.Add(formToAdd);
            formToAdd.Show();

        }

        #endregion

        #region top right panel buttons

        private void ClosePB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit application ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
            }
        }

        private void MaximizePB_Click(object sender, EventArgs e)
        {
            // Toggle form window state
            if (this.WindowState == FormWindowState.Maximized)
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

        #region navigation panel buttons

        private void DashboardBTN_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            addFormToWorkArea(dashboardForm);
        }

        private void WarehouseBTN_Click(object sender, EventArgs e)
        {
            WarehouseForm storeForm = new WarehouseForm();
            addFormToWorkArea(storeForm);
        }

        private void VendorBTN_Click(object sender, EventArgs e)
        {
            VendorForm vendorForm = new VendorForm();
            addFormToWorkArea(vendorForm);
        }

        private void AddItemsBTN_Click(object sender, EventArgs e)
        {
            ItemForm itemForm = new ItemForm();
            addFormToWorkArea(itemForm);
        }

        private void CustomerBTN_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            addFormToWorkArea(customerForm);
        }

        private void AddInventoryBTN_Click(object sender, EventArgs e)
        {
            if (readFromDB.ReadCategoriesFromDB().Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Add categories to database to proceed further", "No Categories in Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (readFromDB.ReadVendorNamesFromDB().Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Add vendors to database to proceed further", "No Vendors in Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (readFromDB.ReadItemsFromDB_updated().Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Add items to database to proceed further", "No Items in Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (readFromDB.ReadStoreNamesFromDB().Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Add warehouse to database to proceed further", "No warehouse in Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InventoryForm inventoryForm = new InventoryForm();
            addFormToWorkArea(inventoryForm);

            //inventoryForm.Disposed += inventoryView;
            //inventoryForm.FormClosing += inventoryView;
        }

        private void ViewInventoryBTN_Click(object sender, EventArgs e)
        {
            if (readFromDB.ReadCategoriesFromDB().Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Add categories to database to proceed further", "No Customers in Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ViewInventoryForm viewInventoryForm = new ViewInventoryForm();
            addFormToWorkArea(viewInventoryForm);
        }

        private void ProfileInvoiceBTN_Click(object sender, EventArgs e)
        {
            if (readFromDB.ReadCustomerNamesFromDB().Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Add customers to database to proceed further", "No Customers in Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (readFromDB.ReadVendorNamesFromDB().Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Add vendors to database to proceed further", "No Vendors in Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (readFromDB.ReadItemsFromDB_updated().Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Add items to database to proceed further", "No Items in Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (readFromDB.ReadStoreNamesFromDB().Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Add warehouse to database to proceed further", "No warehouse in Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProfileInvoiceForm profileInvoiceForm = new ProfileInvoiceForm();
            addFormToWorkArea(profileInvoiceForm);
        }

        private void ViewProfileInvoicesBTN_Click(object sender, EventArgs e)
        {
            if (readFromDB.ReadCustomerNamesFromDB().Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Add customers in database to proceed further", "No Customers in Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ViewProfileInvoicesForm viewProfileInvoices = new ViewProfileInvoicesForm();
            addFormToWorkArea(viewProfileInvoices);
        }

        private void FabricatorsBTN_Click(object sender, EventArgs e)
        {
            if (readFromDB.ReadCustomerNamesFromDB().Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Add customers to database to proceed further", "No Customers in Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (readFromDB.ReadStoreNamesFromDB().Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Add warehouse to database to proceed further", "No warehouse in Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!utils.checkIfAllConchItemsAreEntered())
            {
                MessageBox.Show("Conch items not found in database.\nAdding conch items now.\nPlease wait...", "Conch items not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                utils.addAllConchItemsToDB();
            }

            fabricatorsForm.readConchItemValuesFromDatabase();
            //FabricatorsForm fabricatorsForm = new FabricatorsForm();
            addFormToWorkArea(fabricatorsForm);
        }

        private void inventoryView(object sender, EventArgs e)
        {
            ViewInventoryForm viewInventoryForm = new ViewInventoryForm();
            addFormToWorkArea(viewInventoryForm);
        }

        #endregion

        private void WebsiteLinkLBL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.koncept-solutions.com");
        }
    }
}