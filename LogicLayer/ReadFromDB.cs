using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLinkLayer;
using System.Data;

namespace LogicLayer
{
    public class ReadFromDB
    {
        public DataSet ReadStoresFromDB()
        {
            string query = "SELECT Name, City, Area, Code FROM Store;";
            return read(query);
        }

        public DataSet ReadStoreNamesFromDB()
        {
            string query = "SELECT Name FROM Store;";
            return read(query);
        }

        public DataSet ReadItemsFromDB()
        {
            string query = "SELECT Category.Name as Category, Vendor.Name as Vendor, Item.Name, Item.Code, Item.SerialNo, Item.UOM, Item.Value as 'Weight/KG', Item.Length, Item.Width FROM Item" +
                " JOIN Category ON Category.CategoryId = Item.CategoryId";
            return read(query);
        }

        public DataSet ReadItemsFromDB_updated()
        {
            string query = "SELECT Category.Name as Category, Item.Name, Item.Code, Item.SerialNo, Item.UOM, Item.Value, Item.Length, Item.Width FROM Item" +
                " JOIN Category ON Category.CategoryId = Item.CategoryId;";
            return read(query);
        }

        public DataSet ReadItemsForInvoiceFromDB()
        {
            string query = "SELECT ROW_NUMBER() OVER(ORDER BY (SELECT NULL)) as 'S.No', Item.Name + ' ( ' + Category.Name +' ) ' as 'Description', Item.Code as 'Code', Item.Value as 'Unit Weight', NULL as 'Quantity'" +
            " FROM Inventory" +
            " JOIN Item ON Inventory.ItemId = Item.ItemId" +
            " JOIN Category ON Inventory.CategoryId = Category.CategoryId";
            return read(query);
        }

        public DataSet ReadCategoriesFromDB()
        {
            string query = "SELECT Name FROM Category;";
            return read(query);
        }

        public DataSet ReadVendorsFromDB()
        {
            string query = "SELECT Name, Website, PhoneNo, City, Country, Representative, CellNo, Email FROM Vendor;";
            return read(query);
        }

        public DataSet ReadVendorNamesFromDB()
        {
            string query = "SELECT Name FROM Vendor;";
            return read(query);
        }

        public DataSet ReadCustomersFromDB()
        {
            string query = "SELECT Name, Website, PhoneNo, Area, City, Country, NtnNo, CellNo, Email FROM Customer;";
            return read(query);
        }

        public DataSet ReadCustomersFromDB_updatedFunction()
        {
            string query = "SELECT Name, PhoneNo, Area, City, NtnNo FROM Customer;";
            return read(query);
        }

        public DataSet ReadCustomerNamesFromDB()
        {
            string query = "SELECT Name FROM Customer;";
            return read(query);
        }

        public DataSet ReadInventoryFromDBUsingCategoryOnly(string categoryName)
        {
            Utils utils = new Utils();

            int categoryId = utils.getCategoryIdFromName(categoryName);

            string query = "SELECT Category.Name as Category, Vendor.Name as Vendor, Item.Name as Item, Store.Name as Warehouse, Inventory.SerialNo,Inventory.Quantity, Inventory.EntryDate, Inventory.ExpiryDate, Inventory.PurchasePrice, Inventory.SalePrice" +
                " FROM Inventory" +
                " JOIN Category ON Category.CategoryId = Inventory.CategoryId" +
                " JOIN Vendor ON Vendor.VendorId = Inventory.VendorId" +
                " JOIN Item ON Item.ItemId = Inventory.ItemId" +
                " JOIN Store ON Store.StoreId = Inventory.StoreId" +
                " WHERE Inventory.CategoryId = " + categoryId.ToString()+ 
                " AND Inventory.Quantity != 0 " +
                " ORDER BY EntryDate;";
            return read(query);
        }

        public DataSet ReadInventoryFromDBUsingCategoryAndItem(string categoryName, string itemName)
        {
            Utils utils = new Utils();

            int categoryId = utils.getCategoryIdFromName(categoryName);
            int itemId = utils.getItemIdFromName(itemName);

            string query = "SELECT Category.Name as Category, Vendor.Name as Vendor, Item.Name as Item, Store.Name as Store, Inventory.SerialNo,Inventory.Quantity, Inventory.EntryDate, Inventory.ExpiryDate, Inventory.PurchasePrice, Inventory.SalePrice" +
                " FROM Inventory" +
                " JOIN Category ON Category.CategoryId = Inventory.CategoryId" +
                " JOIN Vendor ON Vendor.VendorId = Inventory.VendorId" +
                " JOIN Item ON Item.ItemId = Inventory.ItemId" +
                " JOIN Store ON Store.StoreId = Inventory.StoreId" +
                " WHERE Inventory.CategoryId = " + categoryId.ToString() +
                " AND Inventory.ItemId = " + itemId.ToString() +
                " AND Inventory.Quantity != 0 " +
                " ORDER BY EntryDate;";
            return read(query);
        }

