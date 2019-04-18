using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ConfigurationsMenu
    {
        public static void ConfigMainMenu()
        {
            Console.Clear();
            Console.WriteLine("*** Configuration Main Menu. ***");
            Console.WriteLine("(press 1)--All product  \n(press 2)--Sort by Price  \n(press 3)--Sort by Type ");
            string enterMainManu = Console.ReadLine();
            if (enterMainManu == "1")
                AllProduct();
            else if (enterMainManu == "2")
                ByPrice();
            else if (enterMainManu == "3")
                ByType();

        }

        //----- All Parts-----
        public static void AllProduct()
        {
            Program.PopulateDb();
            foreach (var item in Db.Configurations)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine($"|Id:{item.Id}|Configuration type:{item.Type}|Price:{item.Price}|");
                Console.WriteLine("----------------------------");
                foreach (var itemPart in item.Modules)
                {
                    foreach (var itemDeeperThanUniverse in itemPart.Parts)
                    {
                        Console.WriteLine($"|{itemPart.Type}|{itemDeeperThanUniverse.Company}|{itemDeeperThanUniverse.Name}|");
                    }
                }
            }
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Choose product ID and press any key to continue to Add to Card");
            Console.WriteLine("--------------------------------------------------------------");
            Console.ReadLine();
            AddToCard.SelectTheProductConf();
        }
        //----- All Parts----- 

        //----- By Price----- 
        public static void ByPrice()
        {
            Console.WriteLine("Enter minimum Price Module");
            string userMinPrice = Console.ReadLine();
            int minPrice = int.Parse(userMinPrice);
            Console.WriteLine("Enter maximum Price Module");
            string userMaxPrice = Console.ReadLine();
            int maxPrice = int.Parse(userMaxPrice);
            Program.PopulateDb();
            foreach (var item in Db.Configurations)
            {
                if (item.Price > minPrice && item.Price < maxPrice)
                {
                    Console.WriteLine("----------------------------");
                    Console.WriteLine($"|Id:{item.Id}|Configuration type:{item.Type}|Price:{item.Price}|");
                    Console.WriteLine("----------------------------");
                }
            }
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Choose product ID and press any key to continue to Add to Card");
            Console.WriteLine("--------------------------------------------------------------");
            Console.ReadLine();
            AddToCard.SelectTheProductConf();
        }
        //----- By Price----- 

        //----- By Type-----
        public static void ByType()
        {
            Console.WriteLine("Sort parts by Type");
            Program.PopulateDb();
            foreach (var item in Db.Configurations)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine($"|Id:{item.Id}|Configuration type:{item.Type}|Price:{item.Price}|");
                Console.WriteLine("----------------------------");
            }
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Choose product ID and press any key to continue to Add to Card");
            Console.WriteLine("--------------------------------------------------------------");
            Console.ReadLine();
            AddToCard.SelectTheProductConf();
        }
        //----- By Type----- 





    }
}
