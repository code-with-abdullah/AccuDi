using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLinkLayer;
using System.Collections;

namespace LogicLayer
{
    public class WriteToDatabase
    {
        Utils utils;
        ConnectToDB connectToDB;
        public WriteToDatabase()
        {
            utils = new Utils();
            connectToDB = new ConnectToDB();
        }

        public int writeStoreToDB(string name, string city, string area, string code)
        {
            string query = @"INSERT INTO Store(Name, City, Area, Code) VALUES('" + name + "', '" + city + "', '" + area + "', '" + code + "');";

            return connectToDB.WriteToDB(query);
        }

        public int writeCategoryToDB(string name)
        {
            string query = @"INSERT INTO Category(Name) VALUES('" + name + "');";
            return connectToDB.WriteToDB(query);
        }

        public int writeItemToDB(string categoryName, string vendorName, string name, string code, string serialNo, string uom, string value, string length, string width)
        {
            int categoryId = utils.getCategoryIdFromName(categoryName);
            int vendorId = utils.getVendorIdFromName(vendorName);
            string query = @"INSERT INTO Item(CategoryId, VendorId, Name, Code, SerialNo, UOM, Value, Length, Width) VALUES( " + categoryId.ToString() + ", " + vendorId.ToString() + ", '" + name + "', '" + code + "', '" + serialNo + "', '" + uom + "', '" + value + "', " + length + ", " + width + ");";
            return connectToDB.WriteToDB(query);
        }

        public int writeItemToDB_updatedFunction(string categoryName, string name, string code, string serialNo, string uom, string value, string length, string width)
        {
            int categoryId = utils.getCategoryIdFromName(categoryName);
            string query = @"INSERT INTO Item(CategoryId, Name, Code, SerialNo, UOM, Value, Length, Width) VALUES( " + categoryId.ToString() + ", '" + name + "', '" + code + "', '" + serialNo + "', '" + uom + "', '" + value + "', " + length + ", " + width + ");";
            return connectToDB.WriteToDB(query);
        }

        public int writeVendorToDB(string name, string website, string phoneNo, string city, string country, string representative, string cellNo, string email)
        {
            string query = @"INSERT INTO Vendor(Name, Website, PhoneNo, City, Country, Representative, CellNo, Email) VALUES('" + name + "', '" + website + "', '" + phoneNo + "', '" + city + "', '" + country + "', '" + representative + "', '" + cellNo + "', '" + email + "');";
            return connectToDB.WriteToDB(query);
        }

        public int writeCustomerToDB(string name, string website, string phoneNo, string area, string city, string country, string ntnNo, string cellNo, string email)
        {
            string query = @"INSERT INTO Customer(Name, Website, PhoneNo, Area, City, Country, NtnNo, CellNo, Email) VALUES('" + name + "', '" + website + "', '" + phoneNo + "', '" + area + "', '" + city + "', '" + country + "', '" + ntnNo + "', '" + cellNo + "', '" + email + "');";
            return connectToDB.WriteToDB(query);
        }

        public int writeCustomerToDB_updatedFunction(string name, string phoneNo, string area, string city, string ntnNo)
        {
            string query = @"INSERT INTO Customer(Name, PhoneNo, Area, City, NtnNo) VALUES('" + name + "', '" + phoneNo + "', '" + area + "', '" + city + "', '" + ntnNo + "' );";
            return connectToDB.WriteToDB(query);
        }

