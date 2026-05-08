using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_3
{
    internal static class InventoryService
    {
        public static List<Product> LoadFromCSV(string path)
        {
            List<Product> products = new List<Product>();

            if(!File.Exists(path))
            {
                return products;
            }

            var lines = File.ReadAllLines(path).Skip(1);

            foreach(string line in lines)
            {
                string[] parts = line.Split(',');

                if(parts.Length >= 5)
                {
                    try
                    {
                        int id = int.Parse(parts[0]);
                        string name = parts[1];
                        string brand = parts[2];
                        decimal price = decimal.Parse(parts[3]) / 100m;
                        int quantity = int.Parse(parts[4]);

                        products.Add(new Product(id, name, brand, price, quantity));
                    }
                    catch(Exception e)
                    {
                        //
                    }
                }
            }

            return products;
        }

        public static void SaveToCSV(string path, List<Product> products)
        {
            using(StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("ProductID,ProductName,ProductBrand,ProductPrice,ProductQuantity");
            }

            foreach(var p in products)
            {
                string line = $"{p.productID},{p.productName},{p.productBrand},{p.productPrice},{p.productQuantity}";
            }
        }
    }
}
