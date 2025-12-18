using System;
  public class VolumeOfCylinder{
	  public static void Main(){
		  Console.WriteLine("Enter the radius of Cylinder");
		  Double radius= Convert.ToDouble(Console.ReadLine());
		  Console.WriteLine("Enter the height of the Cylinder");
		  Double height= Convert.ToDouble(Console.ReadLine());
		  Double volume= (22/7) * radius * radius * height;
		  // Print the volume of the Cylinder
		  Console.WriteLine("VOlume of Cylinder"+ volume);
	  }
  }