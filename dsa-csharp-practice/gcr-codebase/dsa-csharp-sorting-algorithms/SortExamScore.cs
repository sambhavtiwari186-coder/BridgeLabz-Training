using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Sorting_Algorithms
{
    internal class SortExamScore
    {
        class StudentScoreSorter
        {
            // Method to perform Selection Sort
            public static void SelectionSort(int[] scores)
            {
                int n = scores.Length;

                for (int i = 0; i < n - 1; i++)
                {
                    int minIndex = i;

                    // Find the minimum element in unsorted part
                    for (int j = i + 1; j < n; j++)
                    {
                        if (scores[j] < scores[minIndex])
                        {
                            minIndex = j;
                        }
                    }

                    // Swap the found minimum element with the first unsorted element
                    int temp = scores[minIndex];
                    scores[minIndex] = scores[i];
                    scores[i] = temp;
                }
            }

            // Driver method
            static void Main()
            {
                int[] examScores = { 78, 92, 65, 88, 70, 95 };

                Console.WriteLine("Student Exam Scores before sorting:");
                foreach (int score in examScores)
                    Console.Write(score + " ");

                SelectionSort(examScores);

                Console.WriteLine("\n\nStudent Exam Scores after sorting (Ascending Order):");
                foreach (int score in examScores)
                    Console.Write(score + " ");
            }
        }
    }
}
