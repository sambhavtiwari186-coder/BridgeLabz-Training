using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.Level_03
{
    internal class NumberChecker5
    {
            // Finding factors of a number
            public static int[] Factors(int n)
            {
                int tem = Math.Abs(n);
                int Count = 0;
                for (int i = 1; i <= tem; i++)
                {
                    if (tem % i == 0)
                        Count++;
                }
                int[] fac = new int[Count];
                int Index = 0;
                for (int i = 1; i <= tem; i++)
                {
                    if (tem % i == 0)
                    {
                        fac[Index] = i;
                        Index++;
                    }
                }
                return fac;
            }
            // Finding greatest factor
            public static int GreatestFactor(int[] fac)
            {
                int Maximum = fac[0];

                for (int i = 1; i < fac.Length; i++)
                {
                    if (fac[i] > Maximum)
                        Maximum = fac[i];
                }
                return Maximum;
            }
            // Sum of factors
            public static int Sum(int[] fac)
            {
                int sum = 0;
                for (int i = 0; i < fac.Length; i++)
                {
                    sum += fac[i];
                }
                return sum;
            }
            // Product of factors
            public static long Product(int[] fac)
            {
                long product = 1;

                for (int i = 0; i < fac.Length; i++)
                {
                    product *= fac[i];
                }
                return product;
            }
            // Product of cube of factors
            public static double ProductOfCube(int[] fac)
            {
                double product = 1;

                for (int i = 0; i < fac.Length; i++)
                {
                    product *= Math.Pow(fac[i], 3);
                }

                return product;
            }
            // Perfect Number
            public static bool PerfectNumber(int n, int[] fac)
            {
                int sum = 0;
                for (int i = 0; i < fac.Length; i++)
                {
                    if (fac[i] != n)
                        sum += fac[i];
                }
                return sum == n && n > 0;
            }
            // Abundant Number
            public static bool AbundantNumber(int n, int[] fac)
            {
                int sum = 0;

                for (int i = 0; i < fac.Length; i++)
                {
                    if (fac[i] != n)
                        sum += fac[i];
                }
                return sum > n && n > 0;
            }
            // Deficient Number
            public static bool DeficientNumber(int n, int[] fac)
            {
                int sum = 0;

                for (int i = 0; i < fac.Length; i++)
                {
                    if (fac[i] != n)
                        sum += fac[i];
                }
                return sum < n && n > 0;
            }
        // Strong Number
        public static bool StrongNumber(int n)
        {
            int temp = Math.Abs(n);
            int sum = 0;
            while (temp > 0)
            {
                int digit = temp % 10;
                sum += Factorial(digit);
                temp /= 10;
            }
            return sum == n;
        }
            public static int Factorial(int num)
            {
                int fact = 1;

                for (int i = 1; i <= num; i++)
                {
                    fact *= i;
                }

                return fact;
            }
            // Calling above methods
            public static void Caller()
            {
                Console.Write("Enter number: ");
                int n = Convert.ToInt32(Console.ReadLine());

                int[] fac = Factors(n);
                Console.Write("Factors: ");

                for (int i = 0; i < fac.Length; i++)
                {
                    Console.Write(fac[i] + " ");
                }

                Console.WriteLine();
                Console.WriteLine($"Greatest Factor: {GreatestFactor(fac)}");
                Console.WriteLine($"Sum of Factors: {Sum(fac)}");
                Console.WriteLine($"Product of Factors: {Product(fac)}");
                Console.WriteLine($"Product of Cubes of Factors: {ProductOfCube(fac)}");
                Console.WriteLine($"Perfect Number: {PerfectNumber(n, fac)}");
                Console.WriteLine($"Abundant Number: {AbundantNumber(n, fac)}");
                Console.WriteLine($"Deficient Number: {DeficientNumber(n, fac)}");
                Console.WriteLine($"Strong Number: {StrongNumber(n)}");

            }
        }
    }
