using System;
using System.Collections.Generic;

namespace excercises_classes
{
    class Program
    {
    
        static void Main(string[] args)
        {
            Cat myCat = new Cat();
            myCat.Age = 3;
            myCat.Weight = 2.55;
            myCat.Name = "Pelle";

            System.Console.WriteLine("Katten är {0} år gammal, väger {1}kg och heter {2}",myCat.Age,myCat.Weight,myCat.Name);
            System.Console.WriteLine("Tryck på valfri tangent för att lyssna på katten...");
            Console.ReadKey();
            myCat.Meow();
            System.Console.WriteLine("Tryck på valfri tangent för att höra katten skälla...");
            Console.ReadKey();
            myCat.Bark();
            

        }
    }
}

   
