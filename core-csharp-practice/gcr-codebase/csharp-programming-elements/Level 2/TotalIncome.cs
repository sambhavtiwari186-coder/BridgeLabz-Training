using System;
public class TotalIncome{
	public static void Main(){
		// Take Employ Salary and Bonus as Input from user
		Console.WriteLine("Enter the Salary of Employees");
		Double Salary = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter The Bonus of Employees");
		Double Bonus = Convert.ToDouble(Console.ReadLine());
		// Calculating Total Salary of Employees
		Double TotalIncome = Salary+Bonus;
		// Printing the Total Salary
		Console.WriteLine($" The Total Income of the Employee is {TotalIncome}");
	}
}