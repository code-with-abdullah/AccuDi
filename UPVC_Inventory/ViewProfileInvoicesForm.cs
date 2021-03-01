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
    public partial class ViewProfileInvoicesForm : Form
    {
        ReadFromDB readFromDatabase;
        public ViewProfileInvoicesForm()
        {
            InitializeComponent();

            readFromDatabase = new ReadFromDB();

            // populate customers
            DataSet customers = readFromDatabase.ReadCustomerNamesFromDB();
            CustomerCB.Items.Add("All");
            foreach (DataRow dataRow in customers.Tables[0].Rows)
            {
                CustomerCB.Items.Add(dataRow[0].ToString());
            }

            DisplayInvoicesDGV.DataSource = readFromDatabase.ReadAllInvoicesFromDB("All", "All", "", "").Tables[0];

            CustomerCB.Text = "All";
            StatusCB.Text = "All";

            addViewBtnColumn();
        }

        private void StatusCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            rePopulateDGV();
        }

        private void FromDTP_ValueChanged(object sender, EventArgs e)
        {
            rePopulateDGV();
        }

        private void CustomerCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CustomerCB.Text == "All")
            {
                this.PrintBTN.Visible = false;
            }
            else
            {
                if (DisplayInvoicesDGV.Rows.Count >= 0)
                {
                    this.PrintBTN.Visible = true;
                }
            }
            rePopulateDGV();
        }

        private void ToDTP_ValueChanged(object sender, EventArgs e)
        {
            rePopulateDGV();
        }

        private void rePopulateDGV()
        {
            string status = StatusCB.Text;

            if (status == "Open")
            {
                status = "1";
            }
            else if (status == "Closed")
            {
                status = "0";
            }
            else
            {
                status = "1";
            }
            DisplayInvoicesDGV.DataSource = readFromDatabase.ReadAllInvoicesFromDB(
                CustomerCB.Text,
                status,
                FromDTP.Value.ToString("yyyy-MM-dd"),
                ToDTP.Value.ToString("yyyy-MM-dd")
                ).Tables[0];
            addViewBtnColumn();
        }

        private void addViewBtnColumn()
        {
            DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn();
            viewButtonColumn.Name = "View Invoices";
            viewButtonColumn.Text = "View";
            viewButtonColumn.FlatStyle = FlatStyle.Flat;
            

            int columnIndex = 7;
            if (DisplayInvoicesDGV.Columns["View Invoices"] == null)
            {
                DisplayInvoicesDGV.Columns.Insert(columnIndex,viewButtonColumn);
            }
            viewButtonColumn.UseColumnTextForButtonValue = true;
        }

        private void DisplayInvoicesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
         {
            if (e.ColumnIndex == DisplayInvoicesDGV.Columns["View Invoices"].Index)
            {
                string invoiceId = DisplayInvoicesDGV.Rows[e.RowIndex].Cells["Invoice No"].Value.ToString();
                new Utils().openInovicePdfFromFile(invoiceId);
            }
        }

        private void DisplayInvoicesDGV_CellMouseEn(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DisplayInvoicesDGV.Columns["View Invoices"].Index)
            {
                DisplayInvoicesDGV.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor= Color.FromArgb(178, 8, 25);
                DisplayInvoicesDGV.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void DisplayInvoicesDGV_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DisplayInvoicesDGV.Columns["View Invoices"].Index)
            {
                DisplayInvoicesDGV.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.FromArgb(178, 8, 25);
                DisplayInvoicesDGV.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void PrintBTN_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("InvoiceNo");
            dataTable.Columns.Add("Date");
            dataTable.Columns.Add("TotalWeight");
            dataTable.Columns.Add("TotalAmount");

            foreach(DataGridViewRow row in DisplayInvoicesDGV.Rows)
            {
                dataTable.Rows.Add(row.Cells["Invoice No"].Value,
                    row.Cells["InvoiceDate"].Value,
                    row.Cells["TotalWeight"].Value,
                    row.Cells["TotalAmount"].Value);
            }

            new Utils().generatePdfOfAllInvoicesOfACustomer(CustomerCB.Text, dataTable, FromDTP.Value, ToDTP.Value);
        }
    }
}
