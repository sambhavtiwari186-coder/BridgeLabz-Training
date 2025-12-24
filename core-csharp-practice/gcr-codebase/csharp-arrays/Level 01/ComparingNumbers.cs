using System;
public class ComparingNumbers{
	public static void Main(){
		int [] arr = new int[5];
		Console.WriteLine("Enter The Numbers Here :: ")
		for(int i=0;i<arr.Length;i++){
			arr[i]=Convert.ToInt32(Console.ReadLine());
		}
		for(int i=0;i<arr.Length;i++){
			if(arr[i]<0){
				Console.WriteLine("The Number "+ arr[i]+ " is Negative Number");
			}else if(arr[i]>0){
				if(arr[i]%2==0){
					Console.WriteLine("The number "+ arr[i]+ " is positive even Number");
				}else{
					Console.WriteLine("The number "+ arr[i]+ " is positive odd Number");
				}
			}
		}
		if(arr[0]==arr[arr.Length-1]){
			Console.WriteLine("The first and the last numbers of array are equal");
		}else if(arr[0]>arr[arr.Length -1]){
			Console.WriteLine("The first number is greater than last number");
		}else{
			Console.WriteLine("The first number is lesser than last number");
		}
	}
}