using System;  
class FunctionCallByValue {  
    public void demo(int val)  {  
        val += 100;
        Console.WriteLine("Value : "+val);  
        
    }  
    public static void Main(string[] args)  {  
        int val = 100;  
        FunctionCallByValue obj = new FunctionCallByValue(); 
        Console.WriteLine("Value before calling the function "+val);  
        obj.demo(val);          
        Console.WriteLine("Value after calling the function " + val);  
    }  
}  
