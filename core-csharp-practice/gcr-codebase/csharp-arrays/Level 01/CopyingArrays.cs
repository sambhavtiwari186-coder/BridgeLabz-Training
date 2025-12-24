using System;
public class CopyingArrays{
    public static void Main(){
        //  Take input for rows and columns
        Console.WriteLine("Enter number of rows:");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number of columns:");
        int columns = Convert.ToInt32(Console.ReadLine());
        //  Create 2D array
        int[,] matrix = new int[rows, columns];
      // Step 3: Take input for 2D array
        Console.WriteLine("Enter the elements of the matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        // Step 4: Create 1D array
        int[] arr = new int[rows * columns];
        int index = 0;
      // Copy 2D array into 1D array
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                arr[index] = matrix[i, j];
                index++;
            }
        }
       //  Printing 1D array
        Console.WriteLine("1D Array elements:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