        public DataSet ReadItemBasedOnCategoryFromDB(string category)
        {
            Utils utils = new Utils();
            int categoryId = utils.getCategoryIdFromName(category);
            string query = "SELECT Name FROM Item WHERE CategoryId = " + categoryId.ToString() + ";";
            return read(query);
        }

        public DataSet ReadItemsFromInventoryBasedOnCategoryAndStoreFromDB(string category, string store)
        {
            Utils utils = new Utils();
            string storeId = utils.getStoreIdFromName(store).ToString();
            string categoryId = utils.getCategoryIdFromName(category).ToString();
            //string query = "SELECT DISTINCT Item.Name FROM Inventory " +
            //    " JOIN Item ON Inventory.ItemId = Item.ItemId" +
            //    " WHERE Inventory.CategoryId = " + categoryId + " AND Inventory.StoreId = " + storeId + " AND Inventory.Quantity > 0;";
            string query = "SELECT Item.Name FROM Inventory " +
                " JOIN Item ON Inventory.ItemId = Item.ItemId" +
                " WHERE Inventory.CategoryId = " + categoryId + " AND Inventory.StoreId = " + storeId + " AND Inventory.Quantity > 0 GROUP BY Item.Name";
            return read(query);
        }

        public DataSet ReadInventoryDistinctWhereQuantityNotZero()
        {
            DataSet temp = read("SELECT Distinct CategoryId, ItemId , StoreId FROM Inventory WHERE Quantity != 0");

            DataSet inventory = new DataSet();
            inventory.Tables.Add();
            inventory.Tables[0].Columns.Add("Description");
            inventory.Tables[0].Columns.Add("Warehouse");
            inventory.Tables[0].Columns.Add("Code");
            inventory.Tables[0].Columns.Add("Unit Weight");
            inventory.Tables[0].Columns.Add("Quantity");
            //inventory.Tables[0].Columns.Add("Purchase Price");
            //inventory.Tables[0].Columns.Add("Sale Price");

            foreach (DataRow row in temp.Tables[0].Rows)
            {
                string itemId = row["ItemId"].ToString();
                string categoryId = row["CategoryId"].ToString();
                string storeId = row["StoreId"].ToString();

                //string query = "SELECT Item.Name + ' ( ' + Category.Name +' )' as 'Description', Store.Name as 'Warehouse', Item.Code as 'Code', Item.Value as 'Unit Weight', NULL as 'Quantity', Inventory.PurchasePrice, Inventory.SalePrice  FROM Inventory JOIN Item ON Inventory.ItemId = Item.ItemId JOIN Category ON Inventory.CategoryId = Category.CategoryId JOIN Store ON Inventory.StoreId = Store.StoreId WHERE Item.ItemId = " + itemId + " AND Category.CategoryId = " + categoryId + " AND Store.StoreId = " + storeId + ";";
                string query = "SELECT Item.Name + ' ( ' + Category.Name +' )' as 'Description', Store.Name as 'Warehouse', Item.Code as 'Code', Item.Value as 'Unit Weight', NULL as 'Quantity' FROM Inventory JOIN Item ON Inventory.ItemId = Item.ItemId JOIN Category ON Inventory.CategoryId = Category.CategoryId JOIN Store ON Inventory.StoreId = Store.StoreId WHERE Item.ItemId = " + itemId + " AND Category.CategoryId = " + categoryId + " AND Store.StoreId = " + storeId + ";";
                DataRow readRow = read(query).Tables[0].Rows[0];
                inventory.Tables[0].Rows.Add(readRow.ItemArray);
            }

            return inventory;
        }

