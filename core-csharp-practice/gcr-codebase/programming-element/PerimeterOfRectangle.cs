using System;
public class PerimeterOfRectangle{
	public static void Main(){
		Console.WriteLine("Enter the Length Of Rectangle");
		Double Length=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter the Breadth of Rectangle");
		Double Breadth=Convert.ToDouble(Console.ReadLine());
		Double Perimeter=2.00*(Length+Breadth);
		// Print the Perimeter
		Console.WriteLine("Perimeter of Rectangle is"+ Perimeter);
	}
}