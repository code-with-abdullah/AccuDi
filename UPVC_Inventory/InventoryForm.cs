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

namespace UPVC_Inventory
{
    public partial class InventoryForm : Form
    {
        Utils utils;
        WriteToDatabase writeToDatabase;
        ReadFromDB readFromDatabase;
        DeleteFromDB deleteFromDatabase;
        UpdateInDB updateInDatabase;

        public InventoryForm()
        {
            InitializeComponent();
            
            utils = new Utils();
            updateInDatabase = new UpdateInDB();
            readFromDatabase = new ReadFromDB();
            writeToDatabase = new WriteToDatabase();
            deleteFromDatabase = new DeleteFromDB();

            // Populating categories in ComboBox
            DataSet categories = readFromDatabase.ReadCategoriesFromDB();
            foreach (DataRow dataRow in categories.Tables[0].Rows)
            {
                CategoryCB.Items.Add(dataRow[0].ToString());
            }

            // Populating vendors in ComboBox
            DataSet vendors = readFromDatabase.ReadVendorNamesFromDB();
            foreach (DataRow dataRow in vendors.Tables[0].Rows)
            {
                VendorCB.Items.Add(dataRow[0].ToString());
            }

            // Populating stores in ComboBox
            DataSet stores = readFromDatabase.ReadStoreNamesFromDB();
            foreach (DataRow dataRow in stores.Tables[0].Rows)
            {
                StoreCB.Items.Add(dataRow[0].ToString());
            }

            // Populating items based on categories in ComboBox
            DataSet items = readFromDatabase.ReadItemBasedOnCategoryFromDB(CategoryCB.Items[0].ToString());
            foreach (DataRow dataRow in items.Tables[0].Rows)
            {
                ItemCB.Items.Add(dataRow[0].ToString());
            }

            ExpiryDateDTP.Value = DateTime.Now;
        }

        private void AddInventoryBTN_Click(object sender, EventArgs e)
        {
            if (CategoryCB.SelectedIndex < 0)
            {
                MessageBox.Show("Select category");
                return;
            }
            if (VendorCB.SelectedIndex < 0)
            {
                MessageBox.Show("Select vendor");
                return;
            }
            if (ItemCB.SelectedIndex < 0)
            {
                MessageBox.Show("Select item");
                return;
            }
            if (StoreCB.SelectedIndex < 0)
            {
                MessageBox.Show("Select store");
                return;
            }

            /* this code was for updation and is being replaced by First In First Out */

            //if (utils.isItemPresentInInventory(ItemCB.SelectedItem.ToString(), CategoryCB.SelectedItem.ToString(), StoreCB.SelectedItem.ToString()))
            //{
            //    int result = updateInDatabase.updateInventoryBasedOnSameItem(ItemCB.SelectedItem.ToString(), 
            //        CategoryCB.SelectedItem.ToString(), 
            //        StoreCB.SelectedItem.ToString(),
            //        VendorCB.SelectedItem.ToString(),
            //        SerialNoTB.Text,
            //        QuantityTB.Value.ToString(),
            //        ExpiryDateDTP.Value);
            //    if(result > 0)
            //    {
            //        MessageBox.Show("This item was already present and has been updated", "Item updated in inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show("There was an error in updating this inventory to database", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }


            //}
            //else {
       
            int result = writeToDatabase.writeInventoryToDB_updatedFunction(
            CategoryCB.SelectedItem.ToString(),
            VendorCB.SelectedItem.ToString(),
            ItemCB.SelectedItem.ToString(),
            StoreCB.SelectedItem.ToString(),
            SerialNoTB.Text,
            float.Parse(QuantityTB.Text),
            DateTime.Now,
            ExpiryDateDTP.Value,
            (float)PurchasePriceNUD.Value,
            (float)SalePriceNUD.Value
            );
            if (result < 0)
            {
                MessageBox.Show("There was an error in adding this inventory to database", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                resetFormFields();

                MessageBox.Show("Added to inventory successfully", "Inventory updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            //}
        }

        private void CategoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemCB.Items.Clear();
            ItemCB.Text = "";

            // Populating items based on categories in ComboBox
            if (CategoryCB.SelectedIndex != -1)
            {
                DataSet items = readFromDatabase.ReadItemBasedOnCategoryFromDB(CategoryCB.SelectedItem.ToString());
                foreach (DataRow dataRow in items.Tables[0].Rows)
                {
                    ItemCB.Items.Add(dataRow[0].ToString());
                }
            }
        }

        #region removed code

        private void constructor()
        {
            //DisplayInventoriesDGV.DataSource = readFromDatabase.ReadInventoryFromDB().Tables[0];

            //DisplayInventoriesDGV.Columns[0].ReadOnly = true;
            //DisplayInventoriesDGV.Columns[1].ReadOnly = true;
            //DisplayInventoriesDGV.Columns[2].ReadOnly = true;
        }

        private void DisplayInventoriesDGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //int row = DisplayInventoriesDGV.CurrentCell.RowIndex;

            //string item = DisplayInventoriesDGV.Rows[row].Cells[2].Value.ToString();
            //string quantity = DisplayInventoriesDGV.Rows[row].Cells[3].Value.ToString();

            //if (updateInDatabase.updateInventoryInDatabase(item, quantity) < 0)
            //{
            //    MessageBox.Show("Update in database was unsuccessful", "Error while updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void DisplayInventoriesDGV_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Delete)
            //{
            //    foreach (DataGridViewRow r in DisplayInventoriesDGV.SelectedRows)
            //    {
            //        string name = r.Cells[0].Value.ToString();
            //        if (deleteFromDatabase.deleteInventoryFromDB(name) < 0)
            //        {
            //            MessageBox.Show("Deletion in database was unsuccessful", "Error while deleting", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //    DisplayInventoriesDGV.DataSource = readFromDatabase.ReadInventoryFromDB().Tables[0];
            //}
        }

        #endregion

        private void ViewInventoryBTN_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void resetFormFields()
        {
            CategoryCB.SelectedIndex = 0;
            VendorCB.SelectedIndex = -1;
            ItemCB.SelectedIndex = -1;
            StoreCB.SelectedIndex = -1;
            SerialNoTB.Text = "";
            QuantityTB.Text = "";
            ExpiryDateDTP.Value = DateTime.Now;
            PurchasePriceNUD.Value = decimal.Parse(0.ToString());
            SalePriceNUD.Value = decimal.Parse(0.ToString());
        }
    }
}
