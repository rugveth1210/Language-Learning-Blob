using System;  
namespace AccessSpecifiers{  
    class Params{  

        public void display(params int[] val){  
            for (int i=0; i<val.Length; i++){  
                Console.WriteLine(val[i]);  
            }  
        }  
          
        public static void Main(string[] args){  
            Params param = new Params(); 
            param.display(1,5,7,82,16);
        }  
    }  
}  