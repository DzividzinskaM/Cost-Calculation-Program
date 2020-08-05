using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cost_Calculation_Lib
{
    public class ProductDB
    {
        private DB db;
        private string connectionStr;
        private List<Product> products;

        public ProductDB()
        {
            db = DB.GetDBInstance();
            connectionStr = DB.GetConnectionString();
            products = new List<Product>();
            getLstFromDB();
        }

        public void getLstFromDB()
        {
            string cmdStr = $"select * from {db.productsTable}";
            using(SqlConnection cn = new SqlConnection(connectionStr))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(cmdStr, cn);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Product product = new Product((string)rd[db.productNameAttr], (int)rd[db.priceAttr]);
                    if (!products.Contains(product))
                    {
                        products.Add(product);
                    }
                }
            }
        }

        public bool addProduct(Product product)
        {
            string cmdStr = $"insert into {db.productsTable}({db.productNameAttr}," +
                $" {db.priceAttr}) values(@{db.productNameAttr}, @{db.priceAttr})";
            Console.WriteLine(connectionStr);
            using(SqlConnection cn = new SqlConnection(DB.GetConnectionString()))
            {
                
                cn.Open();
                SqlCommand cmd = new SqlCommand(cmdStr, cn);
                cmd.Parameters.AddWithValue($"@{db.productNameAttr}", product.name);
                cmd.Parameters.AddWithValue($"@{db.priceAttr}", product.price);

                int res = cmd.ExecuteNonQuery();
                if (res != 1)
                    return false;
                else
                {
                    getLstFromDB();
                    return true;
                }
            }          
        }

        public bool existProduct(string productName)
        {
            var res = products.Any(product => product.name == productName);
            Console.WriteLine($"result {res}");
            return res;
        }

        public Product getProduct(string name)
        {
            return products.Where(prod => prod.name == name).First();
        }
    }
}
