using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;
using System.Collections;

namespace UPVC_Inventory
{
    public partial class PopUpForFabricatorsInvoice : Form
    {
        ArrayList listOfAllOrders;
        ArrayList listOfItemsInAnOrder;
        ReadFromDB readFromDatabase;
        WriteToDatabase writeToDatabase;

        public PopUpForFabricatorsInvoice(ArrayList listOfAllOrders, ArrayList listOfItemsInAnOrder)
        {
            InitializeComponent();

            readFromDatabase = new ReadFromDB();
            writeToDatabase = new WriteToDatabase();

            this.listOfAllOrders = listOfAllOrders;
            this.listOfItemsInAnOrder = listOfItemsInAnOrder;

            // populate customers
            DataSet customers = readFromDatabase.ReadCustomerNamesFromDB();
            foreach (DataRow dataRow in customers.Tables[0].Rows)
            {
                CustomerCB.Items.Add(dataRow[0].ToString());
            }

            // populate warehouses
            DataSet warehouse = readFromDatabase.ReadStoreNamesFromDB();
            foreach (DataRow dataRow in warehouse.Tables[0].Rows)
            {
                WarehouseCB.Items.Add(dataRow[0].ToString());
            }
        }

        private void GenerateInvoiceBTN_Click(object sender, EventArgs e)
        {
            if(CustomerCB.Text == "")
            {
                MessageBox.Show("Please select a customer", "Customer not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (WarehouseCB.Text == "")
            {
                MessageBox.Show("Please select a warehouse", "Warehouse not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ProjectSiteTB.Text== "")
            {
                MessageBox.Show("Please enter project site", "Project site not metioned", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string customerName = CustomerCB.Text;
            string projectSite = ProjectSiteTB.Text;
            string atten = AttenTB.Text;

            bool viewInvoiceAfterGeneration = false;

            if (MessageBox.Show("Do you want to view this invoice?", "View invoice?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                viewInvoiceAfterGeneration = true;
            }

            float totalAmount = 0;
            foreach(Dictionary<string, object> order in listOfAllOrders)
            {
                totalAmount += float.Parse(order["TotalPrice"].ToString());
            }

            bool inventoryNegative = writeToDatabase.writeFabricatorsInvoice(CustomerCB.Text,
                DateTime.Now,
                totalAmount.ToString("F4"),
                ProjectSiteTB.Text,
                AttenTB.Text,
                listOfAllOrders,
                listOfItemsInAnOrder,
                WarehouseCB.Text,
                viewInvoiceAfterGeneration
                );

            if (inventoryNegative)
            {
                MessageBox.Show("Some items have gone out of stock after this invoice", "Inventory negative", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Enabled = false;
                PopUpOfNegativeItems popUpOfNegativeItems = new PopUpOfNegativeItems();
                popUpOfNegativeItems.Show();
            }

            this.Dispose();
        }
    }
}