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
    public partial class ViewInventoryForm : Form
    {
        ReadFromDB readFromDatabase;
        public ViewInventoryForm()
        {
            readFromDatabase = new ReadFromDB();

            InitializeComponent();

            // Populating categories in ComboBox
            DataSet categories = readFromDatabase.ReadCategoriesFromDB();
            foreach (DataRow dataRow in categories.Tables[0].Rows)
            {
                CategoryCB.Items.Add(dataRow[0].ToString());
            }
        }

        private void CategoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemCB.Text = "";
            ItemCB.Items.Clear();

            if (ItemCB.Enabled == false)
            {
                ItemCB.Enabled = true;
            }

            ItemCB.Items.Add("All");
            // Populating items based on categories in ComboBox
            DataSet items = readFromDatabase.ReadItemBasedOnCategoryFromDB(CategoryCB.SelectedItem.ToString());
            foreach (DataRow dataRow in items.Tables[0].Rows)
            {
                ItemCB.Items.Add(dataRow[0].ToString());
            }
            ItemCB.SelectedIndex = 0;
            //DisplayInventoriesDGV.DataSource = null;
        }

        private void ItemCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ItemCB.Text == "All")
            {
                DisplayInventoriesDGV.DataSource = readFromDatabase.ReadInventoryFromDBUsingCategoryOnly(CategoryCB.Text).Tables[0];
            }
            else
            {
                DisplayInventoriesDGV.DataSource = readFromDatabase.ReadInventoryFromDBUsingCategoryAndItem(CategoryCB.Text, ItemCB.Text).Tables[0];
            }
        }
    }
}