        public DataSet ReadAllInvoicesFromDB(string customerName, string status, string dateFrom, string dateTo)
        {
            Utils utils = new Utils();
            string query = "";
            if (customerName == "All" && status == "All" && dateFrom =="" && dateTo=="")
            {
                query = "SELECT InvoiceMasterId as 'Invoice No', Customer.Name, InvoiceDate, TotalAmount, (CASE WHEN InvoiceStatus <> 0 THEN 'open' ELSE 'closed' END) as 'Status', WeightPrice, TotalWeight  FROM InvoiceMaster" +
                    " JOIN Customer ON Customer.CustomerId = InvoiceMaster.CustomerId WHERE InvoiceMaster.InvoiceType='P'";
            }
            else if (customerName == "All" && status == "All" && dateFrom != "" && dateTo != "")
            {
                query = "SELECT InvoiceMasterId as 'Invoice No', Customer.Name, InvoiceDate, TotalAmount, (CASE WHEN InvoiceStatus <> 0 THEN 'open' ELSE 'closed' END) as 'Status', WeightPrice, TotalWeight  FROM InvoiceMaster" +
                    " JOIN Customer ON Customer.CustomerId = InvoiceMaster.CustomerId " +
                    " WHERE InvoiceMaster.InvoiceType='P' AND InvoiceMaster.InvoiceDate BETWEEN '" + dateFrom + "' AND '" + dateTo + "' ;";
            }
            else if (customerName != "All" && status == "All")
            {
                string customerId = utils.getCustomerIdFromName(customerName).ToString();
                query = "SELECT InvoiceMasterId as 'Invoice No', Customer.Name, InvoiceDate, TotalAmount, (CASE WHEN InvoiceStatus <> 0 THEN 'open' ELSE 'closed' END) as 'Status', WeightPrice, TotalWeight  FROM InvoiceMaster" +
                    " JOIN Customer ON Customer.CustomerId = InvoiceMaster.CustomerId" +
                    " WHERE InvoiceMaster.InvoiceType='P' AND Customer.CustomerId = " + customerId + " AND InvoiceMaster.InvoiceDate BETWEEN '" + dateFrom + "' AND '" + dateTo + "' ;";
            }
            else if (customerName == "All" && status != "All")
            {
                query = "SELECT InvoiceMasterId as 'Invoice No', Customer.Name, InvoiceDate, TotalAmount, (CASE WHEN InvoiceStatus <> 0 THEN 'open' ELSE 'closed' END) as 'Status', WeightPrice, TotalWeight  FROM InvoiceMaster" +
                    " JOIN Customer ON Customer.CustomerId = InvoiceMaster.CustomerId" +
                    " WHERE InvoiceMaster.InvoiceType='P' AND InvoiceMaster.InvoiceStatus = " + status + " AND InvoiceDate BETWEEN '" + dateFrom + "' AND '" + dateTo + "' ;";
            }
            else
            {
                string customerId = utils.getCustomerIdFromName(customerName).ToString();
                query = "SELECT InvoiceMasterId as 'Invoice No', Customer.Name, InvoiceDate, TotalAmount, (CASE WHEN InvoiceStatus <> 0 THEN 'open' ELSE 'closed' END) as 'Status', WeightPrice, TotalWeight  FROM InvoiceMaster" +
                    " JOIN Customer ON Customer.CustomerId = InvoiceMaster.CustomerId" +
                    " WHERE InvoiceMaster.InvoiceType='P' AND Customer.CustomerId=" + customerId + " AND InvoiceMaster.InvoiceStatus = " + status + " AND InvoiceDate BETWEEN '" + dateFrom + "' AND '" + dateTo + "' ;";
            }
            
            return read(query);
        }

        private DataSet read(string query)
        {
            ConnectToDB connectToDB = new ConnectToDB();

            DataSet data = connectToDB.ReadDatasetFromDB(query);

            return data;
        }

        public DataSet ReadUomFromDB()
        {
            string query = "SELECT Name FROM Uom;";
            return read(query);
        }

        public Dictionary<string, string> ReadAllNegativeItemsFromInventory()
        {
            ConnectToDB connectToDB = new ConnectToDB();
            Utils utils = new Utils();
            //string query = "SELECT DISTINCT Inventory.ItemId FROM Inventory JOIN Item ON Item.ItemId = Inventory.ItemId WHERE Inventory.Quantity < 0";
            string query = "SELECT DISTINCT ItemId FROM Inventory WHERE Quantity < 0";
            DataTable reader = connectToDB.ReadDatasetFromDB(query).Tables[0];

            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

            foreach(DataRow row in reader.Rows)
            {
                string itemId = row[0].ToString();

                query = "SELECT Name FROM Item WHERE ItemId = " + itemId + " ;";
                string itemName = connectToDB.executeScaler(query).ToString();
                query = "SELECT SUM(Quantity) FROM Inventory WHERE ItemId = " + itemId + " ;";
                string quantity = connectToDB.executeScaler(query).ToString();
                if (float.Parse(quantity) < 0)
                {
                    keyValuePairs.Add(itemName, quantity);
                }
            }

            return keyValuePairs;
        }
    }
}
