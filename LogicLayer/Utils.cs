using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLinkLayer;
using System.IO;
using System.Data;
using System.Diagnostics;

namespace LogicLayer
{
    public class Utils
    {
        ConnectToDB connectToDB;
        
        public Utils()
        {
            connectToDB = new ConnectToDB();
        }

        public int getVendorIdFromName(string name)
        {
            string query = "SELECT VendorId FROM Vendor WHERE Name='" + name+ "';";
            return int.Parse(connectToDB.executeScaler(query).ToString());
        }

        public int getStoreIdFromName(string name)
        {
            string query = "SELECT StoreId FROM Store WHERE Name='" + name + "';";
            return int.Parse(connectToDB.executeScaler(query).ToString());
        }

        public int getCategoryIdFromName(string name)
        {
            string query = "SELECT CategoryId FROM Category WHERE Name='" + name + "';";
            return int.Parse(connectToDB.executeScaler(query).ToString());
        }

        public int getItemIdFromName(string name)
        {
            string query = "SELECT ItemId FROM Item WHERE Name='" + name + "';";
            return int.Parse(connectToDB.executeScaler(query).ToString());
        }

        public int getItemIdFromDetails(string name, string categoryId)
        {
            string query = "SELECT ItemId FROM Item WHERE Name='" + name + "';";
            return int.Parse(connectToDB.executeScaler(query).ToString());
        }

        public int getCustomerIdFromName(string nameOfCustomer)
        {
            string query = "SELECT CustomerId FROM Customer WHERE Name='" + nameOfCustomer + "';";
            return int.Parse(connectToDB.executeScaler(query).ToString());
        }

        public bool isStoreAlreadyPresent(string name)
        {
            string query = "SELECT COUNT(*) FROM Store WHERE Name = '" + name + "';";
            return isPresent(query);
        }

        public bool isCategoryAlreadyPresent(string name)
        {
            string query = "SELECT COUNT(*) FROM Category WHERE Name = '" + name + "';";
            return isPresent(query);
        }

        public bool isVendorAlreadyPresent(string name)
        {
            string query = "SELECT COUNT(*) FROM Vendor WHERE Name = '" + name + "';";
            return isPresent(query);
        }

        public bool isCustomerAlreadyPresent(string name)
        {
            string query = "SELECT COUNT(*) FROM Customer WHERE Name = '" + name + "';";
            return isPresent(query);
        }

        public bool isItemAlreadyPresent(string name)
        {
            string query = "SELECT COUNT(*) FROM Item WHERE Name = '" + name + "';";
            return isPresent(query);
        }

        public bool isUomAlreadyPresent(string name)
        {
            string query = "SELECT COUNT(*) FROM Uom WHERE Name = '" + name + "';";
            return isPresent(query);
        }

        public bool isItemPresentInInventory(string itemName, string categoryName, string storeName)
        {
            int itemId = getItemIdFromName(itemName);
            int categoryId = getCategoryIdFromName(categoryName);
            int storeId = getStoreIdFromName(storeName);
            string query = "SELECT COUNT(*) FROM Inventory WHERE ItemId = " + itemId.ToString() + " AND CategoryId = " + categoryId.ToString() + " AND StoreId = " + storeId.ToString() + ";";
            return isPresent(query);
        }

        public int getQuantityOfItemInDB(string item, string category, string store)
        {
            string itemId = getItemIdFromName(item).ToString();
            string categoryId = getCategoryIdFromName(category).ToString();
            string storeId = getStoreIdFromName(store).ToString();

            string query = "SELECT SUM(CAST(Quantity as float)) as 'Quantity' FROM Inventory WHERE ItemId = " + itemId + " AND CategoryId = " + categoryId + " AND StoreId = " + storeId + " ;";

            return int.Parse(connectToDB.executeScaler(query).ToString());
        }

        public float getQuantityOfInventoryUsingId(string inventoryId)
        {
            string query = "SELECT Quantity FROM Inventory WHERE InventoryId='" + inventoryId + "';";
            return float.Parse(connectToDB.executeScaler(query).ToString());
        }

        public float getValueFromItem(string itemId, string categoryId)
        {
            string queryToGetValueFromItem = "SELECT Value from Item WHERE ItemId = " + itemId+";";
            return float.Parse(connectToDB.executeScaler(queryToGetValueFromItem).ToString());
        }

        public float getValueFromItemUsingNames(string itemName, string categoryName)
        {
            string itemId = getItemIdFromName(itemName).ToString();
            string categoryId = getCategoryIdFromName(categoryName).ToString();

            return getValueFromItem(itemId, categoryId);
        }

        public float getQuantiyOfItemInInventoryUsingStoreAndCategory(string item, string category, string store)
        {
            string itemId = getItemIdFromName(item).ToString();
            string storeId = getStoreIdFromName(store).ToString();
            string categoryId = getCategoryIdFromName(category).ToString();

            string queryToGetValueFromItem = "SELECT Quantity from Inventory WHERE ItemId = " + itemId + " AND CategoryId = " + categoryId + "AND StoreId = "+ storeId+" ;";
            return float.Parse(connectToDB.executeScaler(queryToGetValueFromItem).ToString());
        }

        public string getLatestWrittenInvoiceMasterId()
        {
            return connectToDB.executeScaler("SELECT TOP 1 InvoiceMasterId FROM InvoiceMaster ORDER BY InvoiceMasterId DESC").ToString();
        }

        public string getLatestWrittenConchChildId()
        {
            return connectToDB.executeScaler("SELECT TOP 1 ConchChildId FROM ConchChild ORDER BY ConchChildId DESC").ToString();
        }

        public string getCustomerAreaFromName(string customerName)
        {
            string query = "SELECT Area FROM Customer WHERE Name='" + customerName + "';";
            return connectToDB.executeScaler(query).ToString();
        }

        public string getCustomerCityFromName(string customerName)
        {
            string query = "SELECT City FROM Customer WHERE Name='" + customerName + "';";
            return connectToDB.executeScaler(query).ToString();
        }

