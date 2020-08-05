using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cost_Calculation_Lib
{
    public class Product
    {
        public string name { get; }
        public int price { get; }

        public int id { get; }

        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