        public int writeInventoryToDB(string categoryName, string vendorName, string itemName, string storeName, string serialNo, int quantity, DateTime entryDate, DateTime expiryDate)
        {
            int categoryId = utils.getCategoryIdFromName(categoryName);
            int vendorId = utils.getVendorIdFromName(vendorName);
            int itemId = utils.getItemIdFromName(itemName);
            int storeId = utils.getStoreIdFromName(storeName);
            string entryDateString = entryDate.ToString("yyyy-MM-dd");
            string expiryDateString = expiryDate.ToString("yyyy-MM-dd");
            string query = @"INSERT INTO Inventory(CategoryId, VendorId, ItemId, StoreId, SerialNo, Quantity, EntryDate, ExpiryDate) VALUES(" + categoryId.ToString() + ", " + vendorId.ToString() + ", " + itemId.ToString() + ", " + storeId.ToString() + ", '" + serialNo + "', " + quantity + ", '" + entryDateString + "', '" + expiryDateString + "');";

            // get item value from item table

            string value = utils.getValueFromItem(itemId.ToString(), categoryId.ToString()).ToString();

            // write transaction of stock in to database
            string queryToInsertTransactions = @"INSERT INTO Transactions (ItemId, CategoryId, StoreId, StockInQuantity, StockInPrice, StockInDate) VALUES(" + itemId.ToString() + "," +
                categoryId.ToString() + ", " + storeId.ToString() + ", " + quantity.ToString() + ", " + value + ", '" + DateTime.Now.ToString("yyyy-MM-dd") + "') ;";

            connectToDB.WriteToDB(queryToInsertTransactions);

            return connectToDB.WriteToDB(query);
        }

        public int writeInventoryToDB_updatedFunction(string categoryName, string vendorName, string itemName, string storeName, string serialNo, float quantity, DateTime entryDate, DateTime expiryDate, float purchasePrice, float salePrice)
        {
            int categoryId = utils.getCategoryIdFromName(categoryName);
            int vendorId = utils.getVendorIdFromName(vendorName);
            int itemId = utils.getItemIdFromName(itemName);
            int storeId = utils.getStoreIdFromName(storeName);
            string entryDateString = entryDate.ToString("yyyy-MM-dd");
            string expiryDateString = expiryDate.ToString("yyyy-MM-dd");

            
            string queryToCheckNegativeInventory = "SELECT COUNT(*) FROM Inventory WHERE ItemId = " + itemId +" AND Quantity < 0";

            // negative inventory exists - convert it to positive
            //if (connectToDB.executeScaler(queryToCheckNegativeInventory).ToString() != "0")
            //{
            //    string queryToSelectNegativeInventory = "SELECT TOP 1 InventoryId WHERE ItemId = " + itemId + " AND Quantity < 0";
            //    string queryToGetQuantityOfSelectedInventoryId = "";
            //    while (quantity > 0)
            //    {
            //        string inventoryId = connectToDB.executeScaler(queryToSelectNegativeInventory).ToString();
            //        if(string.IsNullOrEmpty(inventoryId) || string.IsNullOrWhiteSpace(inventoryId))
            //        {
            //            break;
            //        }
            //        queryToGetQuantityOfSelectedInventoryId = "SELECT Quantity FROM Inventory WHERE InventoryId = " + inventoryId + " ;";
            //        float quantityOfThisItemInInventory = float.Parse(connectToDB.executeScaler(queryToCheckNegativeInventory).ToString());

            //        string query = "";
            //        if (quantityOfThisItemInInventory == quantity)
            //        {
            //            query = "UPDATE Inventory SET Quantity = 0 WHERE InventoryId = " + inventoryId;

            //        }
            //        else if ( quantityOfThisItemInInventory< )
            //        {

            //        }

            //    }

            //    return 0;
            //}
            if (false)
            {

            }
            else
            {
                string query = @"INSERT INTO Inventory(CategoryId, VendorId, ItemId, StoreId, SerialNo, Quantity, EntryDate, ExpiryDate, PurchasePrice, SalePrice) VALUES(" + categoryId.ToString() + ", " + vendorId.ToString() + ", " + itemId.ToString() + ", " + storeId.ToString() + ", '" + serialNo + "', " + quantity + ", '" + entryDateString + "', '" + expiryDateString + "', " + purchasePrice + ", " + salePrice + " );";

                // get item value from item table

                string value = utils.getValueFromItem(itemId.ToString(), categoryId.ToString()).ToString();

                // write transaction of stock in to database
                string queryToInsertTransactions = @"INSERT INTO Transactions (ItemId, CategoryId, StoreId, StockInQuantity, StockInPrice, StockInDate) VALUES(" + itemId.ToString() + "," +
                    categoryId.ToString() + ", " + storeId.ToString() + ", " + quantity.ToString() + ", " + value + ", '" + DateTime.Now.ToString("yyyy-MM-dd") + "') ;";

                connectToDB.WriteToDB(queryToInsertTransactions);

                return connectToDB.WriteToDB(query);
            }
        }

