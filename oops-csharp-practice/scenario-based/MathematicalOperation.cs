using System;
using System.Collections.Generic;
using System.Text; 

namespace BridgeLabzTraining.scenario_based
{
    /// <summary>
    /// MathematicalOperation is a menu-driven class that allows users to perform
    /// basic mathematical operations such as:
    /// 1. Factorial calculation
    /// 2. Prime number checking
    /// 3. Fibonacci series generation
    /// 4. Greatest Common Divisor (GCD) calculation
    /// 
    /// The class uses switch-case, loops, and separate methods for each operation
    /// to demonstrate modular and scenario-based programming in C#.
    /// </summary>
    internal class MathematicalOperation
    {
        public void Run()
        {
            Console.WriteLine(" Welcome to Maths is Fun");
       // Writing The Menu based Program 
            bool loop = true;
            while (loop) {
                Console.WriteLine("Enter The Number To Tell Us which operation you want to Perform");
                Console.WriteLine();
                Console.WriteLine("Press 1 to Calculate The Factoraial");
                Console.WriteLine("Press 2 to Check  if the Number is Prime of Not ");

                Console.WriteLine("Press 3 to Print The Fibonacci Series");
                Console.WriteLine("Press 4 to Print The GCD of Two Number");
                Console.WriteLine();

                Console.WriteLine(" Enter Your Choice ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter A Number");
                int num= Convert.ToInt32(Console.ReadLine());
            // Using Switch Case
                switch (a)
                {
                    case 1:
                        Factorial(num);
                        break;
                        case 2:
                        PrimeChecker(num); 
                        break;
                        case 3:
                        FibnoacciSeries(num);
                        break;
                        case 4:
                        GCD(num); 
                        break;
                    default:
                        loop= false;
                        Console.WriteLine("Sorry Please Input Valid Input to perform Operations");
                        break;
                }
            }
            Console.WriteLine(" Enter Your Number Here");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

        }
        //  Method To calculate the factorial
        public void Factorial(int num)
        {
            int fact = 1;
            if (num == 0) Console.WriteLine (0);
            if (num == 1) Console.WriteLine (1);
            while (num > 0)
            {
                fact *= num;
                num--;
            }
            Console.WriteLine ("The Factorial Of the Given Number is " + fact) ;
        }
        // Method To Check Number is Prime or Not
        public void PrimeChecker(int num)
        {
            int count = 0;
            for (int i = 1; i < num; i++)
            {
                if ((num % i) == 0)
                {
                    count++;
                }
            }
            if (count >= 2)
            {
                Console.WriteLine("Number is Not a Prime Number");
            }
            else
            {
                Console.WriteLine("Number is Prime Number");
            }
        }
        // Method To Print the fibnoacci Series 
        public void FibnoacciSeries(int num)
        {
            Console.WriteLine("The FibnoacciSeries is : ");
            int a = 0; 
            int b = 1;
            for(int i = 1; i <= num; i++)
            {
                Console.Write(a + " ,");

                int next = a + b;
                a = b;
                b= next;
            }
            Console.WriteLine();
        }
        // Method To Calculate The Greatest Commom Divisor
        public void GCD(int num) {
            Console.WriteLine("Enter the Second Number");
            int num1= Convert.ToInt32(Console.ReadLine());
            while (num1 != 0)
            {
                int rem = num % num1;
                num = num1;
                num1 = rem;
            }
            Console.WriteLine("The GCD of Two Number is " + num);
        }
    }
}
