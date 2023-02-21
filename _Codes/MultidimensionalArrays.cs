
using System;  
class MultidimensionalArrays {
    public static void Main()  {

        int[,] myArray = new int[3, 4];

        for (int i = 0; i < myArray.GetLength(0); i++)
        {
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                Console.Write($"Enter a number for row {i + 1}, column {j + 1}: ");
                
                int userInput = int.Parse(Console.ReadLine());
                
                myArray[i, j] = userInput;
            }
        }

    }

}
