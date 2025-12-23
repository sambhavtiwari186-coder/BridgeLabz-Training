using System;
public class UntilZero2{
    public static void Main(){
        double sum = 0;
        double a;
       while (true)
        {
            Console.WriteLine("Enter a number (0 to stop):");
            a = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                break; 
            }

            sum += a;
        }
		Console.WriteLine("The Sum of numbers until user put zero is  :: " + sum);
    }
}
