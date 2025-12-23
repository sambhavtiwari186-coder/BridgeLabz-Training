using System;
public class EmployeeBonus{
    public static void Main(){
		// Take employee salary and years of service as input from user
        Console.WriteLine("Enter employee salary:");
        double salary = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter years of service:");
        int yearsOfService = Convert.ToInt32(Console.ReadLine());
		 double bonus = 0;
       // Check bonus eligibility
        if (yearsOfService > 5){
            bonus = salary * 0.05;
            Console.WriteLine("Bonus Amount: " + bonus);
        }
        else{
            Console.WriteLine("No bonus. Service period is less than or equal to 5 years.");
        }
    }
}
