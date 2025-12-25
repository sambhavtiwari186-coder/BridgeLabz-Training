using System;

namespace NumberChecker
{
    internal class NumberChecker
    {
        static void Checker()
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            //  Count digits
            int digitCount = CountDigits(number);
            Console.WriteLine("Count of digits: " + digitCount);
            //  Store digits in array
            int[] digits = StoreDigits(number, digitCount);

            Console.WriteLine("Digits of the number:");
            foreach (int d in digits)
            {
                Console.Write(d + " ");
            }
            Console.WriteLine();
            //  Duck number check
            Console.WriteLine("Is Duck Number: " + IsDuckNumber(digits));
            //  Armstrong number check
            Console.WriteLine("Is Armstrong Number: " + IsArmstrongNumber(number, digits));
            // Largest & Second Largest
            FindLargestAndSecondLargest(digits);
            //  Smallest & Second Smallest
            FindSmallestAndSecondSmallest(digits);
        }
        // Method to count digits
        static int CountDigits(int num)
        {
            int count = 0;
            while (num != 0)
            {
                count++;
                num /= 10;
            }
            return count;
        }
        // b. Method to store digits in array
        static int[] StoreDigits(int num, int count)
        {
            int[] digits = new int[count];
            for (int i = count - 1; i >= 0; i--)
            {
                digits[i] = num % 10;
                num /= 10;
            }
            return digits;
        }
        //Duck number check
        static bool IsDuckNumber(int[] digits)
        {
            foreach (int d in digits)
            {
                if (d != 0)
                    return true;
            }
            return false;
        }
        //  Armstrong number check
        static bool IsArmstrongNumber(int number, int[] digits)
        {
            int sum = 0;
            int power = digits.Length;
            foreach (int d in digits)
            {
                sum += (int)Math.Pow(d, power);
            }
            return sum == number;
        }
        //  Largest & Second Largest
        static void FindLargestAndSecondLargest(int[] digits)
        {
            int largest = Int32.MinValue;
            int secondLargest = Int32.MinValue;
            foreach (int d in digits)
            {
                if (d > largest)
                {
                    secondLargest = largest;
                    largest = d;
                }
                else if (d > secondLargest && d != largest)
                {
                    secondLargest = d;
                }
            }
            Console.WriteLine("Largest Digit: " + largest);
            Console.WriteLine("Second Largest Digit: " + secondLargest);
        }
        //  Smallest & Second Smallest
        static void FindSmallestAndSecondSmallest(int[] digits)
        {
            int smallest = Int32.MaxValue;
            int secondSmallest = Int32.MaxValue;

            foreach (int d in digits)
            {
                if (d < smallest)
                {
                    secondSmallest = smallest;
                    smallest = d;
                }
                else if (d < secondSmallest && d != smallest)
                {
                    secondSmallest = d;
                }
            }
            Console.WriteLine("Smallest Digit: " + smallest);
            Console.WriteLine("Second Smallest Digit: " + secondSmallest);
        }
    }
}
