using System;
public class BasicMaths{
	public static void Main(){
		// Taking two numbers as Input from User
     Console.WriteLine("Enter the First Number");
      Double num1= Convert.ToDouble(Console.ReadLine());
       Console.WriteLine("Enter the Second Number");
        Double num2 = Convert.ToDouble(Console.ReadLine());
       // Calculating the quotient and remainder
       Double Quotient = num1/num2;
       Double Remainder= num1%num2;
     // Printing the answer
      Console.WriteLine($"The Quotient is {Quotient} and Remainder is {Remainder}  of two numbers {num1} and {num2} ");	 
	}
}