using System;  
public class BreakStatement{  
    public static void Main(string[] args){

        for (int i = 0; i < 10; i++){

            if (i == 7){

                break;  
            }  

            Console.WriteLine("This is" +i);  
        }  
    }  
}  