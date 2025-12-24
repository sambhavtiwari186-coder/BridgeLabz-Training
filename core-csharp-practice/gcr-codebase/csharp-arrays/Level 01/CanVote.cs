using System;
public class CanVote{
	public static void Main(){
		// Intalising an Array
		int [] arr = new int[10];
		// Taking Age as Input From the User
		Console.WriteLine("Enter The Age of The Students :: ");
		for(int i=0;i<arr.Length;i++){
			arr[i]=Convert.ToInt32(Console.ReadLine());
		}
		// Checking the age and tell if the Person is eligible or not
		for(int i=0;i<arr.Length;i++){
			if(arr[i]<0){
				Console.WriteLine("Invalid Age of the student");
			}else if (arr[i]<18){
				Console.WriteLine("The student with the age " + arr[i] + " cannot vote" );
			}else{
				Console.WriteLine("The student with the age " + arr[i] + " can vote");
			}
		}
	}
}