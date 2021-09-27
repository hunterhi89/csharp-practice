using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    
    public class Animal
    {
        public bool HasCells { get; private set; } = true;
    }
    
    public class Mammal : Animal
    {
        private int _numberOfEars = 2;
        public int NumberOfEars
        {
            get
            {
                return _numberOfEars;
            }
            set
            {
                if (value >= 0 && value <= 2)
                {
                    _numberOfEars = value;
                }
                else
                {
                    Console.WriteLine("Invalid number of ears.");
                }


            }
        }

    }
    public class Dog : Mammal
    {
        public Dog(string name = "hambone")
        {
            Name = name;
            Console.WriteLine("I am creating a dog for you named " + name);
        }



        public int NumberOfEyes { get; } = 2;



        public int NumberOfLegs = 4;
        public void LegCheck() 
        {
            Console.WriteLine("This dog has " + NumberOfLegs + " legs.");
        }
        public string Name = null;
        public void NameCheck() 
        {
            if (Name != null)
            {
                Console.WriteLine("The dog's name is " + Name);
            }
            else
            {
                Console.WriteLine("Please name this dog");
            }
            
            
        }

    }
}