        public string getCustomerCountryFromName(string customerName)
        {
            string query = "SELECT Country FROM Customer WHERE Name='" + customerName + "';";
            return connectToDB.executeScaler(query).ToString();
        }

        public string getCustomerPhoneNoFromName(string customerName)
        {
            string query = "SELECT PhoneNo FROM Customer WHERE Name='" + customerName + "';";
            return connectToDB.executeScaler(query).ToString();
        }

        public string getItemCodeFromName(string itemName)
        {
            string query = "SELECT Code FROM Item WHERE Name='" + itemName + "';";
            return connectToDB.executeScaler(query).ToString();
        }

        private bool isPresent(string query)
        {
            int result = int.Parse(connectToDB.executeScaler(query).ToString());

            if (result > 0) { return true; }
            return false;
        }

        public void writePdfOfProfileInvoice(string date, string customerName, string weightPerKg, string grandTotalWeight, string grandTotalPrice, DataTable dataFromDGV)
        {
            string table = "";
            int counter = 1;
            foreach (DataRow row in dataFromDGV.Rows)
            {
                table += "<tr>";
                table += "<td>";
                table += counter.ToString();
                table += "</td>";
                table += "<td>";
                table += row[0]; // Description
                table += "</td>";
                table += "<td>";
                table += row[2]; // Code
                table += "</td>";
                table += "<td>";
                table += row[3]; // Unit Weight
                table += "</td>";
                table += "<td>";
                table += row[4].ToString(); // Quantity
                table += "</td>";
                table += "<td>";
                table += row[5]; // Total Weight
                table += "</td>";
                table += "</tr>";
                counter += 1;
            }

            string invoiceNumber = getLatestWrittenInvoiceMasterId();
            string customerArea = getCustomerAreaFromName(customerName);
            string customerCity = getCustomerCityFromName(customerName);
            string customerPhone = getCustomerPhoneNoFromName(customerName);

            #region
            //string pdf = "<!DOCTYPE html>" +
            //    "<html><head><style> table {border-spacing: 0.25em;} </style></head><body>" +
            //    "<table width='100%'><tr><td width='33%' ><img height='100' src='logo.png'/></td>" +
            //    "<h1 style='text - align: center;'>Profiles Invoice</h1></td>" +
            //    "<td width='33%'></td></tr></table><hr />" +
            //    "<table width='100%'><tr><td width='33%' style='font-weight: bold;'>Invoice number : P-Inv-" +
            //    invoiceNumber +
            //    "</td><td width='33%'></td><td width='33%' style='text-align: right; font-weight: bold;'> <span style='border: 1px solid black;'>Date : " +
            //    date +
            //    "</span></td></tr><tr><td style='font-weight: bold;'>To</td></tr>" +
            //    "<tr><td>&emsp;" +
            //    customerName +
            //    "</td></tr><tr><td>&emsp;" +
            //    customerArea +
            //    "</td></tr><tr><td>&emsp;" +
            //    customerCity +
            //    "</td></tr><tr><td>&emsp;" +
            //    customerPhone +
            //    "</td></tr></table><hr />" +
            //    "<table width='100%'><tr><td style ='font-weight: bold;'>Items Description</td></tr></table>" +
            //    "<table width='100%' border='1' style='border-collapse: collapse;'><tr style='font-weight: bold;'><th>S_No</th>" +
            //    "<th>Description</th><th>Code</th><th>Unit Weight</th><th>Quantity</th><th>Total Weight</th></tr>" +
            //    // <tr></tr> // loop over here
            //    table +
            //    "</table><br /><br /><hr />" +
            //    "<table width='100%'><tr><td style ='font-weight: bold;'>Grand Total Details</td></tr></table>" +
            //    "<table width='50%' border='1' style='border-collapse: collapse;'><tr ><td style='font-weight: bold; width: 50%;'>Weight Price Per KG</td><td>" +
            //    weightPerKg +
            //    "</td></tr><tr ><td style='font-weight: bold; width: 50%;'>Grand Total Weight</td><td>" +
            //    grandTotalWeight +
            //    "</td></tr><tr ><td style='font-weight: bold; width: 50%;'>Grand Total Price</td><td>" +
            //    grandTotalPrice +
            //    "</td></tr></table><br />" +
            //    "<table width='100%'><tr><td style='width:40%; border-bottom: 1px solid black;'>Name</td><td></td>" +
            //    "<td style='width:40%; border-bottom: 1px solid black;'>Signature</td></tr></table><br /><br /><br />" +
            //    "<span style='position:fixed; bottom:0; width: 100%;'><hr />" +
            //    "<table width='100%' ><tr><td style ='font-weight: bold;'>Terms & Conditions</td></tr><tr><td></td></tr><tr><td></td></tr><tr><td>" +
            //    "* Payment will be done in advance via cash or bank transfer</td></tr><tr><td>* Check all items before purchase</td></tr></table><hr />" +
            //    "<table width='100%' ><tr><td style ='font-weight: bold;'>Company Details</td></tr><tr><td></td></tr><tr><td></td></tr><tr><td>" +
            //    "* Plot number 926 Kalar Syedan Road, Rawat Rawalpindi</td></tr><tr><td>* ZAIN +923312654265 &emsp; USAMA +923328567824" +
            //    "</td></tr></table></span></body></html>";

            #endregion

            #region html code for pdf generator
            string htmlCode = "<!DOCTYPE html>";
            htmlCode += "<html><head><style> table { border-spacing: 0.25em; } </style></head>";
            htmlCode += "<body>";
            htmlCode += "<div class='divFooter'><table width ='100%'><tr><td width='33%'><img height='100' src='logo.png'/></td><td width='33%'><h1 style='text-align: center;'>Profiles Invoice</h1></td><td width='33%'></td></tr></table></div>";
            htmlCode += "<hr />";
            htmlCode += "<table width='100%'><tr><td width='33%' style='font-weight: bold;'>Invoice number : P-Inv-" + invoiceNumber + "</td><td width='33%'></td><td width='33%' style='text-align: right; font-weight: bold;'> <span style='border: 1px solid black;'>Date : " + date + "</span></td></tr>";
            htmlCode += "<tr><td style='font-weight: bold;'>To</td></tr>";
            htmlCode += "<tr><td>&emsp;" + customerName + "</td></tr>";
            htmlCode += "<tr><td>&emsp;" + customerArea + "</td></tr>";
            htmlCode += "<tr><td>&emsp;" + customerCity + "</td></tr>";
            htmlCode += "<tr><td>&emsp;" + customerPhone + "</td></tr>";
            htmlCode += "</table><hr />";
            htmlCode += "<table width='100%'><tr><td style ='font-weight: bold;'>Items Description</td></tr></table>";
            htmlCode += "<table width='100%' border='1' style='border-collapse: collapse;'><tr style='font-weight: bold;'><th>S_No</th><th>Description</th><th>Code</th><th>Unit Weight</th><th>Quantity</th><th>Total Weight</th></tr>" + table + "</table>";
            htmlCode += "<br /><br /><hr />";
            htmlCode += "<table width='100%' ><tr><td style ='font-weight: bold;'>Grand Total Details</td></tr></table>";
            htmlCode += "<table width='50%' border='1' style='border-collapse: collapse;'>";
            htmlCode += "<tr><td style='font-weight: bold; width: 50%;'>Weight Price Per KG</td><td>" + weightPerKg + "</td></tr>";
            htmlCode += "<tr><td style='font-weight: bold; width: 50%;'>Grand Total Weight</td><td>" + grandTotalWeight + "</td></tr>";
            htmlCode += "<tr><td style='font-weight: bold; width: 50%;'>Grand Total Price</td><td>" + grandTotalPrice + "</td></tr></table>";
            htmlCode += "<br /><br />";
            htmlCode += "<table width='100%'><tr><td style='width:40%; border-bottom: 1px solid black;'>Name</td><td></td><td style='width:40%; border-bottom: 1px solid black;'>Signature</td></tr></table>";
            htmlCode += "<br /><br /><br />";
            htmlCode += "<div class='divFooter' style='width:100%;'><hr />";
            htmlCode += "<table width='100%' ><tr><td style ='font-weight: bold;'>Terms & Conditions</td></tr><tr><td></td></tr><tr><td></td></tr><tr><td>* Payment will be done in advance via cash or bank transfer</td></tr><tr><td>* Check all items before purchase</td></tr></table>";
            htmlCode += "<hr />";
            htmlCode += "<table width='100%' ><tr><td style ='font-weight: bold;'>Company Details</td></tr><tr><td></td></tr><tr><td></td></tr><tr><td>* Plot number 926 Kalar Syedan Road, Rawat Rawalpindi</td></tr><tr><td>* ZAIN +923312654265 &emsp; USAMA +923328567824</td></tr></table></div>";
            htmlCode += "</body></html>";
            #endregion

            using (StreamWriter writer = new StreamWriter("HTML/temp.html"))
            {
                writer.Write(htmlCode);
            }

            ProcessStartInfo processStartInfo = new ProcessStartInfo();

            processStartInfo.FileName = "cmd.exe";
            processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processStartInfo.Arguments = "/c wkhtmltopdf.exe \"HTML/temp.html\" --enable-local-file-access \"Invoices/Profile Invoice " + invoiceNumber + ".pdf";

            Process.Start(processStartInfo).WaitForExit();
        }

