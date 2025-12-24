using System;
public class UntilZero{
	public static void Main(){
		// Intalize an array 
		int [] arr = new int[10];
		bool a =true;
		int i=0;
		int sum=0;
		while(a){
			if(i==10){
				break;
			}
			arr[i]=Convert.ToInt32(Console.ReadLine());
			if((arr[i]==0) || (arr[i]<0) ){
				break;
			}
			i++;
		}
		for(int j = 0;j<i;j++){
			sum+=arr[j];
		}
		Console.WriteLine("The Sum of Numbers Entered till User Entered Zero Or Negative Number is "+ sum);
	}
}