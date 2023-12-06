using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagerStyringsSystem
{
    internal class Food : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string ExpirationDate;

        public Food(string name, double price, string expirationDate)
        {
            Name = name;
            Price = price;
            ExpirationDate = expirationDate;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"\n{Name} - Koster: {Price} Kr - Utløpsdato: {ExpirationDate}");
        }
    }
}
