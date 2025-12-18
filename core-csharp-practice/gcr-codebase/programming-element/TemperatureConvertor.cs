using System;
class TemperatureConvertor{
	public static void Main(){
	 Console.Write("Enter the temperature in Celsius");
	 decimal cel  = Convert.ToDecimal(Console.ReadLine());
	 decimal fah = ( cel  * (9m/5m)) + 32m;
	 // Giving Fahrenheit as output
      Console.WriteLine(fah);	 
	}
}  