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
    public partial class PopUpForUomForm : Form
    {
        Utils utils;
        WriteToDatabase writeToDatabase;

        public PopUpForUomForm()
        {
            InitializeComponent();
            utils = new Utils();
            writeToDatabase = new WriteToDatabase();
        }

        private void AddNewUomBTN_Click(object sender, EventArgs e)
        {
            if (utils.isUomAlreadyPresent(NewUomTB.Text))
            {
                MessageBox.Show("Can not enter same UOM again", "UOM already exists.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                writeToDatabase.writeUomToDB(NewUomTB.Text);
                NewUomTB.Text = "";
                this.Dispose();
            }
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CloseNewCategoryBTN_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
