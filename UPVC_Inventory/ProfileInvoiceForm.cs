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
using System.Text.RegularExpressions;

namespace UPVC_Inventory
{
    public partial class ProfileInvoiceForm : Form
    {
        Utils utils;
        ReadFromDB readFromDatabase;
        WriteToDatabase writeToDatabase;

        public ProfileInvoiceForm()
        {
            InitializeComponent();

            utils = new Utils();
            readFromDatabase = new ReadFromDB();
            writeToDatabase = new WriteToDatabase();

            InvoiceDateDTP.Value = DateTime.Now;

            // Populating customer names
            DataSet customerNames = readFromDatabase.ReadCustomerNamesFromDB();
            foreach (DataRow dataRow in customerNames.Tables[0].Rows)
            {
                CustomerCB.Items.Add(dataRow[0].ToString());
            }

            // Populating categories in ComboBox
            DataSet categories = readFromDatabase.ReadCategoriesFromDB();
            foreach (DataRow dataRow in categories.Tables[0].Rows)
            {
                CategoryCB.Items.Add(dataRow[0].ToString());
            }

            // Populating warehouses in ComboBox
            DataSet warehouses = readFromDatabase.ReadStoreNamesFromDB();
            foreach (DataRow dataRow in warehouses.Tables[0].Rows)
            {
                StoreCB.Items.Add(dataRow[0].ToString());
            }

            populateDataGridView();
        }

        private void DisplayItemsDGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int row = DisplayItemsDGV.CurrentCell.RowIndex;

            float value = float.Parse(DisplayItemsDGV.Rows[row].Cells["Unit Weight"].Value.ToString());
            string quantity = DisplayItemsDGV.Rows[row].Cells["Quantity"].Value.ToString();

            if(!Regex.IsMatch(quantity, @"^(\d)*$"))
            {
                MessageBox.Show("Please do not enter a value except whole numbers.", "Quantity");
                DisplayItemsDGV.Rows[row].Cells["Quantity"].Value = 0;
            }
            else
            {
                // Apply FIFO
                string description = DisplayItemsDGV.Rows[row].Cells["Description"].Value.ToString();
                int itemEnding = description.IndexOf(" ( ");
                int categoryEnding = description.IndexOf(" )");
                int categoryStarting = itemEnding + 3;

                string item = description.Substring(0, itemEnding);
                string category = description.Substring(categoryStarting, categoryEnding - categoryStarting);
                string store = DisplayItemsDGV.Rows[row].Cells["Warehouse"].Value.ToString();

                int totalQuantity = utils.getQuantityOfItemInDB(item, category, store);

                int quantityValue = int.Parse(quantity);

                if (totalQuantity < quantityValue)
                {
                    MessageBox.Show("We do not have enough of the items available\n" + "Total items available in this warehouse are " + totalQuantity.ToString(), "Out of stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DisplayItemsDGV.Rows[row].Cells["Quantity"].Value = 0;
                    quantity = "0";
                }

                DisplayItemsDGV.Rows[row].Cells["Total weight"].Value = Math.Round(value * int.Parse(quantity), 4).ToString();
            }

            TotalWeightTB.Text = countTotalWeight().ToString();
            TotalPriceTB.Text = countTotalPrice().ToString();
        }

        private void DisplayItemsDGV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = false;
            int row = DisplayItemsDGV.CurrentCell.RowIndex;
            DisplayItemsDGV.Rows[row].Cells["Quantity"].Value = "0";
            MessageBox.Show("Please do not enter a value except whole numbers.", "Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DisplayItemsDGV_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["Quantity"].Value = "0";
            e.Row.Cells["Total weight"].Value = "0";
        }

        private float countTotalWeight()
        {
            float weight = 0;
            foreach (DataGridViewRow row in DisplayItemsDGV.Rows)
            {
                if (!string.IsNullOrEmpty(row.Cells["TotalWeight"].Value.ToString()))
                {
                    weight += float.Parse(row.Cells["TotalWeight"].Value.ToString());
                }
            }
            return weight;
        }

        private float countTotalPrice()
        {
            return (float)WeightPerKgNUD.Value * countTotalWeight();
        }

