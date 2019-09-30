using System;

namespace excercises_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cat myCat = new Cat();

            myCat.name = "Olle";
            myCat.race = "Sibirisk";
            myCat.age = 12;

            myCat.Fetch();
            myCat.Bark();

            System.Console.WriteLine("Katten heter {0}, är en {1} ras och är {2} gammal", myCat.name, myCat.race, myCat.age);

        }
    }
}

   
