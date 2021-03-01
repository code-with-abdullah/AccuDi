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
    public partial class PopUpForItemCategory : Form
    {
        Utils utils;
        WriteToDatabase writeToDB;

        public PopUpForItemCategory()
        {
            InitializeComponent();

            utils = new Utils();
            writeToDB = new WriteToDatabase();
        }

        private void AddNewItemCategoryBTN_Click(object sender, EventArgs e)
        {
            if (utils.isCategoryAlreadyPresent(NewCategoryTB.Text))
            {
                MessageBox.Show("Can not enter same category again", "Category already exists.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                writeToDB.writeCategoryToDB(NewCategoryTB.Text);
                NewCategoryTB.Text = "";
                this.Dispose();
            }
        }

        private void CloseNewCategoryBTN_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
