using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace ConsoleApp
{
    public class AddToCard
    {
        public static Configuration ShopCard { get; private set; }

        public static void SelectTheProductParts()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("*** Add to card ***");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Please enter the product ID the one you choose");
            string readId = Console.ReadLine();
            int productId = int.Parse(readId);
            Console.WriteLine($"You select the product ID:{productId}");
            var myId = Db.Parts.Where(x => x.Id == productId).ToList();
            foreach (var item in myId)
            {
                Console.WriteLine($"You have add to card: {item.Id} {item.Name} {item.Type} {item.Company} of price {item.Price}$");
            }
            Console.WriteLine("Press any key to continue shoping");
            Console.ReadLine();

        }
        public static void SelectTheProductModules()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("*** Add to card ***");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Please enter the product ID the one you choose");
            string readId = Console.ReadLine();
            int productId = int.Parse(readId);
            Console.WriteLine($"You select the product ID:{productId}");
            var myId = Db.Modules.Where(x => x.Id == productId).ToList();
            foreach (var item in myId)
            {
                foreach (var item2 in item.Parts)
                {
                    Console.WriteLine($"You have add to card: {item.Id} {item2.Name} {item2.Type} of price {item.Price}$");
                }
            }
            Console.WriteLine("Press any key to continue shoping");
            Console.ReadLine();

        }
        public static void SelectTheProductConf()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("*** Add to card ***");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Please enter the product ID the one you choose");
            string readId = Console.ReadLine();
            int productId = int.Parse(readId);
            Console.WriteLine($"You select the product ID:{productId}");
            var myId = Db.Configurations.Where(x => x.Id == productId).ToList();
            foreach (var item in myId)
            {
                Console.WriteLine($"You have add to card: {item.Id} {item.Title} {item.Type} of price {item.Price}$");
            }
            Console.WriteLine("Press any key to continue shoping");
            Console.ReadLine();
        }
    }
}
