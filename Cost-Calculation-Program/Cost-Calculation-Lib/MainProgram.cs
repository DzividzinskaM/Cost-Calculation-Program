using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cost_Calculation_Lib
{
    public class MainProgram
    {
        public ProductDB productDb { get; }

        public MainProgram()
        {
            productDb = new ProductDB();
        }
        public bool addingNewProduct(string name, string price)
        {

            name = name.Trim();
            name = name.ToLower();
            price = price.Trim();

            int priceNum;
            if (!Int32.TryParse(name, out int res))
                return false;
            else
                priceNum = res;

            Product product = new Product(name, priceNum);
            if (!productDb.addProduct(product))
                return false;
            return true;

          /*  productDb.getLstFromDB();
            return true;*/
        }

        public bool existingProduct(string name)
        {
            name = name.Trim();
            name = name.ToLower();

            if (!productDb.existProduct(name))
                return false;
            else
                return true;

        }

        public Product getProduct(string name)
        {
            //add checking 
            name = name.Trim();
            name = name.ToLower();

           return productDb.getProduct(name);


        }
    }
}
