using System;
public class PenDistribution{
	public static void Main(){
		// Write No.ofPens and No.ofStudnets
		int NoOfPens=14;
		int NoOfStudents=3;
		// Calculating no of pens given to each student and pens remaining
		int PensGivenToEachStudent= (NoOfPens/NoOfStudents);
		int RemainingPens =(NoOfPens%NoOfStudents);
		Console.WriteLine("The Pen Per Student is" + PensGivenToEachStudent + "and the remaining pen not distributed is "+ RemainingPens);
	}
}