using System;
using System.Collections.Generic;

namespace excercises_classes
{
    class Cat
    {   
        private int age;
        private double weight;
        private string name;

        public int Age
        {
          get
          {
            return age;
          }
          set
          {
            age = value;
          }  
        }

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public void Meow()
        {
            System.Console.WriteLine("<<< Meow meow >>>");
        }
        public void Bark()
        {
            System.Console.WriteLine("No no");
        }
    

        
            
        
          
    }
       


    
}