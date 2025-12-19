using System;
class Operators{
	
	class Animal{
		
	};
	
	class Dog : Animal{
	};
	
	class Plane{
		
	};
	
	static void Main(){
		
		// 1 Arithematic Operators
		int num1 = 97;
		int num2 = 91;
		
		// 1.1 Addition
		Console.WriteLine(num1 + num2);
		
		// 1.2 Subtraction
		Console.WriteLine(num1 - num2);
		
		// 1.3 Multiplication
		Console.WriteLine(num1 * num2);
		
		// 1.4 Division
		Console.WriteLine(num1 / num2);
		
		// 1.5 Modulus
		Console.WriteLine(num1% num2);
		
		Console.WriteLine("---------------------------------------");
		
		
		// 2 Realtional Operators
		
		// 2.1 Equal to
		Console.WriteLine(num1 == num2);
		
		// 2.2 Not equal to 
		Console.WriteLine(num1 != num2);
		
		// 2.3 Greater than 
		Console.WriteLine(num1> num2);
		
		// 2.4 Less than
		Console.WriteLine(num1 < num2);
		
		// 2.5 Greater than or equal to 
		Console.WriteLine(num1 >= num2);
		
		// 2.6 Less than or equal to 
		Console.WriteLine(num1 <= num2);
		
		Console.WriteLine("---------------------------------------");
		
		
		// 3 Logical Operators
		
		// Logical AND
		Console.WriteLine(num1<num2 && num1>num2);
		
		// Logical OR
		Console.WriteLine(num1<num2 || num1>num2);
		
		// Logical NOT
		Console.WriteLine(!(num1== num2));
		
		Console.WriteLine("---------------------------------------");
		
		
		// 4 Assignment Operators
		
		// 4.1 Assignment
		int a = 4;
		
		// 4.2 Addtion Assignment
		num1 += 4;
		
		// 4.3 Subtraction Assignment
		num2-= 3;
		
		// 4.4 Multiplication Assignment
		num1 *= 2;
		
		// 4.5 Division Assignment
		num2/= 10;
		
		// 4.6 Modulus Assignment
		num2%= 2;
		
		Console.WriteLine("---------------------------------------");
		
		
		// 5 Unary Operators
		
		// 5.1 Unary plus
		int z = +num1;
		
		// 5.2 Unary minus
		int f = -num1;
		
		// 5.3 Increment 
		a++;
		
		// 5.4 Decrement
		a--;
		
		// 5.5 Logical Complement
		Console.WriteLine(!true);
		
		Console.WriteLine("---------------------------------------");
		
		
		// 6 Bitwise Operators
		
		// 7 Ternary operator
		int max = (num1 > num2) ? num1 : num2;
		Console.WriteLine(max);
		
		Console.WriteLine("---------------------------------------");
		
		
		// 8 is Operator
		Animal animal = new Dog();
		Plane plane = new Plane();
		Console.WriteLine(animal is Animal);
		Console.WriteLine(animal is Dog);
		Console.WriteLine(animal is Plane);
	}
}