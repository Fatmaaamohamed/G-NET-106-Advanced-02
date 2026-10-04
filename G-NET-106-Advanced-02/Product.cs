using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_106_Advanced_02
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; } 
        public double Price { get; set; }
        public int Stock { get; set; }

        #region Task1
        public static void PrintProducts(List<Product> products)
        {
            foreach (Product product in products)
            {
                Console.WriteLine($"{product.Name} - ${product.Price} (Stock: {product.Stock})");
            }
        }

        #endregion
    }
}
