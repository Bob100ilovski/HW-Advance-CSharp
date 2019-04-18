using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ModulesMenu
    {
        // ----- Modules MENU --------
        public static void ModulesMainMenu()
        {
            Console.Clear();
            Console.WriteLine("*** Modules Main Menu. ***");
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
            foreach (var item in Db.Modules)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine($"|Id:{item.Id}|Type:{item.Type}|");
                foreach (var itemPart in item.Parts)
                {
                    Console.WriteLine($"|{itemPart.Id} {itemPart.Name} {itemPart.Type} {itemPart.Company}|");
                }
            }
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Choose product ID and press any key to continue to Add to Card");
            Console.WriteLine("--------------------------------------------------------------");
            Console.ReadLine();
            AddToCard.SelectTheProductModules();
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
            foreach (var item2 in Db.Modules)
            {
                if (item2.Price > minPrice && item2.Price < maxPrice)
                {
                    Console.WriteLine("----------------------------");
                    Console.WriteLine($"|Price:{item2.Price}|Id:{item2.Id}|");
                    foreach (var itemPart in item2.Parts)
                    {
                        Console.WriteLine($"|{itemPart.Id} {itemPart.Name} {itemPart.Type} {itemPart.Company}|");
                    }
                }
            }
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Choose product ID and press any key to continue to Add to Card");
            Console.WriteLine("--------------------------------------------------------------");
            Console.ReadLine();
            AddToCard.SelectTheProductModules();
        }
        //----- By Price----- 

        //----- By Type-----
        public static void ByType()
        {
            Console.WriteLine("Sort parts by Type");
            Program.PopulateDb();
            foreach (var item in Db.Modules)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine($"|Type:{item.Type}|Id:{item.Id}");
                foreach (var item2 in item.Parts)
                {
                    Console.WriteLine($"|{item2.Id} {item2.Name} {item2.Type} {item2.Company}|");
                }
            }
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Choose product ID and press any key to continue to Add to Card");
            Console.WriteLine("--------------------------------------------------------------");
            Console.ReadLine();
            AddToCard.SelectTheProductModules();
        }
        //----- By Type----- 



    }
}
