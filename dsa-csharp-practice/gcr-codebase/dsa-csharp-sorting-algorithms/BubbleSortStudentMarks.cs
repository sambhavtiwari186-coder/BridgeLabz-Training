using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Sorting_Algorithms
{
    internal class BubbleSortStudentMarks
    {
        static void BubbleSort(int[] marks)
        {
            int n = marks.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (marks[j] > marks[j + 1])
                    {
                        // Swap
                        int temp = marks[j];
                        marks[j] = marks[j + 1];
                        marks[j + 1] = temp;

                        swapped = true;
                    }
                }

                // If no swaps occurred, array is sorted
                if (!swapped)
                    break;
            }
        }

        static void Main()
        {
            int[] studentMarks = new int[10];
            Console.WriteLine("Enter Student Marks Here :: ");
            for(int i = 0; i < 10; i++)
            {
                studentMarks[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Before Sorting:");
            foreach (int mark in studentMarks)
                Console.Write(mark + " ");

            BubbleSort(studentMarks);

            Console.WriteLine("\nAfter Sorting (Ascending Order):");
            foreach (int mark in studentMarks)
                Console.Write(mark + " ");
        }
    }
}
