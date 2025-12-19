using System;
public class SamMarks{
	public static void Main(){
		// Writing the marks of All three subjects of Sam
		int MarksInMaths=94;
		int MarksInPhysics=95;
		int MarksInChemistry=96;
		// Finding Average Marks in PCM
		int Average =(MarksInChemistry+MarksInMaths+MarksInPhysics)/3;
		// Print Average Marks of Sam
		Console.WriteLine("Average Marks Of Sam in PCM is " + Average);
	}
}