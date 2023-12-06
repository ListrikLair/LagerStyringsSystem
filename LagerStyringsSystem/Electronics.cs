using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagerStyringsSystem
{
    internal class Electronics : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int ConsumerGuaranteeInMonths;

        public Electronics(string name, double price, int consumerGuaranteeInMonths)
        {
            Name = name;
            Price = price;
            ConsumerGuaranteeInMonths = consumerGuaranteeInMonths;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"\n{Name} - Koster: {Price} Kr - Garanti: {ConsumerGuaranteeInMonths} måneder");
        }
    }
}
