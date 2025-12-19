using System;
public class DiscountedFees2{
	public static void Main(){
		// Taking the Student Fees and University Discount as Input
		Console.WriteLine("Enter The Student Fees");
		Double fee = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter the DiscountedFees");
		Double discountPercent=Convert.ToDouble(Console.ReadLine());
		Double discount=fee/discountPercent;
		Double DiscountedFees= fee-discount;
		// Printing  the desired answers
		Console.WriteLine("The discount amount is INR" + discount +"and final discounted fee is INR"+ DiscountedFees);
		
	}
}