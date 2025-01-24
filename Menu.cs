using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStorage
{
    internal class Menu
    {

        public Menu()
        { }

        //Make the main menu
        public static string DisplayMenu()
        {

            Console.WriteLine("=========Main Menu==========");
            Console.WriteLine("Option 1: Add more food items");
            Console.WriteLine("Option 2: Display food items");
            Console.WriteLine("Option 3: Delete food items");
            Console.WriteLine("Option 4: Exit program");
            Console.WriteLine("============================");

            Console.Write("\nPlease make a selection:");
            string MenuSelect = Console.ReadLine();

            return MenuSelect;
        }
        
        
    }         
}



    