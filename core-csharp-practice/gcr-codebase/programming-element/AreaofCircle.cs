using System;
public class AreaofCircle{
	public static void Main(){
		Console.Write("Enter the Radius of Circle");
		decimal radius= Convert.ToDecimal(Console.ReadLine());
		decimal area= 3.14m * radius*radius;
		// Print the area of the Circle
		Console.WriteLine("Area of the Circle"+ area);
	}
}