using System;
public class OddEven{
	public static void Main(){
		// Taking The Number As Input From the User
		Console.WriteLine(" Enter The Number Here ");
		int a = Convert.ToInt32(Console.ReadLine());
		if(a<0){
			Console.WriteLine("The Entered Number is Not Natural Number ");
			return;
		}
		// Intalising the  Two Arrays
		int [] OddNumber = new int[a];
		int [] EvenNumber = new int[a];
		int Odd=0; 
		int Even=0;
		for(int i =1;i<=a;i++){
			if((i%2)==0){
				EvenNumber[Even]=i;
				Even++;
			}else{
				OddNumber[Odd]= i;
				Odd++;
			}
		}
		// Printing the Odd Number
		Console.WriteLine("The Odd Numbers Are :: ");
		for(int i=0;i<((a/2)+1);i++){
			Console.WriteLine(OddNumber[i]);
		}
		// Printing Even Numbers
		Console.WriteLine("The Even Numbers Are :: ");
		for(int i=0;i<((a/2)+1);i++){
			 Console.WriteLine(EvenNumber[i]);
		}
		
	}
}