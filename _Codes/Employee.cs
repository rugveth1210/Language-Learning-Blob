using System;  
public class Employee{  
    public int id;   
    public String name;  
    public int salary;  
    public Employee(int i, String n,int s){  
        id = i;  
        name = n;  
        salary = s;  
    }  
    public void display(){  
        Console.WriteLine(id + " " + name+" "+salary);  
    }  

    public static void Main(string[] args){  
        Employee e1 = new Employee(1, "Rugveth", 1000000);  
        Employee e2 = new Employee(2, "Rahul", 1200000);  
        e1.display();  
        e2.display();  
    }
}  
