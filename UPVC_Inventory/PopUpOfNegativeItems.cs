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
    public partial class PopUpOfNegativeItems : Form
    {
        public PopUpOfNegativeItems()
        {
            InitializeComponent();

            ReadFromDB readFromDB = new ReadFromDB();
            Dictionary<string, string> keyValuePairs = readFromDB.ReadAllNegativeItemsFromInventory();

            DisplayNegativeItemsDGV.Columns.Add("Item", "Item");
            DisplayNegativeItemsDGV.Columns.Add("Quantity", "Quantity");
            foreach (string item in keyValuePairs.Keys)
            {
                DisplayNegativeItemsDGV.Rows.Add(item, keyValuePairs[item]);
            }
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
