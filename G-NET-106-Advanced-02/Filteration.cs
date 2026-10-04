using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_106_Advanced_02
{

    internal class Filteration
    {
        #region Task1
        public static List<Product> SearchProducts(List<Product> catalog, Func<Product, bool> filter)
        {
            List<Product> result = new List<Product>();
            foreach (Product product in catalog)
            {
                if (filter(product))
                {
                    result.Add(product);
                }
            }
            return result;
        }

        #endregion

        #region Task3
        public static List<Product> PrintReport(List<Product> catalog, Action<Product> format)
        {
            List<Product> result = new List<Product>();
            foreach (Product product in catalog)
            {
                format(product);
            }
            return result;
        }

        #endregion
    }
}   

