using System;
class TemperatureChecker2{
	public static void Main(){
	 Console.Write("Enter the temperature in Fahrenheit");
	 Double fah  = Convert.ToDouble(Console.ReadLine());
	 Double cel = ((fah) - 32.0) * 5.0/9.0;
	 // Giving Celsius as output
      Console.WriteLine($"Given temperature in Celsius is {cel}");	 
	}
}  