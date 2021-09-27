using System;

namespace HelloWorld
{

    public class Person
    {
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i <= 100; i++)
                if (i/3 == 0)
            {
                    Console.WriteLine(i);
            }



            Dog myDog = new Dog("baloo");
            myDog.NumberOfEars = 1;
            int x = myDog.NumberOfEars;
            Cat myCat = new Cat();
            
            // myDog.NumberOfEyes = 3;

            Dog myOtherDog = new Dog();


        }

    }
}
