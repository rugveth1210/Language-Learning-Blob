using System;  
class ArrayClass{  

    public void display(int[] myArray){  
        Array.Sort(myArray);
        foreach (int value in myArray){
            Console.WriteLine(value);
        }  
    }  
        
    public static void Main(string[] args){ 

        int[] myArray = new int[] { 12, 16, 22,18,19}; 
        ArrayClass ac = new ArrayClass(); 
        ac.display(myArray);
    }  
}  
