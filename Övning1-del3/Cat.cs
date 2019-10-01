using System;
using System.Collections.Generic;

namespace excercises_classes
{
    class Cat
    {   
        private int age;
        private double weight;
        private string name;

        public Cat(int age, double weight, string name)
        {
            this.age = age;
            this.weight = weight;
            this.name = name;
        }
        public void Meow()
        {   
            System.Console.WriteLine("Katten är {0} år gammal, väger {1}kg och heter {2}",age,weight,name);
            System.Console.WriteLine("<<< Meow meow >>>");
        }
        public void Bark()
        {
            System.Console.WriteLine("No no");
        }
    

        
            
        
          
    }
       


    
}