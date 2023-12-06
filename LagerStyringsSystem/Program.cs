using System.Runtime.CompilerServices;

namespace LagerStyringsSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var warehouse = new Warehouse();
            Init();
            void Init()
            {
                warehouse.AddProduct(new Clothing("Polo", 59.90, "L"));
                warehouse.AddProduct(new Clothing("Jeans", 299.99, "XXL"));
                warehouse.AddProduct(new Clothing("Fleecejakke", 639.50, "S"));
                warehouse.AddProduct(new Food("Agurk", 34.45, "22/12/2023"));
                warehouse.AddProduct(new Food("Banan", 20, "6/12/2023"));
                warehouse.AddProduct(new Food("Honning", 89.99, "31/12/9999"));
                warehouse.AddProduct(new Electronics("Laptop", 9999.99, 12));
                warehouse.AddProduct(new Electronics("Kjøleskap", 24000, 24));
                warehouse.AddProduct(new Electronics("Vaskemaskin", 5890, 5));
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Lager styringssystem");
                warehouse.ShowProducts();
                Console.WriteLine("(1) Legg til et produkt\n(2) Slett et produkt");
                var input = Console.ReadKey().Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("Hvilket type produkt er det? \n(1) Klær\n(2) Mat\n(3) Elektronikk");
                        var addInput = Console.ReadKey().Key;
                        warehouse.AddNewProduct(addInput);
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("Hvilket produkt vil du slette");
                        var deleteInput = Console.ReadLine();
                        warehouse.FindProduct(deleteInput);
                        break;
                    default:
                        continue;
                }
            }
        }
    }
}