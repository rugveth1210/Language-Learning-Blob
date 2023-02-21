using System;
public class JaggedArray{  
    public static void Main(){

        int[][] arr = new int[2][]; 
  
        arr[0] = new int[] { 8, 10, 13 };       
        arr[1] = new int[] { 4, 60};  
  
        for (int i = 0; i < arr.Length; i++){  

            for (int j = 0; j < arr[i].Length; j++){

                Console.Write(arr[i][j]+" ");  
            }  

            Console.WriteLine();  
        }  
    }  
}