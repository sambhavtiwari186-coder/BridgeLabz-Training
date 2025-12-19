using System;

public class DataTypes {
    static void Main() {
        //  int datatype
		int a= 10;
		Console.WriteLine("Given Integer is" + a);
		// float datatype
		float b= 15.0f;
		Console.WriteLine("Given float is " + b);
		// Long datatype
		long c= 100L;
		Console.WriteLine("Given long is" + c);
		// Double DataType
		Double d = 45.0d;
		Console.WriteLine("Given double is "+ d);
		// char datatype
		char e = 'f';
		Console.WriteLine("Given char is "+ e);
		// Boolean datatype
		bool f = true;
		Console.WriteLine("Given ans is " + f);
		// Type Casting (Implicit)
		// Converting character into Integer
		char spell= 'S';
		int num = spell;
		Console.WriteLine("The answer after conversion is "+ num);
		// Converting Integer into float
		int num1= 54;
		float f1=num1;
		Console.WriteLine("The answer after conversion is" + f1);
		// Converting float into long 
		float f2=23.9f;
		double num2= f2;
		Console.WriteLine("The answer after conversion is" + num2);
		// Converting char into double
		char ch= 'P';
		double num3= ch;
		Console.WriteLine("The answer after conversion is"+ num3);
		// Explicit Conversion
	     Double d1= 99.3456d;
		// Convert double into int
		 int i1= Convert.ToInt32(d1);
		 Console.WriteLine("The answer after converting double into integer is  "+ i1);
		 
		
		
		
		
    }
}