        private void populateDataGridView()
        {
            //DisplayItemsDGV.Columns.Clear();
            //DisplayItemsDGV.DataSource = readFromDatabase.ReadInventoryDistinctWhereQuantityNotZero().Tables[0];
            //DisplayItemsDGV.Columns[0].ReadOnly = true;
            //DisplayItemsDGV.Columns[1].ReadOnly = true;
            //DisplayItemsDGV.Columns[2].ReadOnly = true;
            //DisplayItemsDGV.Columns[3].ReadOnly = true;
            //DisplayItemsDGV.Columns.Add("Total weight", "Total weight");
            //DisplayItemsDGV.Columns[5].ReadOnly = true;

            //foreach (DataGridViewColumn column in DisplayItemsDGV.Columns)
            //{
            //    column.SortMode = DataGridViewColumnSortMode.NotSortable;
            //}

            //this.CustomerCB.SelectedIndex = -1;
            
            //this.TotalPriceTB.Text = "0";
        }

        private void CategoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StoreCB.Text != "" && CategoryCB.SelectedIndex != -1)
            {
                ItemCB.Items.Clear();
                // Populating items based on categories in ComboBox
                DataSet items = readFromDatabase.ReadItemsFromInventoryBasedOnCategoryAndStoreFromDB(CategoryCB.Text, StoreCB.Text);
                foreach (DataRow dataRow in items.Tables[0].Rows)
                {
                    ItemCB.Items.Add(dataRow[0].ToString());
                }
            }
            ItemCB.SelectedIndex = -1;
            ItemCB.Text = "";
            TotalAvailableTB.Text = "";
        }

        private void StoreCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryCB.Text != "" && StoreCB.SelectedIndex != -1)
            {
                ItemCB.Items.Clear();
                // Populating items based on categories in ComboBox
                DataSet items = readFromDatabase.ReadItemsFromInventoryBasedOnCategoryAndStoreFromDB(CategoryCB.Text, StoreCB.Text);
                foreach (DataRow dataRow in items.Tables[0].Rows)
                {
                    ItemCB.Items.Add(dataRow[0].ToString());
                }
            }
            ItemCB.SelectedIndex = -1;
            ItemCB.Text = "";
            TotalAvailableTB.Text = "";
        }

        private void ItemCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemCB.SelectedIndex != -1)
            {
                float totalAvailable = utils.getQuantiyOfItemInInventoryUsingStoreAndCategory(ItemCB.Text, CategoryCB.Text, StoreCB.Text);

                float alreadyAdded = 0;

                foreach(DataGridViewRow row in DisplayItemsDGV.Rows)
                {
                    string description = row.Cells["Description"].Value.ToString();
                    int itemEnding = description.IndexOf(" ( ");
                    int categoryEnding = description.IndexOf(" )");
                    int categoryStarting = itemEnding + 3;

                    string item = description.Substring(0, itemEnding);
                    string category = description.Substring(categoryStarting, categoryEnding - categoryStarting);
                    string store = row.Cells["Warehouse"].Value.ToString();

                    if(ItemCB.Text == item && CategoryCB.Text == category && StoreCB.Text == store)
                    {
                        alreadyAdded += (float)row.Cells["Quantity"].Value;
                    }
                }

                TotalAvailableTB.Text = (totalAvailable - alreadyAdded).ToString("F4");
            }
        }

        private void QuantityNUD_ValueChanged(object sender, EventArgs e)
        {
            if (TotalAvailableTB.Text != "")
            {
                if (double.Parse(QuantityNUD.Value.ToString()) > double.Parse(TotalAvailableTB.Text))
                {
                    QuantityNUD.Value = 0;
                    MessageBox.Show("Not enought items available in the inventory.", "Out of stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddToListBTN_Click(object sender, EventArgs e)
        {
            string itemCode = utils.getItemCodeFromName(ItemCB.Text);
            float unitWeight = utils.getValueFromItemUsingNames(ItemCB.Text, CategoryCB.Text);
            DisplayItemsDGV.Rows.Add(
                ItemCB.Text + " ( " + CategoryCB.Text + " )",
                StoreCB.Text,
                itemCode,
                unitWeight.ToString("F4"),
                (float)QuantityNUD.Value,
                ((float)QuantityNUD.Value * unitWeight)
                ); 

            //CustomerCB.Enabled = false;
            ItemCB.Items.Clear();
            CategoryCB.SelectedIndex = -1;
            StoreCB.SelectedIndex = -1;
            TotalAvailableTB.Text = "";
            QuantityNUD.Value = 0;

            TotalWeightTB.Text = countTotalWeight().ToString("F4");
            TotalPriceTB.Text = countTotalPrice().ToString("F4");
        }

        private void WeightPerKgNUD_ValueChanged(object sender, EventArgs e)
        {
            TotalWeightTB.Text = countTotalWeight().ToString();
            TotalPriceTB.Text = countTotalPrice().ToString();
        }

        private void GenerateInvoiceBTN_Click(object sender, EventArgs e)
        {
            // invoice master
            int result = writeToDatabase.writeProfileInvoiceMasterToDB(CustomerCB.SelectedItem.ToString(),
                InvoiceDateDTP.Value,
                TotalPriceTB.Text,
                WeightPerKgNUD.Value.ToString("F4"),
                TotalWeightTB.Text);

            // invoice child
            foreach (DataGridViewRow row in DisplayItemsDGV.Rows)
            {
                string quantityInString = row.Cells["Quantity"].Value.ToString();
                string description = row.Cells["Description"].Value.ToString();

                if (quantityInString != "0" && quantityInString != "" && quantityInString != null)
                {
                    int itemEnding = description.IndexOf(" ( ");
                    int categoryEnding = description.IndexOf(" )");
                    int categoryStarting = itemEnding + 3;

                    string item = description.Substring(0, itemEnding);
                    string category = description.Substring(categoryStarting, categoryEnding - categoryStarting);
                    string store = row.Cells["Warehouse"].Value.ToString();

                    writeToDatabase.writeInvoiceChildToDB(item, category, store, quantityInString);
                }
            }

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Description");
            dataTable.Columns.Add("Warehouse");
            dataTable.Columns.Add("Code");
            dataTable.Columns.Add("UnitWeight");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("TotalWeight");

            foreach (DataGridViewRow row in DisplayItemsDGV.Rows)
            {
                string quantityInString = row.Cells["Quantity"].Value.ToString();
                if (quantityInString != "0" && quantityInString != "" && quantityInString != null)
                {
                    dataTable.Rows.Add(
                        row.Cells["Description"].Value,
                        row.Cells["Warehouse"].Value,
                        row.Cells["Code"].Value,
                        row.Cells["UnitWeight"].Value,
                        row.Cells["Quantity"].Value,
                        row.Cells["TotalWeight"].Value);
                }
            }
            
            // Write invoice PDF
            utils.writePdfOfProfileInvoice(DateTime.Now.ToString("yyyy-MM-yy"), CustomerCB.SelectedItem.ToString(), WeightPerKgNUD.Value.ToString("F4"), TotalWeightTB.Text, TotalPriceTB.Text, dataTable);

            // Ask to view the invoice
            if (MessageBox.Show("Do you want to view this invoice ?", "View Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                utils.openInovicePdfFromFile(utils.getLatestWrittenInvoiceMasterId());
            }

            if (result < 0)
            {
                MessageBox.Show("Writing to database was unsuccessful", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InvoiceDateDTP.Value = DateTime.Now;
                TotalPriceTB.Text = "0";
                WeightPerKgNUD.Value = 0;
                TotalWeightTB.Text = "0";
            }
            else
            {
                resetForm();
            }
        }

        private void resetForm()
        {
            DisplayItemsDGV.Rows.Clear();
            //DisplayItemsDGV.Refresh();
            CustomerCB.SelectedIndex = -1;
            CategoryCB.SelectedIndex = -1;
            StoreCB.SelectedIndex = -1;
            ItemCB.SelectedIndex = -1;
            QuantityNUD.Value = 0;
            TotalAvailableTB.Text = "";
            InvoiceDateDTP.Value = DateTime.Now;
            WeightPerKgNUD.Value = 0;
            TotalWeightTB.Text = "";
            TotalPriceTB.Text = "";
        }
    }
}
