using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Sorting_Algorithms
{
    internal class InsertionSortEmployeeId
    {
        static void InsertionSort(int[] empIds)
        {
            int n = empIds.Length;

            for (int i = 1; i < n; i++)
            {
                int key = empIds[i];
                int j = i - 1;

                // Shift elements greater than key to one position ahead
                while (j >= 0 && empIds[j] > key)
                {
                    empIds[j + 1] = empIds[j];
                    j--;
                }

                // Insert key at correct position
                empIds[j + 1] = key;
            }
        }

        static void Main()
        {
            int[] employeeIds = new int[5];
            Console.WriteLine("Enter the Employee Id Here");
            for(int i = 0; i < employeeIds.Length; i++)
            {
                employeeIds[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Before Sorting:");
            foreach (int id in employeeIds)
                Console.Write(id + " ");

            InsertionSort(employeeIds);

            Console.WriteLine("\nAfter Sorting (Ascending Order):");
            foreach (int id in employeeIds)
                Console.Write(id + " ");
        }
    }
}
