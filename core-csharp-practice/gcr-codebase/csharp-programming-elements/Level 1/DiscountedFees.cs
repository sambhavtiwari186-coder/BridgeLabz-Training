using System;
public class DiscountedFees{
	public static void Main(){
		// Creating the desired variables
		int fees= 12500;
		int discountPercent=10;
		int discount=fees/discountPercent;
		int DiscountedFees= fees-discount;
		// Printing  the desired answers
		Console.WriteLine("The discount amount is INR" + discount +"and final discounted fee is INR"+ DiscountedFees);
		
	}
}