        public void writeInvoiceOfConch(System.Collections.ArrayList listOfAllOrders, string customerName, string projectSite, string atten, bool openPdfAfterWriting)
        {
            string orders = "";
            int counter = 1;
            string quotationNo = new Utils().getLatestWrittenInvoiceMasterId();

            double totalPrice = 0;

            foreach (Dictionary<string, object> order in listOfAllOrders)
            {
                orders += "<tr>";

                orders += "<td style='font-weight: 700; text-align: center;'>";
                orders += counter.ToString();
                orders += "</td>";

                orders += "<td style='text-align: center;'>";
                orders += order["Description"] as string;
                orders += "</td>";

                orders += "<td>";
                orders += double.Parse(order["Width"].ToString()).ToString("F");
                orders += "</td>";

                orders += "<td>";
                orders += double.Parse(order["Height"].ToString()).ToString("F");
                orders += "</td>";

                orders += "<td>";
                orders += double.Parse(order["Quantity"].ToString()).ToString("F");
                orders += "</td>";

                orders += "<td>";
                orders += double.Parse(order["PricePerSqFt"].ToString()).ToString("F");
                orders += "</td>";

                orders += "<td>";
                orders += double.Parse(order["TotalSqFt"].ToString()).ToString("F");
                orders += "</td>";

                orders += "<td style='text-align: right;'>";
                orders += double.Parse(order["TotalPrice"].ToString()).ToString("F4");
                orders += "</td>";

                orders += "</tr>";

                totalPrice += double.Parse(order["TotalPrice"].ToString());

                counter++;
            }

            #region Html String

            string htmlString = "<!DOCTYPE html>";
            htmlString += "<html><head><style>table { border-spacing: 0.25em; } div { margin-top: 5px; }</style></head>";
            htmlString += "<body>";
            htmlString += "<table width='100%' style='text-align: center;'><tr style='font-size: 48px; font-weight: bold;'><td>ALPHA PROFILES</td></tr><tr style='font-weight: 700; text-decoration: underline;'><td>Quotation for Imported  UPVC windows (CONCH Profile)</td></tr></table>";
            htmlString += "<br /><br />";
            htmlString += "<table width='100%' style='text-align: right; font-weight: 700;'><tr>";
            htmlString += "<td>Date : " + DateTime.Now.ToString("yyyy-MM-dd")+"</td>";
            htmlString += "<tr><td>Quotation # <span style='font-weight: 100;'>" +quotationNo +"</span></td></tr>";
            htmlString += "</table><br />";
            htmlString += "<table width='100%' style='font-weight: 700;'>";
            htmlString += "<tr><td>Customer : " + customerName + "</td></tr>";
            htmlString += "<tr><td>Project Site : " + projectSite + "</td></tr>";
            htmlString += "<tr><td>Atten : " + atten + "</td></tr>";
            htmlString += "</table><br />";
            htmlString += "<table width='100%'><tr style='font-weight: 700;'><td>Dear Sir/Madam, </td></tr><tr><td>&emsp;Please find herewith the price quotation regarding UPVC windows and doors.We offer our special discounted rates for you are as follow for your kind consideration:</td></tr></table>";
            htmlString += "<table width='100%' border='2' style='border-collapse: collapse; border: 3px solid black;'>";
            htmlString += "<tr style='background-color: rgba(0,0,0,0.2); font-weight: 700;'><th style='font-weight: 700;'>S/N</th><th>Description</th><th>Width</th><th>Height</th><th>Quantity</th><th>Price / S.Ft</th><th>Total S.Ft</th><th>Total Price</th></tr>";
            htmlString += orders;
            htmlString += "<tr style='text-align: right; '><td colspan='5'></td><td colspan='2' style='border: 3px solid black; font-weight:700;'>TOTAL</td><td style='border: 3px solid black; text-align: right;'>";
            htmlString += totalPrice.ToString("F4");
            htmlString += "</td></tr></table><br />";
            htmlString += "<table width='100%' style='text-align: center; font-weight: 700;'><tr style=' text-align: left;'><td>&emsp;&emsp;<span style='text-decoration: underline;'>Note:</span></td></tr><tr><td>*Once window designs are confirmed and fabrication has started changes will not be made to the window designs.</td></tr><tr><td>*Time of Delivery:  4 Weeks (Excluding Holidays) after advance payment and final sizes  of windows design.</td></tr></table>";
            htmlString += "<br />";
            htmlString += "<span style='font-size: 12px;'><div style='font-size: 20px; font-weight: 700; text-decoration: underline;'>Terms & Conditions:</div>";
            htmlString += "<div style='font-weight: 700;'>&emsp;1&emsp;<span style='text-decoration: underline;'>Terms of Payment :-</span></div>";
            htmlString += "<div style='font-weight: 700;'>&emsp;&emsp;a.&emsp;20% on delivery</div>";
            htmlString += "<div style='font-weight: 700;'>&emsp;&emsp;b.&emsp;10% on  Completion.</div>";
            htmlString += "<div style='font-weight: 700;'>&emsp;&emsp;c.&emsp;70% advance on confirmation of order</div>";
            htmlString += "<div style='font-weight: 700;'>&emsp;2&emsp;Please make cheque in favour of Alpha Profiles.</div>";
            htmlString += "<div><span style='font-weight: 700;'>&emsp;3&emsp;Quotation validity:</span> These prices are valid for 15 days from the date of issue.</div>";
            htmlString += "<div style='font-weight: 700;'>&emsp;4&emsp;<span style='text-decoration: underline;'> All Accessories and Hardware are Imported:</span></div>";
            htmlString += "<div>&emsp;&emsp;Handles, Locks, Gear Locks, Brush, Rubber Gaskets, Screws and Self Tapping Screws (Galvanized Rust Free), </div>";
            htmlString += "<div>&emsp;&emsp;Steel Re-inforcement 1mm (Galvanized Rust Free Local), Screw Hole Covers, Water Hole Covers, Aluminium Railing, Aluminium/Fibre Netting, Rollers for Windows </div>";
            htmlString += "<div style='font-weight: 700;'>&emsp;5&emsp;Imported Spacers, Imported Corners, Imported Double Tape, Imported Chemical and Imported Dow Corning Weatherseal Silicone is used for Double</div>";
            htmlString += "<div style='font-weight: 700;'>&emsp;6&emsp;All Accessories and Hardware come with two year warranty .No claim for damages due to rough usage of windows. Therefore additional charges will be</div>";
            htmlString += "<div style='font-weight: 700;'>&emsp;7&emsp;We use branded Profile 88mm/80mm/60mm with warranty of 15 years.</div>";
            htmlString += "<div style='font-weight: 700;'>&emsp;8&emsp;Defaults in the payment shall terminate the warranty.</div></span>";
            htmlString += "<br />";
            htmlString += "<div style='text-align: center;'>Assuring you our best attention, service and cooperation</div>";
            htmlString += "<br />";
            htmlString += "<div style='font-weight: 700;'>&emsp;Regards,</div>";
            htmlString += "</body></html>";

            #endregion

            using (StreamWriter writer = new StreamWriter("HTML/temp-2.html"))
            {
                writer.Write(htmlString);
            }

            ProcessStartInfo processStartInfo = new ProcessStartInfo();

            processStartInfo.FileName = "cmd.exe";
            processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            string fileName = customerName + " - " + projectSite;

            processStartInfo.Arguments = "/c wkhtmltopdf.exe \"HTML/temp-2.html\" --enable-local-file-access \"Conch/" + fileName + ".pdf\"";

            Process.Start(processStartInfo).WaitForExit();

            if (openPdfAfterWriting)
            {
                string command = "cd Conch\n\"" + fileName + ".pdf\"\n";
                using (StreamWriter writer = new StreamWriter("command.bat"))
                {
                    writer.Write(command);
                }
                processStartInfo.Arguments = "/c command.bat";
                Process.Start(processStartInfo).WaitForExit();

                processStartInfo.Arguments = "/c del command.bat";
                Process.Start(processStartInfo).WaitForExit();
            }
        }

