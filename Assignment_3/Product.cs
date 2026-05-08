using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Product
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public string productBrand { get; set; }
        public decimal productPrice { get; set; }
        public int productQuantity { get; set; }

        public Product(int id, string name, string brand, decimal price, int quantity)
        {
            productID = id;
            productName = name;
            productBrand = brand;
            productPrice = price;
            productQuantity = quantity;
        }
    }
}
