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
using System.Windows.Forms.DataVisualization.Charting;

namespace UPVC_Inventory
{
    public partial class DashboardForm : Form
    {
        Utils utils;

        public DashboardForm()
        {
            InitializeComponent();
            utils = new Utils();

            NoOfWarehousesLBL.Text = utils.getNoOfStores();
            NoOfInventoryItemsLBL.Text = utils.getNoOfInventoryItems();
            NoOfTotalItemsLBL.Text = utils.getNoOfTotalItems();
            NoOfCategoriesLBL.Text = utils.getNoOfItemCategories();
            NoOfVendorsLBL.Text = utils.getNoOfVendors();
            NoOfCustomersLBL.Text = utils.getNoOfCustomers();

            Dictionary<string, float> sales = utils.getAllSalesOfThisMonth();

            BarChartOfDailySales.Titles.Add("DAILY SALES OF THIS MONTH");

            BarChartOfDailySales.Titles[0].Font = new Font("Segoe UI", 16f, FontStyle.Bold);
            BarChartOfDailySales.ChartAreas[0].AxisX.Title = "Date of the month";
            BarChartOfDailySales.ChartAreas[0].AxisX.TitleFont = new Font("Segoe UI", 14f, FontStyle.Bold);
            BarChartOfDailySales.ChartAreas[0].AxisY.Title = "Amount";
            BarChartOfDailySales.ChartAreas[0].AxisY.TitleFont = new Font("Segoe UI", 14f, FontStyle.Bold);

            BarChartOfDailySales.Series.Add("Sales");
            BarChartOfDailySales.Series["Sales"].LegendText = "Sales";
            BarChartOfDailySales.Series["Sales"].IsValueShownAsLabel = true;
            BarChartOfDailySales.Legends.Add("Sales");

            foreach (string date in sales.Keys)
            {
                string dateOfMonth = Convert.ToDateTime(date).ToString("dd");

                BarChartOfDailySales.Series["Sales"].Points.AddXY(double.Parse(dateOfMonth), double.Parse(sales[date].ToString()));
            }


            Dictionary<string, float> purchases = utils.getAllPurchasesOfThisMonth();
            BarChartOfDailySales.Series.Add("Purchases");
            BarChartOfDailySales.Series["Purchases"].LegendText = "Purchases";
            BarChartOfDailySales.Series["Purchases"].IsValueShownAsLabel = true;
            BarChartOfDailySales.Legends.Add("Purchases");

            foreach (string date in purchases.Keys)
            {
                string dateOfMonth = Convert.ToDateTime(date).ToString("dd");

                BarChartOfDailySales.Series["Purchases"].Points.AddXY(double.Parse(dateOfMonth), double.Parse(purchases[date].ToString()));
            }
        }
    }
}
