using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class PartsMenu
    {
        // ----- Parts MENU -------
        public static void PartsMainMenu()
        {
            Console.Clear();
            Console.WriteLine("*** Parts Main Menu. ***");
            Console.WriteLine("(press 1)--All product  \n(press 2)--Sort by Price  \n(press 3)--Sort by Type ");
            string enterMainManu = Console.ReadLine();
            if (enterMainManu == "1")
                AllProduct();
            else if (enterMainManu == "2")
                ByPrice();
            else if (enterMainManu == "3")
                ByType();
            else
                Console.WriteLine("Please enter numbers from 1 to 4");
        }


        //----- All Parts-----
        public static void AllProduct()
        {
            Program.PopulateDb();
            for (int i = 0; i < Db.Parts.Count; i++)
            {
                Console.WriteLine("-------------------------------------------------------------------------------");
                Console.WriteLine($"|Id:{Db.Parts[i].Id}|Name:{Db.Parts[i].Name}|Price:{Db.Parts[i].Price}|By_Type:{Db.Parts[i].Type}|Company:{Db.Parts[i].Company}|Quantity:{Db.Parts[i].Quantity}");
            }
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Choose product ID and press any key to continue to Add to Card");
            Console.WriteLine("--------------------------------------------------------------");
            Console.ReadLine();
            AddToCard.SelectTheProductParts();
        }
        //----- All Parts----- 


        //----- By Price-----
        public static void ByPrice()
        {
            Console.WriteLine("Enter minimum Price");
            string userMinPrice = Console.ReadLine();
            int minPrice = int.Parse(userMinPrice);
            Console.WriteLine("Enter maximum Price");
            string userMaxPrice = Console.ReadLine();
            int maxPrice = int.Parse(userMaxPrice);
            Program.PopulateDb();
            foreach (var item in Db.Parts)
            {
                if (item.Price > minPrice && item.Price < maxPrice)
                {
                    Console.WriteLine("-------------------------------------------------------------------------------");
                    Console.WriteLine($"|Id:{item.Id}|Name:{item.Name}|Price:{item.Price}|By_Type:{item.Type}|Company:{item.Company}|Quantity:{item.Quantity}");
                }
            }
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Choose product ID and press any key to continue to Add to Card");
            Console.WriteLine("--------------------------------------------------------------");
            Console.ReadLine();
            AddToCard.SelectTheProductParts();
        }
        //----- By Price----- 

        //----- By Type-----
        public static void ByType()
        {
            Console.WriteLine("Sort parts by Type");
            Program.PopulateDb();
            foreach (var item in Db.Parts)
            {
                Console.WriteLine("-------------------------------------------------------------------------------");
                Console.WriteLine($"|By_Type:{item.Type}|Id:{item.Id}|Name:{item.Name}|Price:{item.Price}|Company:{item.Company}|Quantity:{item.Quantity}");
            }
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Choose product ID and press any key to continue to Add to Card");
            Console.WriteLine("--------------------------------------------------------------");
            Console.ReadLine();
            AddToCard.SelectTheProductParts();
        }
        //----- By Type----- 




    }
}
