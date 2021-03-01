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
    public partial class FabricatorsForm : Form
    {
        System.Collections.ArrayList listOfAllOrders ;
        System.Collections.ArrayList listOftemsInAnOrder;
        Dictionary<string, object> dictionaryOfItemsInCurrentOrder;
        Utils utils;

        double totalSqFtGlobal = 0.00;
        double pricePerSqFtGlobal = 0.00;
        double totalPriceGlobal = 0.00;

        public FabricatorsForm()
        {
            InitializeComponent();

            utils = new Utils();
            listOfAllOrders = new System.Collections.ArrayList();
            listOftemsInAnOrder = new System.Collections.ArrayList();
            dictionaryOfItemsInCurrentOrder = new Dictionary<string, object>();

            this.WidthNUD.ValueChanged += new System.EventHandler(this.valueChanged);
            this.HeightNUD.ValueChanged += new System.EventHandler(this.valueChanged);
            this.QuantityNUD.ValueChanged += new System.EventHandler(this.valueChanged);
            this.WastageOfMaterialPercentageNUD.ValueChanged += new System.EventHandler(this.valueChanged);
            this.RateFor5mmGlassPrice.ValueChanged += new System.EventHandler(this.valueChanged);
            this.RateForInsectScreenPrice.ValueChanged += new System.EventHandler(this.valueChanged);
            this.RateForSqFtFabricationPrice.ValueChanged += new System.EventHandler(this.valueChanged);
            this.RatePerSqFtForInstallationPrice.ValueChanged += new System.EventHandler(this.valueChanged);
            this.RateForSealantPrice.ValueChanged += new System.EventHandler(this.valueChanged);
            this.MarkUpAndOhExpensesUpNUD.ValueChanged += new System.EventHandler(this.valueChanged);

            Section1LBL.Text = "S\nE\nC\nT\nI\nO\nN\n\n1";
            Section2LBL.Text = "S\nE\nC\nT\nI\nO\nN\n\n2";
            Section3LBL.Text = "S\nE\nC\nT\nI\nO\nN\n\n3";
            Section4LBL.Text = "S\nE\nC\nT\nI\nO\nN\n\n4";
        }

        private void valueChanged(object sender, EventArgs e)
        {
            double c4 = (double)WidthNUD.Value;
            double c5 = (double)HeightNUD.Value;
            double c6 = (double)QuantityNUD.Value;

            #region Profile Description Calculations

            //= SUM((C4*2)+(C5*2))*C6|
            double slidingFrameRequiredLength = ( (c4 * 2) + (c5 * 2) ) * c6;
            double slidingFrame3TotalPkr = slidingFrameRequiredLength * double.Parse(SlidingFrame3PricePerFt.Text);
            SlidingFrame3RequiredLength.Text = slidingFrameRequiredLength.ToString("F");
            SlidingFrame3TotalPkr.Text = slidingFrame3TotalPkr.ToString("F");

            //= SUM((C5 * 4) + (C4 * 2)) * C6
            double slidingSashRequiredLength = ((c4 * 2) + (c5 * 4)) * c6;  // E-10
            double slidingSashTotalPkr = slidingSashRequiredLength * double.Parse(SlidingSashPricePerFt.Text);
            SlidingSlashRequiredLength.Text = slidingSashRequiredLength.ToString("F");
            SlidingSashTotalPkr.Text = slidingSashTotalPkr.ToString("F");

            // = SUM(E10 / 2) * C6
            double netSashRequiredLength = (slidingSashRequiredLength / 2) * c6;
            double netSashTotalPkr = netSashRequiredLength * double.Parse(NetSashPricePerFt.Text);
            NetSashRequiredLength.Text = netSashRequiredLength.ToString("F");
            NetSashTotalPkr.Text = netSashTotalPkr.ToString("F");

            // = E10/3
            double interlockRequiredLength = slidingSashRequiredLength / 3;
            double interlockTotalPkr = interlockRequiredLength * double.Parse(InterlockPricePerFt.Text);
            InterlockRequiredLength.Text = interlockRequiredLength.ToString("F");
            InterlockTotalPkr.Text = interlockTotalPkr.ToString("F");

            // = E10
            double beadingSgTotalPkr = slidingSashRequiredLength * double.Parse(BeadingSgPricePerFt.Text);
            BeadingSgRequiredLength.Text = slidingSashRequiredLength.ToString("F");
            BeadingSgTotalPkr.Text = beadingSgTotalPkr.ToString("F");

            double profileDescriptionTotalPkr =
                slidingFrame3TotalPkr +
                slidingSashTotalPkr +
                netSashTotalPkr+
                interlockTotalPkr +
                beadingSgTotalPkr;

            ProfileDescriptionTotalPkr.Text = profileDescriptionTotalPkr.ToString("F");

            #endregion


            #region Reinforcement Description Calculations

            // = E9
            double steelRiForFrameTotalPkr = slidingFrameRequiredLength * double.Parse(SteelRiForFramePricePerFt.Text);
            SteelRiForFrameRequiredLength.Text = slidingFrameRequiredLength.ToString("F");
            SteelRiForFrameTotalPkr.Text = steelRiForFrameTotalPkr.ToString("F");

            // = E10
            double steelRiForSashTotalPkr = slidingSashRequiredLength * double.Parse(SteelRiForSashPricePerFt.Text);
            SteelRiForSashRequiredLength.Text = slidingSashRequiredLength.ToString("F");
            SteelRiForSashTotalPkr.Text = steelRiForSashTotalPkr.ToString("F");

            // = E10 / 2
            double steelForScreenRequiredLength = slidingSashRequiredLength / 2;
            double steelForScreenTotalPkr = steelForScreenRequiredLength * double.Parse(SteelForScreenPricePerFt.Text);
            SteelForScreenRequiredLength.Text = steelForScreenRequiredLength.ToString("F");
            SteelForScreenTotalPkr.Text = steelForScreenTotalPkr.ToString("F");

            double reinforcementDescriptionTotalPkr =
                steelRiForFrameTotalPkr +
                steelRiForSashTotalPkr +
                steelForScreenTotalPkr;

            ReinforcementDescriptionTotalPkr.Text = reinforcementDescriptionTotalPkr.ToString("F");

            #endregion


            #region Gasket / Sales Description Calculations

            // = E10 * 2
            double glazingGasketRequiredLength = slidingSashRequiredLength * 2;
            double glazingGasketTotalPkr = glazingGasketRequiredLength * double.Parse(GlazingGasketPricePerM.Text);
            GlazingGasketRequiredLength.Text = glazingGasketRequiredLength.ToString("F");
            GlazingGasketTotalPkr.Text = glazingGasketTotalPkr.ToString("F");

            // = E12
            double insectScreenGasketTotalPkr = interlockRequiredLength * double.Parse(GlazingGasketPricePerM.Text);
            InsectScreenGasketRequiredLength.Text = interlockRequiredLength.ToString("F");
            InsectScreenGasketTotalPkr.Text = insectScreenGasketTotalPkr.ToString("F");

            // = 2
            double brushSealTotalPkr = 2 * float.Parse(BrushSealPricePerM.Text);
            BrushSealRequiredLength.Text = "2.00";
            BrushSealTotalPkr.Text = brushSealTotalPkr.ToString("F");

            double gasketSalesDescriptionTotalPkr =
                glazingGasketTotalPkr +
                insectScreenGasketTotalPkr +
                brushSealTotalPkr;

            GasketSealsDescriptionTotalPkr.Text = gasketSalesDescriptionTotalPkr.ToString("F");

            #endregion


            #region HardWare Description Calculations

            // = 2
            double rollersWheelsTotalPkr = 2 * double.Parse(RollerWheelsPricePerPc.Text);
            RollersForScreenRequiredQuantity.Text = "2.00";
            RollersWheelsTotalPkr.Text = rollersWheelsTotalPkr.ToString("F");

            // = c6
            double halfMoonLockTotalPkr = c6 * double.Parse(HalfMoonLockPricePerPc.Text);
            HalfMoonRequiredQuantity.Text = c6.ToString("F");
            HalfMoonLockTotalPkr.Text = halfMoonLockTotalPkr.ToString("F");

            // = 2
            double rollersForScreenTotalPkr = 2 * double.Parse(RollersForScreenPricePerPc.Text);
            RollersForScreenRequiredQuantity.Text = "2.00";
            RollersForScreenTotalPkr.Text = rollersForScreenTotalPkr.ToString("F");

            // = 0
            double hardwareTotalPkr = 0 * double.Parse(HardwarePricePerPc.Text);
            HardwareRequiredQuantity.Text = "0.00";
            HardwareTotalPkr.Text = hardwareTotalPkr.ToString("F");

            // = C4*C5*4
            double screwsDifferentTypeRequiredQuantity = c4 * c5 * 4;
            double screwsDifferentTypeTotalPkr = screwsDifferentTypeRequiredQuantity * float.Parse(ScrewsDifferentTypePricePerPc.Text);
            ScrewsDifferentTypeRequiredQuantity.Text = screwsDifferentTypeRequiredQuantity.ToString("F");
            ScrewsDifferentTypeTotalPkr.Text = screwsDifferentTypeTotalPkr.ToString("F");

            // C6 * 2
            double drainageCoverRequiredQuantity = c6 * 2;
            double drainageCoverTotalPkr = drainageCoverRequiredQuantity * float.Parse(DrainageCoverPricePerPc.Text);
            DrainageCoverRequiredQuantity.Text = drainageCoverRequiredQuantity.ToString("F");
            DrainageCoverTotalPkr.Text = drainageCoverTotalPkr.ToString("F");

            // C6 * 8
            double boltCoverInWhiteRequiredQuantity = c6 * 8;
            double boltCoverInWhiteTotalPkr = boltCoverInWhiteRequiredQuantity * float.Parse(BoltCoverInWhitePricePerPc.Text);
            BoltCoverInWhiteRequiredQuantity.Text = boltCoverInWhiteRequiredQuantity.ToString("F");
            BoltCoverInWhiteTotalPkr.Text = boltCoverInWhiteTotalPkr.ToString("F");

            double longFixingBoltTotalPkr = 12 * float.Parse(LongFixingBoltPricePerPc.Text);
            LongFixingBoltRequiredQuantity.Text = "12.00";
            LongFixingBoltTotalPkr.Text = longFixingBoltTotalPkr.ToString("F");

            double hardwareDescriptionTotalPkr = 
                rollersWheelsTotalPkr +
                halfMoonLockTotalPkr + 
                rollersForScreenTotalPkr + 
                hardwareTotalPkr +
                screwsDifferentTypeTotalPkr +
                drainageCoverTotalPkr + 
                boltCoverInWhiteTotalPkr +
                longFixingBoltTotalPkr;

            HardwareDescriptionTotalPkr.Text = hardwareDescriptionTotalPkr.ToString("F");

            #endregion


            #region Section 2 Calculations

            double subTotalTillSection2 =
                profileDescriptionTotalPkr +
                reinforcementDescriptionTotalPkr +
                gasketSalesDescriptionTotalPkr +
                hardwareDescriptionTotalPkr;

            SubTotalTillSection2.Text = subTotalTillSection2.ToString("F");

            double wastageOfMaterialsPercentage = (double)WastageOfMaterialPercentageNUD.Value;

            double wastageOfMaterialsPrice = subTotalTillSection2 * wastageOfMaterialsPercentage / 100.0;
            WastageOfMaterialPrice.Text = wastageOfMaterialsPrice.ToString("F");

            double costOfMaterials = wastageOfMaterialsPrice + subTotalTillSection2;

            CostOfMaterials.Text = costOfMaterials.ToString("F");

            #endregion


            #region Section 3 Calculations

            double rateFor5mmGlassRequiredQuantity = 0;
            double rateFor5mmGlassTotalUsd = rateFor5mmGlassRequiredQuantity * (double)RateFor5mmGlassPrice.Value;
            RateFor5mmGlassRequiredQuantity.Text = rateFor5mmGlassRequiredQuantity.ToString("F");
            RateFor5mmGlassTotalUsd.Text = rateFor5mmGlassTotalUsd.ToString("F");


            double rateForInsectScreenRequiredQuantity = 105.00;
            double rateForInspectScreenTotalUsd = rateForInsectScreenRequiredQuantity * (double)RateForInsectScreenPrice.Value;
            RateForInsectScreenRequiredQuantity.Text = rateForInsectScreenRequiredQuantity.ToString("F");
            RateForInspectScreenTotalUsd.Text = rateForInspectScreenTotalUsd.ToString();

            double rateForSqFtFabricationRequiredQuantity = 0;
            double ratePerSqFtFabricationTotalUsd = rateForSqFtFabricationRequiredQuantity * (double)RateForSqFtFabricationPrice.Value;
            RateForSqFtFabricationRequiredQuantity.Text = rateForSqFtFabricationRequiredQuantity.ToString("F");
            RatePerSqFtFabricationTotalUsd.Text = ratePerSqFtFabricationTotalUsd.ToString("F");

            double ratePerSqFtForInstallationRequiredQuantity = 0;
            double ratePerSqFtForInstallationTotalUsd = ratePerSqFtForInstallationRequiredQuantity * (double)RatePerSqFtForInstallationPrice.Value;
            RatePerSqFtForInstallationRequiredQuantity.Text = rateForSqFtFabricationRequiredQuantity.ToString("F");
            RatePerSqFtForInstallationTotalUsd.Text = ratePerSqFtForInstallationTotalUsd.ToString("F");

            // = C4 * C5 / 10
            double rateForSealantRequiredQuantity = c4 * c5 / 10;
            double rateOfSealantTotalUsd = rateForSealantRequiredQuantity * (double)RateForSealantPrice.Value;
            RateForSealantRequiredQuantity.Text = rateForSealantRequiredQuantity.ToString("F");
            RateOfSealantTotalUsd.Text = rateOfSealantTotalUsd.ToString("F");

            double descriptionTotal =
                rateFor5mmGlassTotalUsd +
                rateForInspectScreenTotalUsd +
                ratePerSqFtFabricationTotalUsd +
                ratePerSqFtForInstallationTotalUsd +
                rateOfSealantTotalUsd;

            DescriptionTotal.Text = descriptionTotal.ToString("F");

            #endregion


            #region Section 4 Calculations

            MaterialsFromWintechSummary.Text = costOfMaterials.ToString("F");
            MaterialsFromMarketSummary.Text = descriptionTotal.ToString("F");

            double subTotalSummary =costOfMaterials + descriptionTotal;

            SubTotalSummary.Text = subTotalSummary.ToString("F");

            double markupAndOhExpensesUp = subTotalSummary * (double)MarkUpAndOhExpensesUpNUD.Value / 100;

            MarkupAndOhExpensesUp.Text = markupAndOhExpensesUp.ToString("F");

            double totalSummary = subTotalSummary + markupAndOhExpensesUp;

            TotalSummary.Text =  totalSummary.ToString("F");

            double pricePerSqFt = totalSummary / c4 / c5 / c6;

            PricePerSqFtSummary.Text = pricePerSqFt.ToString("F");

            #endregion

            totalSqFtGlobal = c4 * c5 * c6;
            pricePerSqFtGlobal = pricePerSqFt;
            totalPriceGlobal = totalSummary;

            TotalSFT.Text = totalSqFtGlobal.ToString("F");

            dictionaryOfItemsInCurrentOrder.Clear();

            dictionaryOfItemsInCurrentOrder.Add("SlidingFrame", slidingFrameRequiredLength);
            dictionaryOfItemsInCurrentOrder.Add("SlidingSash", slidingSashRequiredLength);
            dictionaryOfItemsInCurrentOrder.Add("NetSash", netSashRequiredLength);
            dictionaryOfItemsInCurrentOrder.Add("Interlock", interlockRequiredLength);
            dictionaryOfItemsInCurrentOrder.Add("BeadingSG", slidingSashRequiredLength); // same as sliding sash

            dictionaryOfItemsInCurrentOrder.Add("SteelRiForFrame", slidingFrameRequiredLength); // same as sliding frame
            dictionaryOfItemsInCurrentOrder.Add("SteelRiForSash", slidingSashRequiredLength); // same as sliding sash
            dictionaryOfItemsInCurrentOrder.Add("SteelForScreen", steelForScreenRequiredLength);

            dictionaryOfItemsInCurrentOrder.Add("GlazingGasket", glazingGasketRequiredLength);
            dictionaryOfItemsInCurrentOrder.Add("InsectScreenGasket", interlockRequiredLength);
            dictionaryOfItemsInCurrentOrder.Add("BrushSeal", 2);

            dictionaryOfItemsInCurrentOrder.Add("RollersWheels", 2);
            dictionaryOfItemsInCurrentOrder.Add("HalfMoonLock", c6);
            dictionaryOfItemsInCurrentOrder.Add("RollersForScreen", 2);
            dictionaryOfItemsInCurrentOrder.Add("Hardware", 0);
            dictionaryOfItemsInCurrentOrder.Add("ScrewsDifferentType", screwsDifferentTypeRequiredQuantity);
            dictionaryOfItemsInCurrentOrder.Add("DrainageCover", drainageCoverRequiredQuantity);
            dictionaryOfItemsInCurrentOrder.Add("BoltCover", boltCoverInWhiteRequiredQuantity);
            dictionaryOfItemsInCurrentOrder.Add("LongFixingBolt", 12);
        }

        private void AddToCurrentOrder_Click(object sender, EventArgs e)
        {
            if (DescriptionTB.Text == "")
            {
                MessageBox.Show("Enter a description", "No description found.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            #region dictionary of current order

            Dictionary<string, object> dictionaryOfCurrentOrder = new Dictionary<string, object>();
            dictionaryOfCurrentOrder.Add("Description", DescriptionTB.Text);
            dictionaryOfCurrentOrder.Add("Width", WidthNUD.Value);
            dictionaryOfCurrentOrder.Add("Height", HeightNUD.Value);
            dictionaryOfCurrentOrder.Add("Quantity", QuantityNUD.Value);
            dictionaryOfCurrentOrder.Add("PricePerSqFt", pricePerSqFtGlobal);
            dictionaryOfCurrentOrder.Add("TotalSqFt", totalSqFtGlobal);
            dictionaryOfCurrentOrder.Add("TotalPrice", totalPriceGlobal);
            dictionaryOfCurrentOrder.Add("WastagePercentage", WastageOfMaterialPercentageNUD.Value);
            dictionaryOfCurrentOrder.Add("RateOfGlass", RateFor5mmGlassPrice.Value);
            dictionaryOfCurrentOrder.Add("RateOfScreen", RateForInsectScreenPrice.Value);
            dictionaryOfCurrentOrder.Add("RateOfFabrications", RateForSqFtFabricationPrice.Value);
            dictionaryOfCurrentOrder.Add("RateOfInstallation", RatePerSqFtForInstallationPrice.Value);
            dictionaryOfCurrentOrder.Add("RateOfSealent", RateForSealantPrice.Value);
            dictionaryOfCurrentOrder.Add("MarkUp", MarkUpAndOhExpensesUpNUD.Value);

            #endregion

            listOfAllOrders.Add(dictionaryOfCurrentOrder);

            Dictionary<string, object> deepCopyOfItemsInCurrentOrder = new Dictionary<string, object>();
            // creating a deep copy and adding to list
            foreach (string key in dictionaryOfItemsInCurrentOrder.Keys)
            {
                deepCopyOfItemsInCurrentOrder.Add(key, dictionaryOfItemsInCurrentOrder[key]);
            }
            listOftemsInAnOrder.Add(deepCopyOfItemsInCurrentOrder);

            OrderCountLBL.Text = listOfAllOrders.Count.ToString();

            CreateInvoiceLBL.Visible = true;

            resetAllInputs();
        }

        private void CreateInvoiceLBL_Click(object sender, EventArgs e)
        {
            PopUpForFabricatorsInvoice popUpForFabricatorsInvoice = new PopUpForFabricatorsInvoice(listOfAllOrders, listOftemsInAnOrder);

            this.Enabled = false;
            popUpForFabricatorsInvoice.Show();

            popUpForFabricatorsInvoice.Disposed += popUpDisposed;
            popUpForFabricatorsInvoice.FormClosing += popUpDisposed;
        }

        public void popUpDisposed(object sender, EventArgs e)
        {
            this.Enabled = true;
            resetAllInputs();

            listOfAllOrders.Clear();

            OrderCountLBL.Text = "0";

            CreateInvoiceLBL.Visible = false;
        }

        public void resetAllInputs()
        {
            this.WidthNUD.Value = 0;
            this.HeightNUD.Value = 0;
            this.QuantityNUD.Value = 0;
            this.WastageOfMaterialPercentageNUD.Value = 0;
            this.RateFor5mmGlassPrice.Value = 0;
            this.RateForInsectScreenPrice.Value = 0;
            this.RateForSqFtFabricationPrice.Value = 0;
            this.RatePerSqFtForInstallationPrice.Value = 0;
            this.RateForSealantPrice.Value = 0;
            this.MarkUpAndOhExpensesUpNUD.Value = 0;

            this.DescriptionTB.Text = "";

            readConchItemValuesFromDatabase();
        }

        public void readConchItemValuesFromDatabase()
        {
            this.SlidingFrame3PricePerFt.Text = utils.getValueFromItemUsingNames("SlidingFrame", "Conch").ToString("F");
            this.SlidingSashPricePerFt.Text = utils.getValueFromItemUsingNames("SlidingSash", "Conch").ToString("F");
            this.NetSashPricePerFt.Text = utils.getValueFromItemUsingNames("NetSash", "Conch").ToString("F");
            this.InterlockPricePerFt.Text = utils.getValueFromItemUsingNames("Interlock", "Conch").ToString("F");

            this.SteelRiForFramePricePerFt.Text = utils.getValueFromItemUsingNames("SteelRiForFrame", "Conch").ToString("F");
            this.SteelRiForSashPricePerFt.Text = utils.getValueFromItemUsingNames("SteelRiForSash", "Conch").ToString("F");
            this.SteelForScreenPricePerFt.Text = utils.getValueFromItemUsingNames("SteelForScreen", "Conch").ToString("F");

            this.GlazingGasketPricePerM.Text = utils.getValueFromItemUsingNames("GlazingGasket", "Conch").ToString("F");
            this.InsectScreenGasketPricePerM.Text = utils.getValueFromItemUsingNames("InsectScreenGasket", "Conch").ToString("F");
            this.BrushSealPricePerM.Text = utils.getValueFromItemUsingNames("BrushSeal", "Conch").ToString("F");

            this.RollerWheelsPricePerPc.Text = utils.getValueFromItemUsingNames("RollersWheels", "Conch").ToString("F");
            this.HalfMoonLockPricePerPc.Text = utils.getValueFromItemUsingNames("HalfMoonLock", "Conch").ToString("F");
            this.RollersForScreenPricePerPc.Text = utils.getValueFromItemUsingNames("RollersForScreen", "Conch").ToString("F");
            this.HardwarePricePerPc.Text = utils.getValueFromItemUsingNames("Hardware", "Conch").ToString("F");
            this.ScrewsDifferentTypePricePerPc.Text = utils.getValueFromItemUsingNames("ScrewsDifferentType", "Conch").ToString("F");
            this.DrainageCoverPricePerPc.Text = utils.getValueFromItemUsingNames("DrainageCover", "Conch").ToString("F");
            this.BoltCoverInWhitePricePerPc.Text = utils.getValueFromItemUsingNames("BoltCover", "Conch").ToString("F");
            this.LongFixingBoltPricePerPc.Text = utils.getValueFromItemUsingNames("LongFixingBolt", "Conch").ToString("F");
        }

        private void FabricatorsForm_Shown(object sender, EventArgs e)
        {
            resetAllInputs();
            readConchItemValuesFromDatabase();
        }
    }
}
