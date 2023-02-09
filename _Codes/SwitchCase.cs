using System;  
public class SwitchCase{  
    public static void Main(string[] args){  
        Console.WriteLine("Enter a number:");  
        int n = Convert.ToInt32(Console.ReadLine());  

        switch (n){  
            case 1: 
                Console.WriteLine("Entered number is 1"); 
                break;  
            case 2: 
                Console.WriteLine("Entered number is 2"); 
                break;  
            case 3: 
                Console.WriteLine("Entered number is 3"); 
                break;  
            default: 
                Console.WriteLine("Entered number is not 1, 2 or 3"); 
                break;  
        }  
    }  
}