        public void openInovicePdfFromFile(string invoiceNo)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo();

            processStartInfo.FileName = "cmd.exe";
            processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            string command = "cd Invoices\n\"Profile Invoice " + invoiceNo + ".pdf\"\n\n\n";
            using (StreamWriter writer = new StreamWriter("command.bat"))
            {
                writer.Write(command);
            }

            processStartInfo.Arguments = "/c command.bat";
            Process.Start(processStartInfo).WaitForExit();

            processStartInfo.Arguments = "/c del command.bat";
            Process.Start(processStartInfo).WaitForExit();
        }

        public void generatePdfOfAllInvoicesOfACustomer(string customerName, DataTable dataTableOfRows, DateTime searchStartDate, DateTime searchEndDate)
        {
            int counter = 1;
            float totalAmount = 0;
            string rowsOfTable = "";

            foreach (DataRow row in dataTableOfRows.Rows)
            {
                rowsOfTable += "<tr>";

                rowsOfTable += "<td style='text-align:center;'>";
                rowsOfTable += counter.ToString();
                rowsOfTable += "</td>";

                rowsOfTable += "<td>P-Inv-";
                rowsOfTable += row["InvoiceNo"].ToString();
                rowsOfTable += "</td>";

                rowsOfTable += "<td>";
                rowsOfTable += row["Date"].ToString().Substring(0, 10);
                rowsOfTable += "</td>";

                rowsOfTable += "<td>";
                rowsOfTable += row["TotalWeight"].ToString();
                rowsOfTable += "</td>";

                rowsOfTable += "<td style='text-align:right;'>";
                rowsOfTable += row["TotalAmount"].ToString();
                rowsOfTable += "</td>";

                totalAmount += float.Parse(row["TotalAmount"].ToString());

                rowsOfTable += "</tr>";
                counter++;
            }

            #region html string 

            string htmlString = "<!DOCTYPE html>";
            htmlString += "<html><head><style>table{border-spacing: 0.25em;}</style></head>";
            htmlString += "<body><table width ='100%'><tr><td width='33%'><img height='100' src='logo.png'/></td><td width='33%'><h1 style='text-align: center;'>Customer Report</h1></td><td width='33%'></td></tr></table>";
            htmlString += "<table width='100%'><tr><td width='33%' style='font-weight: bold;'>" +
                "Customer Name : " + customerName +
                "</td><td width='33%'></td><td width='33%' style='text-align: right; font-weight: bold;'> <span style='border: 1px solid black;'>" +
                "Date of Printing : " + DateTime.Now.ToString("yyyy-MM-dd") + "</span></td></tr><br/><br/>" +
                "<tr><td><em>From : </em>" + searchStartDate.ToString("yyyy-MM-dd") + "</tr></td><tr><td><em>To : </em>" + searchEndDate.ToString("yyyy-MM-dd") +"</td></tr>"+
                "</table><hr/>";
            htmlString += "<table width='100%'><tr><td style ='font-weight: bold;'>Invoices Description</td></tr></table><br/>";
            htmlString += "<table width='100%' border='1' style='border-collapse: collapse;'>";
            htmlString += "<tr style='font-weight: bold;'><th>S_No</th><th>Invoice Number</th><th>Date</th><th>Total Weight</th><th>Total Amount</th></tr>";
            htmlString += rowsOfTable;
            htmlString += "<tr style='text-align: right; font-weight: 700; font-size: 24px;'><td colspan='4'>Grand Total Price</td><td>" + totalAmount.ToString("F4") + "</td></tr></table>";
            htmlString += "<br /><br /><hr />";
            htmlString += "<table width='100%'><tr><td style='width:40%; border-bottom: 1px solid black;'>Name</td><td></td><td style='width:40%; border-bottom: 1px solid black;'>Signature</td></tr></table><br/><br />";
            htmlString += "<br /><br />";
            htmlString += "<div style='width: 100%;'>";
            htmlString += "<hr />";
            htmlString += "<table width='100%' ><tr><td style ='font-weight: bold;'>Terms & Conditions</td></tr><tr><td></td></tr><tr><td></td></tr><tr><td>* Payment will be done in advance via cash or bank transfer</td></tr><tr><td>* Check all items before purchase</td></tr></table>";
            htmlString += "<hr />";
            htmlString += "<table width='100%' ><tr><td style ='font-weight: bold;'>Company Details</td></tr><tr><td></td></tr><tr><td></td></tr><tr><td>* Plot number 926 Kalar Syedan Road, Rawat Rawalpindi</td></tr><tr><td>* ZAIN +923312654265 &emsp; USAMA +923328567824</td></tr></table>";
            htmlString += "</div></body></html>";

            #endregion

            using (StreamWriter writer = new StreamWriter("HTML/temp-3.html"))
            {
                writer.Write(htmlString);
            }

            ProcessStartInfo processStartInfo = new ProcessStartInfo();

            processStartInfo.FileName = "cmd.exe";
            processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            string fileName = customerName + " - " + searchStartDate.ToString("yyyy-MM-dd") + " - " + searchEndDate.ToString("yyyy-MM-dd");

            processStartInfo.Arguments = "/c wkhtmltopdf.exe \"HTML/temp-3.html\" --enable-local-file-access \"Invoices/" + fileName + ".pdf\"";

            Process.Start(processStartInfo).WaitForExit();

            string command = "cd Invoices\n\"" + fileName + ".pdf\"\n";
            using (StreamWriter writer = new StreamWriter("command.bat"))
            {
                writer.Write(command);
            }
            processStartInfo.Arguments = "/c command.bat";
            Process.Start(processStartInfo).WaitForExit();

            processStartInfo.Arguments = "/c del command.bat";
            Process.Start(processStartInfo);
        }

