using FoodStorage;
using System;


internal class Program
{
    private static void Main()
    {
        string answer;

        //Grab the menu class
        Menu menu = new Menu();

        //Make never ending loop until broken by program exit
        while (true)
        {
            answer = Menu.DisplayMenu();

            if (answer == "1")
            {
                AddFood.AddingFood();
            }
            else if (answer == "2")
            {
                FoodList.DisplayFood();
            }
            else if (answer == "3")
            {
                FoodList.RemoveFromStorage();
            }
            else if (answer == "4")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\n\nPlease enter a valid input!!!");
            }
        }

    }
}