using System;
public class HeightConvertor{
	public static void Main(){
		// Taking height as input in Centimeter
		Console.WriteLine("Enter the Height in Centimeter");
		Double Height = Convert.ToDouble(Console.ReadLine());
		// Converting Height in Centimeter into foot and inches
		Double HeightInInches = Height/2.54d;
		Double HeightInFoot = HeightInInches/12;
		Console.WriteLine("Your Height in cm is" + Height+ "while in feet is" + HeightInFoot+" and inches is"+ HeightInInches);
	}
}
