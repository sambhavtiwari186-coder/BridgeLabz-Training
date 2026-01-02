/*
========================================
SUMMARY:
This Cafeteria program is a menu-driven
console application that allows users to:
- View the cafeteria menu
- Order multiple food items
- Store ordered items using a List
- Display a final order summary
The program uses switch-case, loops,
arrays, and collections to simulate
a real-world cafeteria ordering system.
========================================
*/

using System;
using System.Collections.Generic;

namespace BridgeLabzTraining.scenario_based
{
    internal class Cafeteria
    {
        // Menu items
        string[] menu =
        {
            "Chilli Potato",
            "French Fries",
            "Diet Coke",
            "Burger",
            "Samosa",
            "Pizza",
            "Momos",
            "Masala Dosa",
            "Idli Sambhar",
            "Pav Bhaji"
        };

        // Stores ordered items
        List<string> orderList = new List<string>();

        public void Menu()
        {
            int choice;

            do
            {
                Console.WriteLine("\n-------------------- Welcome To GLA Cafeteria ----------------");
                Console.WriteLine("1. Display Menu");
                Console.WriteLine("2. Order Item");
                Console.WriteLine("3. Finish Order");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DisplayMenu(menu);
                        break;

                    case 2:
                        DisplayMenu(menu);
                        Console.Write("Enter item number to order: ");
                        int index = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (index >= 0 && index < menu.Length)
                        {
                            orderList.Add(menu[index]);
                            Console.WriteLine(menu[index] + " added to your order.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid item number!");
                        }
                        break;

                    case 3:
                        PrintFinalOrder();
                        Console.WriteLine("Thank you for visiting GLA Cafeteria!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

            } while (choice != 3);
        }
        // Writing a Method to display the menu of the Cafeteria
        public void DisplayMenu(string[] arr)
        {
            Console.WriteLine("\n--------- Cafeteria Menu ---------");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + arr[i]);
            }
        }
        // Writing a method to Print Final Order
        public void PrintFinalOrder()
        {
            Console.WriteLine("\n----------- Your Order -----------");

            if (orderList.Count == 0)
            {
                Console.WriteLine("No items ordered.");
                return;
            }

            for (int i = 0; i < orderList.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + orderList[i]);
            }
        }
    }
}
