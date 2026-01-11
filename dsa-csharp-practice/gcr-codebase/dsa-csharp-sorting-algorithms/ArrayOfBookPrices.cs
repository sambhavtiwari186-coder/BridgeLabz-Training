using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Sorting_Algorithms
{
    internal class ArrayOfBookPrices
    {
        class BookPriceSorter
        {
            // Method to perform Merge Sort
            public static void MergeSort(double[] prices, int left, int right)
            {
                if (left < right)
                {
                    int mid = left + (right - left) / 2;

                    // Sort first and second halves
                    MergeSort(prices, left, mid);
                    MergeSort(prices, mid + 1, right);

                    // Merge the sorted halves
                    Merge(prices, left, mid, right);
                }
            }

            // Method to merge two sorted subarrays
            private static void Merge(double[] prices, int left, int mid, int right)
            {
                int n1 = mid - left + 1;
                int n2 = right - mid;

                double[] leftArray = new double[n1];
                double[] rightArray = new double[n2];

                // Copy data to temporary arrays
                for (int i = 0; i < n1; i++)
                    leftArray[i] = prices[left + i];

                for (int j = 0; j < n2; j++)
                    rightArray[j] = prices[mid + 1 + j];

                int iIndex = 0, jIndex = 0, k = left;

                // Merge the temp arrays back into prices[]
                while (iIndex < n1 && jIndex < n2)
                {
                    if (leftArray[iIndex] <= rightArray[jIndex])
                    {
                        prices[k] = leftArray[iIndex];
                        iIndex++;
                    }
                    else
                    {
                        prices[k] = rightArray[jIndex];
                        jIndex++;
                    }
                    k++;
                }

                // Copy remaining elements
                while (iIndex < n1)
                {
                    prices[k] = leftArray[iIndex];
                    iIndex++;
                    k++;
                }

                while (jIndex < n2)
                {
                    prices[k] = rightArray[jIndex];
                    jIndex++;
                    k++;
                }
            }

            // Driver method
            public static void Main()
            {
                double[] bookPrices = { 499.99, 199.50, 899.00, 299.75, 150.00 };

                Console.WriteLine("Book Prices before sorting:");
                foreach (double price in bookPrices)
                    Console.Write(price + " ");

                MergeSort(bookPrices, 0, bookPrices.Length - 1);

                Console.WriteLine("\n\nBook Prices after sorting (Ascending Order):");
                foreach (double price in bookPrices)
                    Console.Write(price + " ");
            }
        }
    }
}