        public int writeProfileInvoiceMasterToDB(string customerName, DateTime invoiceDate, string totalAmount, string weightPrice, string totalWeight)
        {
            int customerId = utils.getCustomerIdFromName(customerName);
            string dateOfInvoice = invoiceDate.ToString("yyyy-MM-dd");
            string query = @"INSERT INTO InvoiceMaster(CustomerId, InvoiceDate, TotalAmount, InvoiceStatus, WeightPrice, TotalWeight, InvoiceType) VALUES(" + customerId.ToString() + ", '" + dateOfInvoice + "', " + float.Parse(totalAmount) + ", 1, " + float.Parse(weightPrice) + ", " + float.Parse(totalWeight) + ", 'P' );";

            return connectToDB.WriteToDB(query);
        }

        public void writeInvoiceChildToDB(string itemName,string categoryName, string storeName, string quantityInString)
        {
            string itemId = utils.getItemIdFromName(itemName).ToString();
            string storeId = utils.getStoreIdFromName(storeName).ToString();
            string categoryId = utils.getCategoryIdFromName(categoryName).ToString();

            string latestInvoiceMasterId = utils.getLatestWrittenInvoiceMasterId();
            string queryToGetInventoryIdOfItem = "SELECT TOP 1 InventoryId FROM Inventory WHERE Quantity > 0 AND ItemId = " + itemId + " AND CategoryId = " + categoryId + " AND StoreId = " + storeId + " ORDER BY EntryDate ASC";

            float quantityToEnter = float.Parse(quantityInString);

            string updateInventoryQuery;

            while (quantityToEnter > 0)
            {
                string inventoryId = connectToDB.executeScaler(queryToGetInventoryIdOfItem).ToString();
                float quantityOfThisItem = utils.getQuantityOfInventoryUsingId(inventoryId);
                string remainingQuantity;
                float enteredQuantity;

                if (quantityToEnter <= quantityOfThisItem)
                {
                    remainingQuantity = (quantityOfThisItem - quantityToEnter).ToString();
                    enteredQuantity = quantityToEnter;
                }
                else
                {
                    remainingQuantity = "0";
                    enteredQuantity = quantityOfThisItem;
                }
                updateInventoryQuery = "UPDATE Inventory SET Quantity = " + remainingQuantity + " WHERE InventoryId = " + inventoryId + " ;";
                connectToDB.ExecuteNonQuery(updateInventoryQuery);

                string insertToInvoiceChildQuery = "INSERT INTO InvoiceChild(InvoiceMasterId, ItemId, Quantity, CategoryId, StoreId) VALUES(" + latestInvoiceMasterId + ", " + itemId + ", " + enteredQuantity.ToString() + ", " + categoryId + ", " + storeId + ")";
                connectToDB.ExecuteNonQuery(insertToInvoiceChildQuery);

                quantityToEnter -= quantityOfThisItem;
            }

            string value = utils.getValueFromItem(itemId, categoryId).ToString();
            // write transaction of stock out to database
            string queryToInsertTransactions = @"INSERT INTO Transactions(ItemId, CategoryId, StoreId, StockOutQuantity, StockOutPrice, StockOutDate) VALUES(" + itemId + "," +
                categoryId + ", " + storeId.ToString() + ", " + quantityInString + ", " + value + ", '" + DateTime.Now.ToString("yyyy-MM-dd") + "') ;";
            connectToDB.ExecuteNonQuery(queryToInsertTransactions);
        }

        public int writeUomToDB(string name)
        {
            string query = @"INSERT INTO Uom(Name) Values('" + name + "');";
            return connectToDB.WriteToDB(query);
        }

