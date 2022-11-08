using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Orders
{
    class Orders
    {
        static void Main()
        {
            Dictionary<string, Dictionary<decimal, int>> products = new Dictionary<string, Dictionary<decimal, int>>();
            string command = Console.ReadLine();

            while (command != "buy")
            {
                string[] productInfo = command.Split().ToArray();
                string product = productInfo[0];
                decimal productPrice = decimal.Parse(productInfo[1]);
                int productQuantity = int.Parse(productInfo[2]);

                if (!products.ContainsKey(product))
                {
                    products.Add(product, new Dictionary<decimal, int>());
                    products[product].Add(productPrice, productQuantity);
                }
                else
                {
                    if (products[product].ContainsKey(productPrice))
                    {
                        products[product][productPrice] += productQuantity;
                    }
                    else
                    {
                        int newQuantity = products[product].FirstOrDefault().Value + productQuantity;
                        products[product].Remove(products[product].FirstOrDefault().Key);
                        products[product].Add(productPrice, newQuantity);
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var item in products)
            {
                string productName = item.Key;
                foreach (var priceQuantity in item.Value)
                {
                    decimal totalPrice = priceQuantity.Key * priceQuantity.Value;
                    Console.WriteLine($"{productName} -> {totalPrice}");
                }                
            }
        }
    }
}
