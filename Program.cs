using System;
using System.Collections.Generic;

namespace excercises_classes
{
    class Program
    {
    
        static void Main(string[] args)
        {
            Cat myCat = new Cat();
            myCat.age = 3;
            myCat.weight = 2.55;
            myCat.name = "Tjorven";

            System.Console.WriteLine("Katten är {0} år gammal, väger {1}kg och heter {2}",myCat.age,myCat.weight,myCat.name);
            System.Console.WriteLine("Tryck på valfri tangent för att lyssna på katten...");
            Console.ReadKey();
            myCat.Meow();
            

        }
    }
}

   
