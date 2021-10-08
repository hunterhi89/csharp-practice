using System;
using System.Collections.Generic;

namespace Exercises
{
    public class Lists
    {
        static void Main(string[] args)
        {
            //var numbers = new List<int>() { 1, 2, 3, 4 };
            //numbers.Add(1);
            //numbers.AddRange(new int[3] { 5, 6, 7 });
            //foreach (var number in numbers)
            //    Console.WriteLine(number);

            //Console.WriteLine();
            //Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            //Console.WriteLine("Last index of 1: " + numbers.LastIndexOf(1));


            //Console.WriteLine("Count: " + numbers.Count);

            //for (var i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] == 1)
            //        numbers.Remove(numbers[i]);
            //}

            //foreach (var number in numbers)
            //    Console.WriteLine(number);

            //numbers.Clear();
            //Console.WriteLine("Count: " + numbers.Count);


            //var names = new List<string>();

            //while (true)
            //{
            //    Console.WriteLine("Type a name, or hit 'Enter' to quit: ");

            //    var input = Console.ReadLine();
            //    if (String.IsNullOrWhiteSpace(input))
            //        break;
            //    names.Add(input);

            //}

            //if (names.Count > 2)
            //    Console.WriteLine("{0}, {1}, and {2} others like your post.", names[0], names[1], names.Count - 2);
            //else if (names.Count == 2)
            //    Console.WriteLine("{0} and {1} like your post.", names[0], names[1]);
            //else if (names.Count == 1)
            //    Console.WriteLine("{0} likes your post.", names[0]);
            //else
            //    Console.WriteLine();


            //Console.WriteLine("Type your name: ");

            //var name = Console.ReadLine();

            //var array = new char[name.Length];
            //for (var i = name.Length; i > 0; i--)
            //    array[name.Length - i] = name[i - 1];

            //var reversed = new string(array);
            //Console.WriteLine("Reversed name: " + reversed);


            var numbers = new List<int>();

            while (numbers.Count < 5)
            {
                Console.WriteLine("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("You've already entered " + number);
                    continue;
                }

                numbers.Add(number);
            }


        }
    }
}