        public string getNoOfStores()
        {
            string query = "SELECT COUNT(Name) from Store";
            return connectToDB.executeScaler(query).ToString();
        }

        public string getNoOfInventoryItems()
        {
            string query = "SELECT COUNT(DISTINCT ItemId) from Inventory";
            return connectToDB.executeScaler(query).ToString();
        }

        public string getNoOfTotalItems()
        {
            string query = "SELECT COUNT(ItemId) from Item";
            return connectToDB.executeScaler(query).ToString();
        }

        public string getNoOfItemCategories()
        {
            string query = "SELECT COUNT(CategoryId) from Category";
            return connectToDB.executeScaler(query).ToString();
        }

        public string getNoOfVendors()
        {
            string query = "SELECT COUNT(VendorId) from Vendor";
            return connectToDB.executeScaler(query).ToString();
        }

        public string getNoOfCustomers()
        {
            string query = "SELECT COUNT(CustomerId) from Customer";
            return connectToDB.executeScaler(query).ToString();
        }

        public Dictionary<string, float> getAllSalesOfThisMonth()
        {
            string year = DateTime.Now.ToString("yyyy");
            string month = DateTime.Now.ToString("MM");

            Dictionary<string, float> datesAndItemsSoldPair = new Dictionary<string, float>();

            string query = "SELECT DISTINCT StockOutDate FROM Transactions WHERE MONTH(StockOutDate) = " + month + " AND YEAR(StockOutDate) = " + year + " ORDER BY StockOutDate ASC;";

            DataTable datesWithTransactionOfThisMonth = connectToDB.ReadDatasetFromDB(query).Tables[0];

            foreach (DataRow row in datesWithTransactionOfThisMonth.Rows)
            {
                if(!string.IsNullOrEmpty(row[0].ToString()))
                {
                    DateTime date = Convert.ToDateTime(row[0].ToString());

                    string queryToGetNoOfTransactions = "SELECT SUM(StockOutQuantity) FROM Transactions WHERE StockOutDate = '" + date.ToString("yyyy-MM-dd") + "';";
                    float quantity = float.Parse(connectToDB.executeScaler(queryToGetNoOfTransactions).ToString());
                    if(quantity > 0)
                    {
                        datesAndItemsSoldPair.Add(date.ToString("yyyy-MM-dd"), quantity);
                    }
                }
            }
            return datesAndItemsSoldPair;
        }

