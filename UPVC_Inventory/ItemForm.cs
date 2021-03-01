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
    public partial class ItemForm : Form
    {
        Utils utils;
        ReadFromDB readFromDatabase;
        WriteToDatabase writeToDatabase;
        UpdateInDB updateInDatabase;
        DeleteFromDB deleteFromDatabase;

        public ItemForm()
        {
            InitializeComponent();

            utils = new Utils();
            readFromDatabase = new ReadFromDB();
            writeToDatabase = new WriteToDatabase();
            updateInDatabase = new UpdateInDB();
            deleteFromDatabase = new DeleteFromDB();

            DisplayItemsDGV.DataSource = readFromDatabase.ReadItemsFromDB_updated().Tables[0];
            DisplayItemsDGV.Columns[0].ReadOnly = true;
            DisplayItemsDGV.Columns[1].ReadOnly = true;
            DisplayItemsDGV.Columns[4].ReadOnly = true;

            // Populating categories in ComboBox
            DataSet categories = readFromDatabase.ReadCategoriesFromDB();
            foreach (DataRow dataRow in categories.Tables[0].Rows)
            {
                CategoryCB.Items.Add(dataRow[0].ToString());
            }

            DataSet uoms = readFromDatabase.ReadUomFromDB();
            foreach (DataRow dataRow in uoms.Tables[0].Rows)
            {
                UomCB.Items.Add(dataRow[0].ToString());
            }

        }

        private void AddItemBTN_Click(object sender, EventArgs e)
        {
            if (utils.isItemAlreadyPresent(NameTB.Text))
            {
                MessageBox.Show("Item with the same name is already present.\nEnter a different named item.", "Item already present.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (NameTB.Text == "")
                {
                    MessageBox.Show("Please enter a name to continue", "Name field empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int result = writeToDatabase.writeItemToDB_updatedFunction(
                CategoryCB.SelectedItem.ToString(),
                NameTB.Text,
                CodeTB.Text,
                SerialNoTB.Text,
                UomCB.Text,
                ValueTB.Text,
                LengthTB.Text,
                WidthTB.Text);

                if (result < 0)
                {
                    MessageBox.Show("There was an error in adding this store to database", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CategoryCB.SelectedIndex = -1;
                    //VendorCB.SelectedIndex = -1;
                    NameTB.Text = "";
                    CodeTB.Text = "";
                    SerialNoTB.Text = "";
                    UomCB.SelectedIndex= -1;
                    ValueTB.Text = "";
                    LengthTB.Value = 0;
                    WidthTB.Value = 0;

                    DisplayItemsDGV.DataSource = readFromDatabase.ReadItemsFromDB_updated().Tables[0];
                    DisplayItemsDGV.Columns[0].ReadOnly = true;
                    DisplayItemsDGV.Columns[1].ReadOnly = true;
                    DisplayItemsDGV.Columns[4].ReadOnly = true;
                }
            }
        }

        private void AddItemCategoryBTN_Click(object sender, EventArgs e)
        {
            PopUpForItemCategory popUp = new PopUpForItemCategory();
            this.Cursor = Cursors.No;
            this.Enabled = false;

            popUp.FormClosing += ClosingCategoryPopUp;
            popUp.Disposed += ClosingCategoryPopUp;

            popUp.ShowDialog();
        }

        private void ClosingCategoryPopUp(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            this.Enabled = true;

            DataSet categories = readFromDatabase.ReadCategoriesFromDB();
            CategoryCB.Items.Clear();

            foreach (DataRow dataRow in categories.Tables[0].Rows)
            {
                CategoryCB.Items.Add(dataRow[0].ToString());
            }
        }

        private void DisplayItemsDGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int row = DisplayItemsDGV.CurrentCell.RowIndex;

            string name = DisplayItemsDGV.Rows[row].Cells[1].Value.ToString();
            string code = DisplayItemsDGV.Rows[row].Cells[2].Value.ToString();
            string serialNo = DisplayItemsDGV.Rows[row].Cells[3].Value.ToString();
            string uom = DisplayItemsDGV.Rows[row].Cells[4].Value.ToString();
            string value = DisplayItemsDGV.Rows[row].Cells[5].Value.ToString();
            string length = DisplayItemsDGV.Rows[row].Cells[6].Value.ToString();
            string width = DisplayItemsDGV.Rows[row].Cells[7].Value.ToString();

            if(length == "")
            {
                length = "0";
            }
            if (width == "")
            {
                width= "0";
            }

            if (updateInDatabase.updateItemInDatabase(name, code, serialNo, uom, value, length, width) < 0)
            {
                MessageBox.Show("Update in database was unsuccessful", "Error while updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayItemsDGV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewRow r in DisplayItemsDGV.SelectedRows)
                {
                    string name = r.Cells[1].Value.ToString();

                    if (deleteFromDatabase.deleteItemFromDB(name) < 0)
                    {
                        MessageBox.Show("Deletion in database was unsuccessful", "Error while deleting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                DisplayItemsDGV.DataSource = readFromDatabase.ReadItemsFromDB_updated().Tables[0];
            }
        }

        private void AddItemUomBTN_Click(object sender, EventArgs e)
        {
            PopUpForUomForm popUpUomForm = new PopUpForUomForm();
            this.Cursor = Cursors.No;
            this.Enabled = false;

            popUpUomForm.FormClosing += ClosingUomPopUp;
            popUpUomForm.Disposed += ClosingUomPopUp;

            popUpUomForm.ShowDialog();
        }

        private void ClosingUomPopUp(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            this.Enabled = true;

            DataSet categories = readFromDatabase.ReadUomFromDB();
            UomCB.Items.Clear();

            foreach (DataRow dataRow in categories.Tables[0].Rows)
            {
                UomCB.Items.Add(dataRow[0].ToString());
            }
        }
    }
}
