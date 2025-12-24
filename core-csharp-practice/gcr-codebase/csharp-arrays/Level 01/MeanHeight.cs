using System;
public class MeanHeight{
	public static void Main(){
		// Intalise the PlayerHeight Array
		double [] PlayerHeight = new double[11];
		double sum=0;
		// Adding the height of Players in team through user and also adding the heights
		Console.WriteLine("Enter The Height Of The Players");
		for(int i=0;i<PlayerHeight.Length;i++){
			PlayerHeight[i]= Convert.ToDouble(Console.ReadLine());
			sum+=PlayerHeight[i];
		}
     // Calculating the Mean Height of The Team
	   double Mean = (sum/11.0);
	   Console.WriteLine("The Mean Height of the team is " + Mean);
	}
}