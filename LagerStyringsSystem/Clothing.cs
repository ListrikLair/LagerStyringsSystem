using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagerStyringsSystem
{
    internal class Clothing : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Size;

        public Clothing(string name, double price, string size)
        {
            Name = name;
            Price = price;
            Size = size;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"\n{Name} - Koster: {Price} Kr - Størrelse: {Size}");
        }
    }
}
