using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cost_Calculation_Lib
{
    public class DB
    {
        private static DB instance;

        private static string name = "SqlProvider";

        public static string connectionStr;

        public readonly string productsTable = "Products";

        public readonly string productIdAttr = "productId";
        public readonly string productNameAttr = "productName";
        public readonly string priceAttr = "price";


        private DB()
        {
            GetConnectionString();
        }

        public static DB GetDBInstance()
        {
            if (instance == null)
                instance = new DB();
            return instance;
        }

        public static string GetConnectionString()
        {

            string returnValue = null;

            if (ConfigurationManager.ConnectionStrings[name] != null)
                returnValue = ConfigurationManager.ConnectionStrings[name].ConnectionString;

            return returnValue;
        }
    }
}
