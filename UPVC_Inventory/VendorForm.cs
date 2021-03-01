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
    public partial class VendorForm : Form
    {
        Utils utils;
        WriteToDatabase writeToDatabase;
        ReadFromDB readFromDatabase;
        DeleteFromDB deleteFromDatabase;
        UpdateInDB updateInDatabase;

        public VendorForm()
        {
            InitializeComponent();

            utils = new Utils();
            updateInDatabase = new UpdateInDB();
            readFromDatabase = new ReadFromDB();
            writeToDatabase = new WriteToDatabase();
            deleteFromDatabase = new DeleteFromDB();

            DisplayVendorDGV.DataSource = readFromDatabase.ReadVendorsFromDB().Tables[0];
            DisplayVendorDGV.Columns[0].ReadOnly = true;
        }

        private void AddItemBTN_Click(object sender, EventArgs e)
        {
            if (utils.isVendorAlreadyPresent(NameTB.Text))
            {
                MessageBox.Show("Vendor with the same name is already present.", "Vendor already present.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (NameTB.Text == "")
                {
                    MessageBox.Show("Please enter a name to continue", "Name field empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int result = writeToDatabase.writeVendorToDB(NameTB.Text, WebsiteTB.Text, PhoneTB.Text, CityTB.Text, CountryTB.Text, RepresentativeTB.Text, CellNoTB.Text, EmailTB.Text);
                if (result < 0)
                {
                    MessageBox.Show("There was an error in adding this store to database", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    NameTB.Text = "";
                    WebsiteTB.Text = "";
                    PhoneTB.Text = "";
                    CityTB.Text = "";
                    CountryTB.Text = "";
                    RepresentativeTB.Text = "";
                    CellNoTB.Text = "";
                    EmailTB.Text = "";

                    DisplayVendorDGV.DataSource = readFromDatabase.ReadVendorsFromDB().Tables[0];
                    DisplayVendorDGV.Columns[0].ReadOnly = true;
                }
            }
        }

        private void DisplayVendorDGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int row = DisplayVendorDGV.CurrentCell.RowIndex;

            string name = DisplayVendorDGV.Rows[row].Cells[0].Value.ToString();
            string website = DisplayVendorDGV.Rows[row].Cells[1].Value.ToString();
            string phoneNo = DisplayVendorDGV.Rows[row].Cells[2].Value.ToString();
            string city = DisplayVendorDGV.Rows[row].Cells[3].Value.ToString();
            string country = DisplayVendorDGV.Rows[row].Cells[4].Value.ToString();
            string representative = DisplayVendorDGV.Rows[row].Cells[5].Value.ToString();
            string cellNo = DisplayVendorDGV.Rows[row].Cells[6].Value.ToString();
            string email = DisplayVendorDGV.Rows[row].Cells[7].Value.ToString();
            if (updateInDatabase.updateVendorInDatabase(name, website, phoneNo, city, country, representative, cellNo, email) < 0)
            {
                MessageBox.Show("Update in database was unsuccessful", "Error while updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayVendorDGV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewRow r in DisplayVendorDGV.SelectedRows)
                {
                    string name = r.Cells[0].Value.ToString();
                    if (deleteFromDatabase.deleteVendorFromDB(name) < 0)
                    {
                        MessageBox.Show("Deletion in database was unsuccessful", "Error while deleting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                DisplayVendorDGV.DataSource = readFromDatabase.ReadVendorsFromDB().Tables[0];
            }
        }
    }
}
