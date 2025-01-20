using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStorage
{
    internal class AddFood
    {
        public AddFood() 
        { }

        public static void AddingFood()
        {
            string answer;

            do
            {
                string foodName;
                do
                {
                    Console.WriteLine("Enter in food name");
                    foodName = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(foodName))
                    {
                        Console.WriteLine("\nPlease enter valid food!!!\n");
                    }
                }
                while (string.IsNullOrWhiteSpace(foodName));


                string foodCat;
                do
                {
                    Console.WriteLine("Enter in food category");
                    foodCat = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(foodCat))
                    {
                        Console.WriteLine("\nPlease enter valid food category!!!\n");
                    }
                }
                while (string.IsNullOrWhiteSpace(foodCat));


                int foodQty = 0;
                string strFoodQty;
                do
                {
                    Console.WriteLine("Enter in food qty");
                    strFoodQty = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(strFoodQty))
                    {
                        Console.WriteLine("\nPlease enter valid food quantity!!!\n");
                    }
                    else
                    {
                        Boolean Valid = true;

                        while (Valid)
                        {

                            try
                            {
                                foodQty = int.Parse(strFoodQty);
                                Valid = false;
                            }
                            catch
                            {
                                Console.WriteLine("\nPlease enter valid food quantity!!!\n");
                                strFoodQty = Console.ReadLine();
                            }

                        }
                    }   
                }
                while (string.IsNullOrWhiteSpace(strFoodQty));


                string foodExp;
                do
                {
                    Console.WriteLine("Enter in food expiration date");
                    foodExp = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(foodExp))
                    {
                        Console.WriteLine("\nPlease enter valid expiration date!!!\n");
                    }
                }
                while (string.IsNullOrWhiteSpace(foodExp));



                FoodItem fi = new FoodItem(foodName, foodCat, foodQty, foodExp);


                Console.WriteLine("Would you like to enter in more food items?");

                answer = Console.ReadLine();

            }
            while (answer[0].ToString().ToUpper() == "Y");
        }
    }
}