        public Dictionary<string, float> getAllPurchasesOfThisMonth()
        {
            string year = DateTime.Now.ToString("yyyy");
            string month = DateTime.Now.ToString("MM");

            Dictionary<string, float> datesAndItemsSoldPair = new Dictionary<string, float>();

            string query = "SELECT DISTINCT StockInDate FROM Transactions WHERE MONTH(StockInDate) = " + month + " AND YEAR(StockInDate) = " + year + " ORDER BY StockInDate ASC;";

            DataTable datesWithTransactionOfThisMonth = connectToDB.ReadDatasetFromDB(query).Tables[0];

            foreach (DataRow row in datesWithTransactionOfThisMonth.Rows)
            {
                if (!string.IsNullOrEmpty(row[0].ToString()))
                {
                    DateTime date = Convert.ToDateTime(row[0].ToString());

                    string queryToGetNoOfTransactions = "SELECT SUM(StockInQuantity) FROM Transactions WHERE StockInDate = '" + date.ToString("yyyy-MM-dd") + "';";
                    float quantity = float.Parse(connectToDB.executeScaler(queryToGetNoOfTransactions).ToString());
                    if (quantity > 0)
                    {
                        datesAndItemsSoldPair.Add(date.ToString("yyyy-MM-dd"), quantity);
                    }
                }
            }
            return datesAndItemsSoldPair;
        }

        private void checkAndWriteFtUom()
        {
            string query = "SELECT COUNT(*) FROM Uom WHERE Name = 'FT';";
            if (connectToDB.executeScaler(query).ToString()=="0")
            {
                query = "INSERT INTO Uom(Name) VALUES('FT')";
                connectToDB.WriteToDB(query);
            }
        }

        private void checkAndWriteMUom()
        {
            string query = "SELECT COUNT(*) FROM Uom WHERE Name = 'M';";
            if (connectToDB.executeScaler(query).ToString()=="0")
            {
                query = "INSERT INTO UOM(Name) VALUES('M')";
                connectToDB.WriteToDB(query);
            }
        }

        private void checkAndWritePieceUom()
        {
            string query = "SELECT COUNT(*) FROM Uom WHERE Name = 'Piece';";
            if (connectToDB.executeScaler(query).ToString()=="0")
            {
                query = "INSERT INTO UOM(Name) VALUES('Piece')";
                connectToDB.WriteToDB(query);
            }
        }

        private void checkAndWriteConchCategory()
        {
            string query = "SELECT COUNT(*) FROM Category WHERE Name = 'Conch';";
            if (connectToDB.executeScaler(query).ToString()=="0")
            {
                query = "INSERT INTO Category(Name) VALUES('Conch')";
                connectToDB.WriteToDB(query);
            }
        }

