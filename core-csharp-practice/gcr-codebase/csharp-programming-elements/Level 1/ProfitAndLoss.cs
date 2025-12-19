using System;
public class ProfitAndLoss{
	public static void Main(){
		// Writing CP and SP
		int CostPrice = 129;
		int Sellingprice= 191;
		// Calculating The Profit
		int Profit = Sellingprice-CostPrice;
		// Calculating The Profit Percentage
		float ProfitPercentage = ((float)Profit/CostPrice) * 100 ;
		// Printing the Answer
		Console.WriteLine("The Cost Price in INR " + CostPrice + "and Sellingprice in INR" + Sellingprice + "The Profit in INR"+ Profit+"and the Profit Percentage is"+ ProfitPercentage);
		
	}
}