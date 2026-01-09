using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.scenario_based.AtmDispense
{
     class AtmDispenseLogic
    {
        // Scenario A -> Given ₹1, ₹2, ₹5, ₹10, ₹20, ₹50, ₹100, ₹200,
        // ₹500 notes, find optimal
        public void StartFirst()
        {
            int[] notes = { 1, 2, 5, 10, 20, 50, 100, 200, 500 };
            int[] notesCount = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Console.Write("Enter the amount to debit from your account --> ");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int idx = notes.Length - 1;
            while (amount > 0)
            {
                if (amount >= notes[idx])
                {
                    amount -= notes[idx];
                    notesCount[idx]++;
                }
                else
                {
                    idx--;
                }
            }
            for (int i = 0; i < notes.Length; i++)
            {
                if (notesCount[i] > 0)
                {
                    Console.WriteLine($"{notes[i]} --> {notesCount[i]}");
                }
            }
        }

        // Scenario B -> Remove ₹500 temporarily and update strategy
        public void StartSecond()
        {
            int[] notes = { 1, 2, 5, 10, 20, 50, 100, 200 };
            int[] notesCount = { 0, 0, 0, 0, 0, 0, 0, 0 };
            Console.Write("Enter the amount to debit from your account --> ");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int idx = notes.Length - 1;
            while (amount > 0)
            {
                if (amount >= notes[idx])
                {
                    amount -= notes[idx];
                    notesCount[idx]++;
                }
                else
                {
                    idx--;
                }
            }
            for (int i = 0; i < notes.Length; i++)
            {
                if (notesCount[i] > 0)
                {
                    Console.WriteLine($"{notes[i]} --> {notesCount[i]}");
                }
            }
        }

        // Scenario C -> Display fallback combo if exact change isn’t possible
        public void StartThird()
        {
            int[] notes = { 1, 2, 5, 10, 20, 50, 100, 200, 500 };
            int[] notesCount = { 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int[] notesDispensed = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Console.Write("Enter the amount to debit from your account --> ");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int idx = notes.Length - 1;
            while (amount > 0 && idx >= 0)
            {
                if (amount >= notes[idx])
                {
                    if (notesCount[idx] > 0)
                    {
                        amount -= notes[idx];
                        notesCount[idx]--;
                        notesDispensed[idx]++;
                    }
                    if (notesCount[idx] == 0)
                    {
                        idx--;
                    }
                }
                else
                {
                    idx--;
                }
            }
            if (amount > 0)
            {
                Console.WriteLine("Failed to give the desired amount due to shortage of notes.");
            }
            else
            {
                for (int i = 0; i < notes.Length; i++)
                {
                    if (notesCount[i] == 0)
                    {
                        Console.WriteLine($"{notes[i]} --> {notesDispensed[i]}");
                    }
                }
            }
        }
    }
}