        public void addAllConchItemsToDB()
        {
            checkAndWriteConchCategory();
            string conchCategoryId = getCategoryIdFromName("Conch").ToString();

            checkAndWriteFtUom();

            #region conch profile description entry

            string query = "SELECT COUNT(*) FROM Item WHERE Name = 'SlidingFrame';";
            if (connectToDB.executeScaler(query).ToString()=="0")
            {
                query = "INSERT Into Item(CategoryId, Name, Code, SerialNo, UOM, Value, Length, Width) " +
                    "VALUES(" + conchCategoryId + ", 'SlidingFrame', 'conch 88', '', 'FT', 119.0, 0,0 );";
                connectToDB.WriteToDB(query);
            }

            query = "SELECT COUNT(*) FROM Item WHERE Name = 'SlidingSash';";
            if (connectToDB.executeScaler(query).ToString()=="0")
            {
                query = "INSERT Into Item(CategoryId, Name, Code, SerialNo, UOM, Value, Length, Width) " +
                    "VALUES(" + conchCategoryId + ", 'SlidingSash', 'PRO 211', '', 'FT', 96.41, 0,0 );";
                connectToDB.WriteToDB(query);
            }

            query = "SELECT COUNT(*) FROM Item WHERE Name = 'NetSash';";
            if (connectToDB.executeScaler(query).ToString()=="0")
            {
                query = "INSERT Into Item(CategoryId, Name, Code, SerialNo, UOM, Value, Length, Width) " +
                    "VALUES(" + conchCategoryId + ", 'NetSash', 'PRO 234', '', 'FT', 46.56, 0,0 );";
                connectToDB.WriteToDB(query);
            }

            query = "SELECT COUNT(*) FROM Item WHERE Name = 'Interlock';";
            if (connectToDB.executeScaler(query).ToString()=="0")
            {
                query = "INSERT Into Item(CategoryId, Name, Code, SerialNo, UOM, Value, Length, Width) " +
                    "VALUES(" + conchCategoryId + ", 'Interlock', 'PRO 204', '', 'FT', 22.00, 0,0 );";
                connectToDB.WriteToDB(query);
            }

            query = "SELECT COUNT(*) FROM Item WHERE Name = 'BeadingSG';";
            if (connectToDB.executeScaler(query).ToString()=="0")
            {
                query = "INSERT Into Item(CategoryId, Name, Code, SerialNo, UOM, Value, Length, Width) " +
                    "VALUES(" + conchCategoryId + ", 'BeadingSG', 'PRO 703', '', 'FT', 21.10, 0,0 );";
                connectToDB.WriteToDB(query);
            }

            #endregion

            #region conch reinforcement description entry

            query = "SELECT COUNT(*) FROM Item WHERE Name = 'SteelRiForFrame';";
            if (connectToDB.executeScaler(query).ToString()=="0")
            {
                query = "INSERT Into Item(CategoryId, Name, Code, SerialNo, UOM, Value, Length, Width) " +
                    "VALUES(" + conchCategoryId + ", 'SteelRiForFrame', 'HGC 3515', '', 'FT', 25.00, 0,0 );";
                connectToDB.WriteToDB(query);
            }

            query = "SELECT COUNT(*) FROM Item WHERE Name = 'SteelRiForSash';";
            if (connectToDB.executeScaler(query).ToString()=="0")
            {
                query = "INSERT Into Item(CategoryId, Name, Code, SerialNo, UOM, Value, Length, Width) " +
                    "VALUES(" + conchCategoryId + ", 'SteelRiForSash', 'HGC 2512', '', 'FT', 25.00, 0,0 );";
                connectToDB.WriteToDB(query);
            }

            query = "SELECT COUNT(*) FROM Item WHERE Name = 'SteelForScreen';";
            if (connectToDB.executeScaler(query).ToString()=="0")
            {
                query = "INSERT Into Item(CategoryId, Name, Code, SerialNo, UOM, Value, Length, Width) " +
                    "VALUES(" + conchCategoryId + ", 'SteelForScreen', 'HGC 2014', '', 'FT', 25.00, 0,0 );";
                connectToDB.WriteToDB(query);
            }

            #endregion

            checkAndWriteMUom();

            #region conch gasket / sales description

            query = "SELECT COUNT(*) FROM Item WHERE Name = 'GlazingGasket';";
            if (connectToDB.executeScaler(query).ToString() =="0") 
            {
                query = "INSERT Into Item(CategoryId, Name, Code, SerialNo, UOM, Value, Length, Width) " +
                    "VALUES(" + conchCategoryId + ", 'GlazingGasket', 'GS - 302', '', 'M', 06.00, 0,0 );";
                connectToDB.WriteToDB(query);
            }

            query = "SELECT COUNT(*) FROM Item WHERE Name = 'InsectScreenGasket';";
            if (connectToDB.executeScaler(query).ToString() =="0")
            {
                query = "INSERT Into Item(CategoryId, Name, Code, SerialNo, UOM, Value, Length, Width) " +
                    "VALUES(" + conchCategoryId + ", 'InsectScreenGasket', 'GS - 303', '', 'M', 06.00, 0,0 );";
                connectToDB.WriteToDB(query);
            }

            query = "SELECT COUNT(*) FROM Item WHERE Name = 'BrushSeal';";
            if (connectToDB.executeScaler(query).ToString()=="0")
            {
                query = "INSERT Into Item(CategoryId, Name, Code, SerialNo, UOM, Value, Length, Width) " +
                    "VALUES(" + conchCategoryId + ", 'BrushSeal', 'BS 01', '', 'M', 06.00, 0,0 );";
                connectToDB.WriteToDB(query);
            }

            #endregion

            #region conch hardware description

            checkAndWritePieceUom();

            query = "SELECT COUNT(*) FROM Item WHERE Name = 'RollersWheels';";
            if (connectToDB.executeScaler(query).ToString()=="0")
            {
                query = "INSERT Into Item(CategoryId, Name, Code, SerialNo, UOM, Value, Length, Width) " +
                    "VALUES(" + conchCategoryId + ", 'RollersWheels', 'SS - 04', '', 'Piece', 80.00, 0, 0 );";
                connectToDB.WriteToDB(query);
            }

            query = "SELECT COUNT(*) FROM Item WHERE Name = 'HalfMoonLock';";
            if (connectToDB.executeScaler(query).ToString()=="0")
            {
                query = "INSERT Into Item(CategoryId, Name, Code, SerialNo, UOM, Value, Length, Width) " +
                    "VALUES(" + conchCategoryId + ", 'HalfMoonLock', 'HML 105', '', 'Piece', 180.00, 0, 0 );";
                connectToDB.WriteToDB(query);
            }

            query = "SELECT COUNT(*) FROM Item WHERE Name = 'RollersForScreen';";
            if (connectToDB.executeScaler(query).ToString()=="0")
            {
                query = "INSERT Into Item(CategoryId, Name, Code, SerialNo, UOM, Value, Length, Width) " +
                    "VALUES(" + conchCategoryId + ", 'RollersForScreen', 'SS - 04', '', 'Piece', 150.00, 0, 0 );";
                connectToDB.WriteToDB(query);
            }

            query = "SELECT COUNT(*) FROM Item WHERE Name = 'Hardware';";
            if (connectToDB.executeScaler(query).ToString()=="0")
            {
                query = "INSERT Into Item(CategoryId, Name, Code, SerialNo, UOM, Value, Length, Width) " +
                    "VALUES(" + conchCategoryId + ", 'Hardware', 'Product', '', 'Piece', 00.00, 0, 0 );";
                connectToDB.WriteToDB(query);
            }

            query = "SELECT COUNT(*) FROM Item WHERE Name = 'ScrewsDifferentType';";
            if (connectToDB.executeScaler(query).ToString()=="0")
            {
                query = "INSERT Into Item(CategoryId, Name, Code, SerialNo, UOM, Value, Length, Width) " +
                    "VALUES(" + conchCategoryId + ", 'ScrewsDifferentType', 'ISS-03', '', 'Piece', 2.00, 0, 0 );";
                connectToDB.WriteToDB(query);
            }

            query = "SELECT COUNT(*) FROM Item WHERE Name = 'DrainageCover';";
            if (connectToDB.executeScaler(query).ToString()=="0")
            {
                query = "INSERT Into Item(CategoryId, Name, Code, SerialNo, UOM, Value, Length, Width) " +
                    "VALUES(" + conchCategoryId + ", 'DrainageCover', 'DC1415', '', 'Piece', 5.00, 0, 0 );";
                connectToDB.WriteToDB(query);
            }

            query = "SELECT COUNT(*) FROM Item WHERE Name = 'BoltCover';";
            if (connectToDB.executeScaler(query).ToString()=="0")
            {
                query = "INSERT Into Item(CategoryId, Name, Code, SerialNo, UOM, Value, Length, Width) " +
                    "VALUES(" + conchCategoryId + ", 'BoltCover', 'CVR 06', '', 'Piece', 2.00, 0, 0 );";
                connectToDB.WriteToDB(query);
            }

            query = "SELECT COUNT(*) FROM Item WHERE Name = 'LongFixingBolt';";
            if (connectToDB.executeScaler(query).ToString()=="0")
            {
                query = "INSERT Into Item(CategoryId, Name, Code, SerialNo, UOM, Value, Length, Width) " +
                    "VALUES(" + conchCategoryId + ", 'LongFixingBolt', 'FB 8x75', '', 'Piece', 5.00, 0, 0 );";
                connectToDB.WriteToDB(query);
            }

            #endregion
        }