        public bool writeFabricatorsInvoice(string customerName, DateTime dateOfInvoice, string totalAmount, string projectSite, string atten, ArrayList listOfAllOrders, ArrayList listOfItemsInAnOrder, string storeName, bool showPdfAfterGeneration)
        {
            writeFabricatorInvoiceMasterToDB(customerName, dateOfInvoice, totalAmount, projectSite, atten);
            bool isInventoryNegative = writeFabricatorInvoiceChildToDB(listOfAllOrders, listOfItemsInAnOrder, storeName);

            utils.writeInvoiceOfConch(listOfAllOrders, customerName, projectSite, atten, showPdfAfterGeneration);
            return isInventoryNegative;
        }

        public int writeFabricatorInvoiceMasterToDB(string customerName, DateTime dateOfInvoice, string totalAmount, string projectSite, string atten)
        {
            string customerId = utils.getCustomerIdFromName(customerName).ToString();
            string query = "INSERT INTO InvoiceMaster(CustomerId, InvoiceDate, TotalAmount, InvoiceStatus, InvoiceType, ConchProjectSite, ConchAtten)" +
                " VALUES(" + customerId + ", '" + dateOfInvoice.ToString("yyyy-MM-dd") + "', " + totalAmount + ",1 , 'C', '" + projectSite + "',  '" + atten + "' );";

            return connectToDB.WriteToDB(query);
        }

