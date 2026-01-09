using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.scenario_based.AtmDispense
{
     class AtmDispenseMain
    {
        
            public static void Main(string[] args)
            {
                Console.WriteLine("Welcome to XYZ atm");
                AtmDispenseLogic atm = new AtmDispenseLogic();
                Console.WriteLine("Scenario A -> Given ₹1, ₹2, ₹5, ₹10, ₹20, ₹50, ₹100, ₹200, ₹500 notes, find optimal.");
                atm.StartFirst();
                Console.WriteLine("Scenario B -> Remove ₹500 temporarily and update strategy.");
                atm.StartSecond();
                Console.WriteLine("Scenario C -> Display fallback combo if exact change isn’t possible.");
                atm.StartThird();
            }
        }
    }