        public bool checkIfAllConchItemsAreEntered()
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Item WHERE Name = 'SlidingFrame';";
                if (connectToDB.executeScaler(query).ToString() != "0")
                {
                    query = "SELECT COUNT(*) FROM Item WHERE Name = 'SlidingSash';";
                    if (connectToDB.executeScaler(query).ToString() != "0")
                    {
                        query = "SELECT COUNT(*) FROM Item WHERE Name = 'NetSash';";
                        if (connectToDB.executeScaler(query).ToString() != "0")
                        {
                            query = "SELECT COUNT(*) FROM Item WHERE Name = 'Interlock';";
                            if (connectToDB.executeScaler(query).ToString() != "0")
                            {
                                query = "SELECT COUNT(*) FROM Item WHERE Name = 'BeadingSG';";
                                if (connectToDB.executeScaler(query).ToString() != "0")
                                {
                                    query = "SELECT COUNT(*) FROM Item WHERE Name = 'SteelRiForFrame';";
                                    if (connectToDB.executeScaler(query).ToString() != "0")
                                    {
                                        query = "SELECT COUNT(*) FROM Item WHERE Name = 'SteelRiForSash';";
                                        if (connectToDB.executeScaler(query).ToString() != "0")
                                        {
                                            query = "SELECT COUNT(*) FROM Item WHERE Name = 'SteelForScreen';";
                                            if (connectToDB.executeScaler(query).ToString() != "0")
                                            {
                                                query = "SELECT COUNT(*) FROM Item WHERE Name = 'GlazingGasket';";
                                                if (connectToDB.executeScaler(query).ToString() != "0")
                                                {
                                                    query = "SELECT COUNT(*) FROM Item WHERE Name = 'InsectScreenGasket';";
                                                    if (connectToDB.executeScaler(query).ToString() != "0")
                                                    {
                                                        query = "SELECT COUNT(*) FROM Item WHERE Name = 'BrushSeal';";
                                                        if (connectToDB.executeScaler(query).ToString() != "0")
                                                        {
                                                            query = "SELECT COUNT(*) FROM Item WHERE Name = 'RollersWheels';";
                                                            if (connectToDB.executeScaler(query).ToString() != "0")
                                                            {
                                                                query = "SELECT COUNT(*) FROM Item WHERE Name = 'HalfMoonLock';";
                                                                if (connectToDB.executeScaler(query).ToString() != "0")
                                                                {
                                                                    query = "SELECT COUNT(*) FROM Item WHERE Name = 'RollersForScreen';";
                                                                    if (connectToDB.executeScaler(query).ToString() != "0")
                                                                    {
                                                                        query = "SELECT COUNT(*) FROM Item WHERE Name = 'Hardware';";
                                                                        if (connectToDB.executeScaler(query).ToString() != "0")
                                                                        {
                                                                            query = "SELECT COUNT(*) FROM Item WHERE Name = 'ScrewsDifferentType';";
                                                                            if (connectToDB.executeScaler(query).ToString() != "0")
                                                                            {
                                                                                query = "SELECT COUNT(*) FROM Item WHERE Name = 'DrainageCover';";
                                                                                if (connectToDB.executeScaler(query).ToString() != "0")
                                                                                {
                                                                                    query = "SELECT COUNT(*) FROM Item WHERE Name = 'BoltCover';";
                                                                                    if (connectToDB.executeScaler(query).ToString() != "0")
                                                                                    {
                                                                                        query = "SELECT COUNT(*) FROM Item WHERE Name = 'LongFixingBolt';";
                                                                                        if (connectToDB.executeScaler(query).ToString() != "0")
                                                                                        {
                                                                                            return true;
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
