using System;
class MissingNumber{
    static void Main(){
        Console.WriteLine("Enter the number here");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n - 1];
        Console.WriteLine("Enter " + (n - 1) + " elements:");
        for (int i = 0; i < arr.Length; i++){
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }  
        int Sum = n * (n + 1) / 2;
        int Sum1 = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            Sum1 += arr[i];
        }
        int missingNumber = Sum - Sum1;
        Console.WriteLine("Missing number is: " + missingNumber);
    }
}