        public bool writeFabricatorInvoiceChildToDB(ArrayList listOfAllOrders, ArrayList listOfItemsInAnOrder, string storeName)
        {
            string invoiceMasterId = utils.getLatestWrittenInvoiceMasterId();

            List<string> conchChildren = new List<string>();

            bool isInventoryNegative = false;

            //writing fabrication details to invoice child
            foreach (Dictionary<string, object> order in listOfAllOrders)
            {
                string width = order["Width"].ToString();
                string height = order["Height"].ToString();
                string quantity = order["Quantity"].ToString();
                string wastagePercentage = order["WastagePercentage"].ToString();
                string rateOfGlass = order["RateOfGlass"].ToString();
                string rateOfScreen = order["RateOfScreen"].ToString();
                string rateOfFabrications = order["RateOfFabrications"].ToString();
                string rateOfInstallation = order["RateOfInstallation"].ToString();
                string rateOfSealent = order["RateOfSealent"].ToString();
                string markUp = order["MarkUp"].ToString();
                string totalPrice = order["TotalPrice"].ToString();
                string description = order["Description"].ToString();

                string query = "INSERT INTO ConchChild(Width, Height, Quantity, WastagePercentage, RateOfGlass, RateOfScreen, RateOfFabrication, RateOfInstallation, RateOfSealent, MarkUp, TotalPrice, Description) " +
                    " VALUES(" + width + ", " + height + ", " + quantity + "," + wastagePercentage + ", " + rateOfGlass + ", " + rateOfScreen + ", " + rateOfFabrications + ", " + rateOfInstallation + ", " + rateOfSealent + ", " + markUp + ", " + totalPrice + ", '" + description + "')";

                connectToDB.WriteToDB(query);

                string conchChildId = utils.getLatestWrittenConchChildId();
                conchChildren.Add(conchChildId);
            }

            string queryToGetTheQuantityOfItemInInventory;
            string categoryId = utils.getCategoryIdFromName("Conch").ToString();
            string storeId = utils.getStoreIdFromName(storeName).ToString();

            int counter = 0;

            foreach (Dictionary<string, object> items in listOfItemsInAnOrder)
            {
                foreach (string item in items.Keys)
                {
                    string itemId = utils.getItemIdFromName(item).ToString();
                    
                    queryToGetTheQuantityOfItemInInventory = "SELECT SUM(Quantity) FROM Inventory WHERE ItemId = " + itemId + " AND CategoryId = " + categoryId + " AND StoreId = " + storeId + " ;";
                    string quantityOfThisItemInInventory = connectToDB.executeScaler(queryToGetTheQuantityOfItemInInventory).ToString();

                    float quantityToEnter = float.Parse(items[item].ToString());
                    string valueOfItem = utils.getValueFromItem(itemId, categoryId).ToString();

                    // if item not available in the inventory
                    if (string.IsNullOrEmpty(quantityOfThisItemInInventory) || quantityOfThisItemInInventory=="0") 
                    {
                        if (!isInventoryNegative)
                        {
                            isInventoryNegative = true;
                        }
                        string queryToAddNegativeInventory = "INSERT INTO Inventory(ItemId, StoreId, CategoryId, Quantity) VALUES(" + itemId + ", " + storeId + ", " + categoryId + ", " + (-quantityToEnter).ToString() + ");";
                        string queryToAddNegativeTransacation = "INSERT INTO Transactions(ItemId, StoreId, CategoryId, StockOutQuantity, StockOutPrice, StockOutDate) VALUES(" + itemId + ", " + storeId + ", " + categoryId + ", " + quantityToEnter.ToString() + ", " + valueOfItem + ", '" + DateTime.Now.ToString("yyyy-MM-dd") + "');";
                        string insertToInvoiceChildQuery = "INSERT INTO InvoiceChild(InvoiceMasterId, ItemId, Quantity, CategoryId, StoreId, ConchChildId) VALUES(" + invoiceMasterId + ", " + itemId + ", " + (-quantityToEnter).ToString() + ", " + categoryId + ", " + storeId + ", " + conchChildren[counter] + ");";

                        connectToDB.WriteToDB(queryToAddNegativeInventory);
                        connectToDB.WriteToDB(queryToAddNegativeTransacation);
                        connectToDB.WriteToDB(insertToInvoiceChildQuery);
                    }
                    
                    // inventory is equal to the quantity needed
                    else if (float.Parse(quantityOfThisItemInInventory) == quantityToEnter)
                    {
                        if (!isInventoryNegative)
                        {
                            isInventoryNegative = true;
                        }
                        // update existing inventory to zero
                        string queryToUpdateInventory = "UPDATE Inventory SET Quantity = 0 WHERE ItemId=" + itemId + " AND StoreId=" + storeId + " AND CategoryId=" + categoryId + ";";
                        string queryToAddTransacation = "INSERT INTO Transactions(ItemId, StoreId, CategoryId, StockOutQuantity, StockOutPrice, StockOutDate) VALUES(" + itemId + ", " + storeId + ", " + categoryId + ", " + quantityOfThisItemInInventory + "," + valueOfItem + ", '" + DateTime.Now.ToString("yyyy-MM-dd") + "');";
                        string insertToInvoiceChildQuery = "INSERT INTO InvoiceChild(InvoiceMasterId, ItemId, Quantity, CategoryId, StoreId, ConchChildId) VALUES(" + invoiceMasterId + ", " + itemId + ", " + quantityOfThisItemInInventory + ", " + categoryId + ", " + storeId + ", " + conchChildren[counter] + ");";

                        connectToDB.UpdateInDB(queryToUpdateInventory);
                        connectToDB.WriteToDB(queryToAddTransacation);
                        connectToDB.WriteToDB(insertToInvoiceChildQuery);
                    }
                    
                    // update exisiting to 0 and add remaining as negative rows
                    else if (float.Parse(quantityOfThisItemInInventory) < quantityToEnter)
                    {
                        if (!isInventoryNegative)
                        {
                            isInventoryNegative = true;
                        }
                        string queryToUpdateInventory = "UPDATE Inventory SET Quantity = 0 WHERE ItemId=" + itemId + " AND StoreId=" + storeId + " AND CategoryId=" + categoryId + ";";
                        string queryToAddTransacation = "INSERT INTO Transactions(ItemId, StoreId, CategoryId, StockOutQuantity, StockOutPrice, StockOutDate) VALUES(" + itemId + ", " + storeId + ", " + categoryId + ", " + quantityOfThisItemInInventory + ", " + valueOfItem + ", '" + DateTime.Now.ToString("yyyy-MM-dd") + "');";
                        string insertToInvoiceChildQuery = "INSERT INTO InvoiceChild(InvoiceMasterId, ItemId, Quantity, CategoryId, StoreId, ConchChildId) VALUES(" + invoiceMasterId + ", " + itemId + ", " + quantityOfThisItemInInventory + ", " + categoryId + ", " + storeId + ", " + conchChildren[counter] + ");";
                        connectToDB.WriteToDB(queryToUpdateInventory);
                        connectToDB.WriteToDB(queryToAddTransacation);
                        connectToDB.WriteToDB(insertToInvoiceChildQuery);

                        float remainingQuantity = quantityToEnter - float.Parse(quantityOfThisItemInInventory);
                        string queryToAddNegativeInventory = "INSERT INTO Inventory(ItemId, StoreId, CategoryId, Quantity) VALUES(" + itemId + ", " + storeId + ", " + categoryId + ", " + (remainingQuantity).ToString() + ");";
                        string queryToAddNegativeTransacation = "INSERT INTO Transactions(ItemId, StoreId, CategoryId, StockOutQuantity, StockOutPrice, StockOutDate) VALUES(" + itemId + ", " + storeId + ", " + categoryId + ", " + (remainingQuantity).ToString() + ", " + valueOfItem + ", '" + DateTime.Now.ToString("yyyy-MM-dd") + "');";
                        string insertToInvoiceChildNegativeQuery = "INSERT INTO InvoiceChild(InvoiceMasterId, ItemId, Quantity, CategoryId, StoreId, ConchChildId) VALUES(" + invoiceMasterId + ", " + itemId + ", " + (0 - float.Parse(quantityOfThisItemInInventory)).ToString() + ", " + categoryId + ", " + storeId + ", " + conchChildren[counter] + ");";
                        connectToDB.WriteToDB(queryToAddNegativeInventory);
                        connectToDB.WriteToDB(queryToAddNegativeTransacation);
                        connectToDB.WriteToDB(insertToInvoiceChildQuery);
                    }
                    else 
                    {
                        string updateInventoryQuery;
                        // Apply FIFO
                        string queryToGetInventoryIdOfItem = "SELECT TOP 1 InventoryId FROM Inventory WHERE Quantity > 0 AND ItemId = " + itemId + " AND CategoryId = " + categoryId + " AND StoreId = " + storeId + " ORDER BY EntryDate ASC";

                        while (quantityToEnter > 0)
                        {
                            string inventoryId = connectToDB.executeScaler(queryToGetInventoryIdOfItem).ToString();
                            float quantityOfThisItem = utils.getQuantityOfInventoryUsingId(inventoryId);
                            string remainingQuantity;
                            float enteredQuantity;

                            if (quantityToEnter <= quantityOfThisItem)
                            {
                                remainingQuantity = (quantityOfThisItem - quantityToEnter).ToString();
                                enteredQuantity = quantityToEnter;
                            }
                            else
                            {
                                remainingQuantity = "0";
                                enteredQuantity = quantityOfThisItem;
                            }
                            updateInventoryQuery = "UPDATE Inventory SET Quantity = " + remainingQuantity + " WHERE InventoryId = " + inventoryId + " ;";
                            connectToDB.ExecuteNonQuery(updateInventoryQuery);

                            string insertToInvoiceChildQuery = "INSERT INTO InvoiceChild(InvoiceMasterId, ItemId, Quantity, CategoryId, StoreId) VALUES(" + invoiceMasterId + ", " + itemId + ", " + enteredQuantity.ToString() + ", " + categoryId + ", " + storeId + ")";
                            connectToDB.ExecuteNonQuery(insertToInvoiceChildQuery);

                            quantityToEnter -= quantityOfThisItem;
                        }

                        // write transaction of stock out to database
                        string queryToInsertTransactions = @"INSERT INTO Transactions(ItemId, CategoryId, StoreId, StockOutQuantity, StockOutDate) VALUES(" + itemId + "," +
                            categoryId + ", " + storeId.ToString() + ", " + quantityToEnter + ", '" + DateTime.Now.ToString("yyyy-MM-dd") + "') ;";
                        connectToDB.ExecuteNonQuery(queryToInsertTransactions);
                    }
                }
                counter++;
            }
            // counter is incremented after each order is complete to get the next 

            //string queryToGetTheQuantityOfItemInInventory;
            //string categoryId = utils.getCategoryIdFromName("Conch").ToString();
            //string storeId = utils.getStoreIdFromName(storeName).ToString();

            #region removed code
            //foreach (Dictionary <string, object> items in listOfItemsInAnOrder)
            //{
            //    foreach(string item in items.Keys)
            //    {
            //        string itemId = utils.getItemIdFromName(item).ToString();

            //        queryToGetTheQuantityOfItemInInventory = "SELECT SUM(Quantity) FROM Inventory WHERE ItemId = " + itemId + " AND CategoryId = " + categoryId + " AND StoreId = " + storeId + " ;";
            //        string quantityOfThisItemInInventory = connectToDB.executeScaler(queryToGetTheQuantityOfItemInInventory).ToString();

            //        float quantityToEnter = float.Parse(items[item].ToString());

            //        // if item not available in the inventory
            //        if (string.IsNullOrEmpty(quantityOfThisItemInInventory))
            //        {
            //            string valueOfItem = utils.getValueFromItem(itemId, categoryId).ToString();
            //            string queryToAddNegativeInventory = "INSERT INTO Inventory(ItemId, StoreId, CategoryId, Quantity) VALUES(" + itemId + ", " + storeId + ", " + categoryId + ", " + (-quantityToEnter).ToString() + ");";
            //            string queryToAddNegativeTransacation = "INSERT INTO Transactions(ItemId, StoreId, CategoryId, StockOutQuantity, StockOutPrice, StockOutDate) VALUES(" + itemId + ", " + storeId + ", " + categoryId + ", " + (-quantityToEnter).ToString() + ", " + valueOfItem + ", '" + DateTime.Now.ToString("yyyy-MM-dd") + "');";

            //            connectToDB.WriteToDB(queryToAddNegativeInventory);
            //            connectToDB.WriteToDB(queryToAddNegativeTransacation);
            //        }
            //        // if item available in the inventory
            //        else if (float.Parse(quantityOfThisItemInInventory) < quantityToEnter)
            //        {
            //            string valueOfItem = utils.getValueFromItem(itemId, categoryId).ToString();
            //            // update existing inventory to zero
            //            string queryToUpdateInventory = "UPDATE Inventory SET Quantity = 0 WHERE ItemId=" + itemId + " AND StoreId=" + storeId + " AND CategoryId=" + categoryId + ";";
            //            string queryToAddTransacation = "INSERT INTO Transactions(ItemId, StoreId, CategoryId, StockOutQuantity, StockOutPrice, StockOutDate) VALUES(" + itemId + ", " + storeId + ", " + categoryId + ", " + quantityOfThisItemInInventory + ", " + valueOfItem + ", '" + DateTime.Now.ToString("yyyy-MM-dd") + "');";
            //            string insertToInvoiceChildQuery = "INSERT INTO InvoiceChild(InvoiceMasterId, ItemId, Quantity, CategoryId, StoreId) VALUES(" + invoiceMasterId + ", " + itemId + ", " + quantityOfThisItemInInventory + ", " + categoryId + ", " + storeId + ")";

            //            connectToDB.UpdateInDB(queryToUpdateInventory);
            //            connectToDB.WriteToDB(queryToAddTransacation);
            //            connectToDB.WriteToDB(insertToInvoiceChildQuery);

            //            // insert negative inventory existing 
            //            float remainingQuantity = quantityToEnter - float.Parse(quantityOfThisItemInInventory);
            //            string queryToAddNegativeInventory = "INSERT INTO Inventory(ItemId, StoreId, CategoryId, Quantity) VALUES(" + itemId + ", " + storeId + ", " + categoryId + ", " + (remainingQuantity).ToString() + ";";
            //            string queryToAddNegativeTransacation = "INSERT INTO Transactions(ItemId, StoreId, CategoryId, StockOutQuantity, StockOutPrice, StockOutDate) VALUES(" + itemId + ", " + storeId + ", " + categoryId + ", " + (remainingQuantity).ToString() + ", " + valueOfItem + ", '" + DateTime.Now.ToString("yyyy-MM-dd") + "');";
            //            connectToDB.WriteToDB(queryToAddNegativeInventory);
            //            connectToDB.WriteToDB(queryToAddNegativeTransacation);
            //        }

            //        // inventory is equal to the quantity needed
            //        else if(float.Parse(quantityOfThisItemInInventory) == quantityToEnter)
            //        {
            //            string valueOfItem = utils.getValueFromItem(itemId, categoryId).ToString();
            //            // update existing inventory to zero
            //            string queryToUpdateInventory = "UPDATE Inventory SET Quantity = 0 WHERE ItemId=" + itemId + " AND StoreId=" + storeId + " AND CategoryId=" + categoryId + ";";
            //            string queryToAddTransacation = "INSERT INTO Transactions(ItemId, StoreId, CategoryId, StockOutQuantity, StockOutPrice, StockOutDate) VALUES(" + itemId + ", " + storeId + ", " + categoryId + ", " + quantityOfThisItemInInventory + "," + valueOfItem + ", '" + DateTime.Now.ToString("yyyy-MM-dd") + "');";
            //            string insertToInvoiceChildQuery = "INSERT INTO InvoiceChild(InvoiceMasterId, ItemId, Quantity, CategoryId, StoreId) VALUES(" + invoiceMasterId + ", " + itemId + ", " + quantityOfThisItemInInventory + ", " + categoryId + ", " + storeId + ")";


            //            connectToDB.UpdateInDB(queryToUpdateInventory);
            //            connectToDB.WriteToDB(queryToAddTransacation);
            //            connectToDB.WriteToDB(insertToInvoiceChildQuery);
            //        }
            //        else
            //        {
            //            string updateInventoryQuery;
            //            // Apply FIFO
            //            string queryToGetInventoryIdOfItem = "SELECT TOP 1 InventoryId FROM Inventory WHERE Quantity > 0 AND ItemId = " + itemId + " AND CategoryId = " + categoryId + " AND StoreId = " + storeId + " ORDER BY EntryDate ASC";

            //            while (quantityToEnter > 0)
            //            {
            //                string inventoryId = connectToDB.executeScaler(queryToGetInventoryIdOfItem).ToString();
            //                float quantityOfThisItem = utils.getQuantityOfInventoryUsingId(inventoryId);
            //                string remainingQuantity;
            //                float enteredQuantity;

            //                if (quantityToEnter <= quantityOfThisItem)
            //                {
            //                    remainingQuantity = (quantityOfThisItem - quantityToEnter).ToString();
            //                    enteredQuantity = quantityToEnter;
            //                }
            //                else
            //                {
            //                    remainingQuantity = "0";
            //                    enteredQuantity = quantityOfThisItem;
            //                }
            //                updateInventoryQuery = "UPDATE Inventory SET Quantity = " + remainingQuantity + " WHERE InventoryId = " + inventoryId + " ;";
            //                connectToDB.ExecuteNonQuery(updateInventoryQuery);

            //                string insertToInvoiceChildQuery = "INSERT INTO InvoiceChild(InvoiceMasterId, ItemId, Quantity, CategoryId, StoreId) VALUES(" + invoiceMasterId + ", " + itemId + ", " + enteredQuantity.ToString() + ", " + categoryId + ", " + storeId + ")";
            //                connectToDB.ExecuteNonQuery(insertToInvoiceChildQuery);

            //                quantityToEnter -= quantityOfThisItem;
            //            }

            //            // write transaction of stock out to database
            //            string queryToInsertTransactions = @"INSERT INTO Transactions(ItemId, CategoryId, StoreId, StockOutQuantity, StockOutDate) VALUES(" + itemId + "," +
            //                categoryId + ", " + storeId.ToString() + ", " + quantityToEnter + ", " + DateTime.Now.ToString("yyyy-MM-dd") + "') ;";
            //            connectToDB.ExecuteNonQuery(queryToInsertTransactions);
            //        }
            //    }

            //}
            #endregion

            return isInventoryNegative;
        }
    }
}
