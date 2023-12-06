using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace LagerStyringsSystem
{
    internal class Warehouse
    {
        private List<IProduct> ProductList = new List<IProduct>();


        public void FindProduct(string productName)
        {
            foreach (var item in ProductList)
            {
                if (item.Name.Contains(productName))
                {
                    RemoveProduct(item);
                    return;
                }
            }
        }

        public void AddNewProduct(ConsoleKey inputNumber)
        {
            Console.WriteLine("Navnet på produktet?");
            var nameInput = Console.ReadLine();
            Console.WriteLine("Prisen på produktet?");
            var priceInput = Console.ReadLine();
            var priceAsDouble = Double.Parse(priceInput);
            switch (inputNumber)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("Størrelsen på produktet?");
                    var sizeInput = Console.ReadLine();
                    AddProduct(new Clothing(nameInput, priceAsDouble, sizeInput));
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("Utløpsdatoen på produktet?");
                    var expirationInput = Console.ReadLine();
                    AddProduct(new Food(nameInput, priceAsDouble, expirationInput));
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("Hvor mange måneder garanti er det på produktet?");
                    var guaranteeInput = Console.ReadLine();
                    var GuaranteeAsNumber = Int32.Parse(guaranteeInput);
                    AddProduct(new Electronics(nameInput, priceAsDouble, GuaranteeAsNumber));
                    break;
                default:
                    break;
            }
        }
        public void AddProduct(IProduct product)
        {
            ProductList.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            ProductList.Remove(product);
        }

        public void ShowProducts()
        {
            foreach (var product in ProductList)
            {
                product.PrintInfo();
            }
        }
    }
}
