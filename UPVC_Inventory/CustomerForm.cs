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
    public partial class CustomerForm : Form
    {
        Utils utils;
        WriteToDatabase writeToDatabase;
        ReadFromDB readFromDatabase;
        DeleteFromDB deleteFromDatabase;
        UpdateInDB updateInDatabase;

        public CustomerForm()
        {
            InitializeComponent();

            utils = new Utils();
            updateInDatabase = new UpdateInDB();
            readFromDatabase = new ReadFromDB();
            writeToDatabase = new WriteToDatabase();
            deleteFromDatabase = new DeleteFromDB();

            DisplayCustomersDGV.DataSource = readFromDatabase.ReadCustomersFromDB_updatedFunction().Tables[0];
            DisplayCustomersDGV.Columns[0].ReadOnly = true;
        }

        private void AddCustomerBTN_Click(object sender, EventArgs e)
        {
            if (utils.isCustomerAlreadyPresent(NameTB.Text))
            {
                MessageBox.Show("Customer with the same name is already present.", "Customer already present.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(NameTB.Text == "")
                {
                    MessageBox.Show("Please enter a name to continue", "Name field empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int result = writeToDatabase.writeCustomerToDB_updatedFunction(NameTB.Text, PhoneTB.Text, AreaTB.Text, CityTB.Text, NtnTB.Text);
                if (result < 0)
                {
                    MessageBox.Show("There was an error in adding this store to database", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    NameTB.Text = "";
                    PhoneTB.Text = "";
                    AreaTB.Text = "";
                    CityTB.Text = "";
                    NtnTB.Text = "";

                    DisplayCustomersDGV.DataSource = readFromDatabase.ReadCustomersFromDB_updatedFunction().Tables[0];
                    DisplayCustomersDGV.Columns[0].ReadOnly = true;
                }
            }
        }

        private void DisplayCustomersDGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int row = DisplayCustomersDGV.CurrentCell.RowIndex;

            string name = DisplayCustomersDGV.Rows[row].Cells[0].Value.ToString();
            string phoneNo = DisplayCustomersDGV.Rows[row].Cells[1].Value.ToString();
            string area = DisplayCustomersDGV.Rows[row].Cells[2].Value.ToString();
            string city = DisplayCustomersDGV.Rows[row].Cells[3].Value.ToString();
            string ntnNo = DisplayCustomersDGV.Rows[row].Cells[4].Value.ToString();

            if (updateInDatabase.updateCustomerInDatabase_updatedFunction(name, phoneNo, area, city, ntnNo) < 0)
            {
                MessageBox.Show("Update in database was unsuccessful", "Error while updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayCustomersDGV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewRow r in DisplayCustomersDGV.SelectedRows)
                {
                    string name = r.Cells[0].Value.ToString();
                    if (deleteFromDatabase.deleteCustomerFromDB(name) < 0)
                    {
                        MessageBox.Show("Deletion in database was unsuccessful", "Error while deleting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                DisplayCustomersDGV.DataSource = readFromDatabase.ReadCustomersFromDB_updatedFunction().Tables[0];
            }
        }
    }
}
