using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLinkLayer;

namespace LogicLayer
{
    public class UpdateInDB
    {
        ConnectToDB connectToDB;
        public UpdateInDB()
        {
            connectToDB = new ConnectToDB();
        }

        public int updateStoreInDatabase(string name, string city, string area, string code)
        {
            string query = @"UPDATE Store SET City = '" + city + "', Area = '" + area + "', Code='" + code + "' WHERE Name ='" + name + "';";
            return update(query);
        }

        public int updateItemInDatabase(string name, string code, string serialNo, string uom, string value, string length, string width)
        {
            string query = @"UPDATE Item SET Code = '" + code + "', SerialNo = '" + serialNo + "', UOM='" + uom + "', Value='" + value + "', Length =" + length + ", Width = " + width + " WHERE Name ='" + name + "';";
            return update(query);
        }

        public int updateVendorInDatabase(string name, string website, string phoneNo, string city, string country, string representative, string cellNo, string email)
        {
            string query = @"UPDATE Vendor SET Website = '" + website + "', PhoneNo = '" + phoneNo + "', City = '" + city + "', Country ='" + country + "', Representative = '" + representative + "', CellNo = '" + cellNo + "', Email = '" + email + "'" + " WHERE Name ='" + name + "';";
            return update(query);
        }

        public int updateCustomerInDatabase(string name, string website, string phoneNo, string area, string city, string country, string ntnNo, string cellNo, string email)
        {
            string query = @"UPDATE Customer SET Website = '" + website + "', PhoneNo = '" + phoneNo + "', Area = '"+area+"', City = '" + city + "', Country ='" + country + "', NtnNo = '" + ntnNo + "', CellNo = '" + cellNo + "', Email = '" + email + "'" + " WHERE Name ='" + name + "';";
            return update(query);
        }

        public int updateCustomerInDatabase_updatedFunction(string name, string phoneNo, string area, string city, string ntnNo)
        {
            string query = @"UPDATE Customer SET PhoneNo = '" + phoneNo + "', Area = '" + area + "', City = '" + city + "', NtnNo = '" + ntnNo + "' WHERE Name ='" + name + "';";
            return update(query);
        }

        public int updateInventoryInDatabase(string itemName, string quantity)
        {
            Utils utils = new Utils();
            int item = utils.getItemIdFromName(itemName);
            string query = @"UPDATE Inventory SET Quantity = '" + quantity + "' WHERE ItemId =" + item.ToString() + ";";
            return update(query);
        }

        public int updateInventoryBasedOnSameItem(string itemName, string categoryName, string storeName, string vendorName, string serialNo, string newQuantity, DateTime expiryDate)
        {
            Utils utils = new Utils();
            int itemId = utils.getItemIdFromName(itemName);
            int categoryId = utils.getCategoryIdFromName(categoryName);
            int storeId = utils.getStoreIdFromName(storeName);

            string quantityOfItemToUpdateQuery = "SELECT Quantity FROM Inventory WHERE ItemId = " + itemId.ToString() + " AND CategoryId = " + categoryId.ToString() + " AND StoreId = " + storeId.ToString() + " ;";
            string quantityOfItemToUpdate = connectToDB.executeScaler(quantityOfItemToUpdateQuery).ToString();

            int quantity = int.Parse(quantityOfItemToUpdate) + int.Parse(newQuantity);
            int vendorId = utils.getVendorIdFromName(vendorName);

            string expiryDateInString = expiryDate.ToString("yyyy-MM-dd");

            string query = "UPDATE Inventory SET VendorId = " + vendorId.ToString() + ", SerialNo = '" + serialNo + "', Quantity = " + quantity.ToString() + ", ExpiryDate = '" + expiryDateInString + "' WHERE ItemId = " + itemId.ToString() + " AND CategoryId = " + categoryId.ToString() + " AND StoreId = " + storeId.ToString() + " ;";
            return update(query);
        }

        private int update(string query)
        {
            return connectToDB.ExecuteNonQuery(query);
        }
    }
}
