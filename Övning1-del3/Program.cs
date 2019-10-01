using System;
using System.Collections.Generic;

namespace excercises_classes
{
    class Program
    {
    
        static void Main(string[] args)
        {
            Cat myCat = new Cat(6,4.5,"Ivar");
            Cat myOtherCat = new Cat(3,2.3,"Pelle");
         
            myCat.Meow();
            System.Console.WriteLine("Tryck på valfri tangent för att höra katten skälla...");
            Console.ReadKey();
            myCat.Bark();

            myOtherCat.Meow();
            

        }
    }
}
