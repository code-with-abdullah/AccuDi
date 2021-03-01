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
    public partial class WarehouseForm : Form
    {
        Utils utils;
        ReadFromDB readFromDatabase;
        WriteToDatabase writeToDatabase;
        DeleteFromDB deleteFromDatabase;
        UpdateInDB updateInDatabase;

        public WarehouseForm()
        {
            InitializeComponent();

            utils = new Utils();
            updateInDatabase = new UpdateInDB();
            readFromDatabase = new ReadFromDB();
            writeToDatabase = new WriteToDatabase();
            deleteFromDatabase = new DeleteFromDB();

            DisplayStoresDGV.DataSource = readFromDatabase.ReadStoresFromDB().Tables[0];
            DisplayStoresDGV.Columns[0].ReadOnly = true;
        }

        private void AddItemBTN_Click(object sender, EventArgs e)
        {
            if (utils.isStoreAlreadyPresent(NameTB.Text))
            {
                MessageBox.Show("Store with the same name is already present.", "Store already present.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (NameTB.Text == "")
                {
                    MessageBox.Show("Please enter a name to continue", "Name field empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int result = writeToDatabase.writeStoreToDB(NameTB.Text, CodeTB.Text, AreaTB.Text, CityTB.Text);
                if (result < 0)
                {
                    MessageBox.Show("There was an error in adding this store to database", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    NameTB.Text = "";
                    CodeTB.Text = "";
                    AreaTB.Text = "";
                    CityTB.Text = "";

                    DisplayStoresDGV.DataSource = readFromDatabase.ReadStoresFromDB().Tables[0];
                }
            }
        }

        private void DisplayStoresDGV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewRow r in DisplayStoresDGV.SelectedRows)
                {
                    string name = r.Cells[0].Value.ToString();
                    if (deleteFromDatabase.deleteStoreFromDB(name) < 0) 
                    {
                        MessageBox.Show("Deletion in database was unsuccessful", "Error while deleting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                DisplayStoresDGV.DataSource = readFromDatabase.ReadStoresFromDB().Tables[0];
            }
        }

        private void DisplayStoresDGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int row = DisplayStoresDGV.CurrentCell.RowIndex;

            string name = DisplayStoresDGV.Rows[row].Cells[0].Value.ToString();
            string city = DisplayStoresDGV.Rows[row].Cells[1].Value.ToString();
            string area = DisplayStoresDGV.Rows[row].Cells[2].Value.ToString();
            string code = DisplayStoresDGV.Rows[row].Cells[3].Value.ToString();
            if (updateInDatabase.updateStoreInDatabase(name, city, area, code) < 0)
            {
                MessageBox.Show("Update in database was unsuccessful", "Error while updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
