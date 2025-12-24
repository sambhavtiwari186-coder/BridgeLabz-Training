using System;
public class Factors{
	public static void Main(){
		// Taking the number as input from the User
		Console.WriteLine("Enter The Number Here :: ");
		 int a = Convert.ToInt32(Console.ReadLine());
		 if(a<0){
			 Console.WriteLine("The Number is Not Natural Number");
		 }
		 // Intalise the Array
		 int [] Factors = new int[(a/2)+1];
		 int index=0;
		 for(int i=1;i<=a;i++){
			 if(a%i==0){
				 Factors[index]=i;
				 index++;
			 }
		 }
		 Console.WriteLine("The Factors Of The Number");
		 for(int i= 0;i<index;i++){
			 Console.WriteLine(Factors[i]);
		 }
	}
}