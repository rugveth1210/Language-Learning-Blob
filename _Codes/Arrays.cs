using System;  
public class Arrays  {  
    public static void Main()  { 

        int[] arr = new int[10]; 
        
        Console.Write("Read and Print elements of an array:\n");
    
        Console.Write("Input 10 elements in the array :\n");  

        for(int i=0; i<10; i++)  
        {  
            arr[i] = Convert.ToInt32(Console.ReadLine());  		
        }  
    
        Console.Write("\nElements in array are: ");  
        
        for(int i=0; i<10; i++)  
        {  
            Console.Write(arr[i]);  
        } 
    }
}