using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class UserInterface
    {
        //---Welcome massage
        public static void WelcomeMassage()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine(" *** Welcomer. PC - shop *** ");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("There are 3 option to shop: \n(press 1)--Parts  \n(press 2)--Modules  \n(press 3)--Configuration ");
            Console.WriteLine("-----------------------------");
        }

        //---Main Menu ENTER
        public static void MainMenu()
        {
            string enterMainMenuOption = Console.ReadLine();

            if (enterMainMenuOption == "1")
                PartsMenu.PartsMainMenu();
            else if (enterMainMenuOption == "2")
                ModulesMenu.ModulesMainMenu();
            else if (enterMainMenuOption == "3")
                ConfigurationsMenu.ConfigMainMenu();
            else
                Console.WriteLine("Enter 1 for Parts, 2 for Modules and 3 for Configuration");
        }



    }
}
