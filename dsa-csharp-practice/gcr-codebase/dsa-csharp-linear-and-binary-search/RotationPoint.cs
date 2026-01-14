using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Linear_And_Binary_Search
{
    class RotationPoint
    {
        static void Main()
        {
            Console.Write("Enter number of elements --> ");
           int n = int.Parse(Console.ReadLine());

                    int[] numbers = new int[n];

                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Enter element --> ");
                      numbers[i] = int.Parse(Console.ReadLine());
                    }

                    int left = 0;
                    int right = numbers.Length - 1;

                    while (left < right)
                    {
                        int mid = left + (right - left) / 2;

                        if (numbers[mid] > numbers[right])
                        {
                            left = mid + 1;
                        }
                        else
                       {
                            right = mid;
                        }
                    }

                    Console.WriteLine($"Rotation point idx --> {left}");
                }

    }
}
