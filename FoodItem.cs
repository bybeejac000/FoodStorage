using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FoodStorage
{   
    internal class FoodItem
    {
        //Declare some attributes 

        public string name;
        public string category;
        public int qty;
        public string date;


        public FoodItem(string temp, string temp2, int temp3, string temp4)
        {
            name = temp;
            category = temp2;
            qty = temp3;
            date = temp4;

            FoodList.AddToStorage(this);
        }

    }

    //Make the foodclass list
    internal class FoodList
    {
        static List<FoodItem> storage = new List<FoodItem>();
        public FoodList()
        {

        }

        //Make a method to add items to the list
        public static void AddToStorage(FoodItem food)
        {
            storage.Add(food);
        }


        //One to remove foods
        public static void RemoveFromStorage()
        {
            Console.WriteLine("Which item would you like to remove");
            string temp = Console.ReadLine();

            for (int i = 0; i < storage.Count; i++)
            {
                if (storage[i].name.ToUpper() == temp.ToUpper())
                {
                    storage.Remove(storage[i]);
                }
            }

            Console.WriteLine("Item Removed");
        }


        //One to display all foods in the list
        public static void DisplayFood()
        {
            Console.WriteLine($"\n{"Name", -10} {"Category", -10} {"Qty", -7} {"Exp Date"}");
            Console.WriteLine(new string('-', 43));
            foreach (FoodItem food in storage)
            {


                Console.WriteLine($"{food.name, -10} {food.category, -10} {food.qty, -7} {food.date}");

                
            }
            Console.WriteLine("");

        }
    }
}