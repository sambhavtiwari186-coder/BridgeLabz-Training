using System;
public class HandShakes{
	public static void Main(){
		// Taking no of Students as Input
		Console.WriteLine("Enter no of Students");
    int Students = Convert.ToInt32(Console.ReadLine());
      // Calaculating The no of HandShakes	
	  int NoofHandShakes= (Students*(Students-1))/2;
	  // Printing NoofHandShakes as Output
	  Console.WriteLine("No of HandShakes are " + NoofHandShakes);
	  
	}
}