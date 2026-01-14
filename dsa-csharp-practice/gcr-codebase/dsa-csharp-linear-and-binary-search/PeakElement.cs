using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Linear_And_Binary_Search
{
    internal class PeakElement
    {
        static void Main()
       {
           Console.Write("Enter number of elements --> ");
          int n = Convert.ToInt32(Console.ReadLine());

                    int[] number = new int[n];

                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Enter element --> ");
                        number[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    int l = 0;
                    int r = number.Length - 1;

                    while (l < r)
                   {
                        int mid = l + (r - l) / 2;

                       if (number[mid] < number[mid + 1])
                        {
                            l = mid + 1;
                        }
                        else
                        {
                            r = mid;
                        }
                    }
                    Console.WriteLine($"Peak element idx --> {l}");
                   Console.WriteLine($"Peak element val --> {number[l]}");
               }
    }
}
