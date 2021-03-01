using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLinkLayer;

namespace LogicLayer
{
    public class DeleteFromDB
    {
        ConnectToDB connectToDB;
        public DeleteFromDB()
        {
            connectToDB = new ConnectToDB();
        }

        public int deleteStoreFromDB(string name)
        {
            string query = "DELETE FROM Store WHERE Name = '" + name + "';";
            return delete(query);
        }

        public int deleteItemFromDB(string name)
        {
            Utils utils = new Utils();
            int itemId = utils.getItemIdFromName(name);
            string query = "DELETE FROM Item WHERE ItemId = '" + itemId + "';";
            return delete(query);
        }

        public int deleteVendorFromDB(string name)
        {
            string query = "DELETE FROM Vendor WHERE Name = '" + name + "';";
            return delete(query);
        }

        public int deleteCustomerFromDB(string name)
        {
            string query = "DELETE FROM Customer WHERE Name = '" + name + "';";
            return delete(query);
        }

        public int deleteInventoryFromDB(string name)
        {
            Utils utils = new Utils();
            int item = utils.getItemIdFromName(name);
            string query = "DELETE FROM Inventory WHERE Item = '" + item + "';";
            return delete(query);
        }

        private int delete(string query)
        {
            ConnectToDB connectToDB = new ConnectToDB();
            return connectToDB.ExecuteNonQuery(query);
        }
    }
}
