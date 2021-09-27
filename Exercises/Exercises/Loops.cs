using System;

namespace Exercises
{
    public class Loops
    {
        static void Main(string[] args)
        {
            //var count = 0;
            //for (var i = 1; i <= 100;  i++)
            //{
            //    if (i % 3 == 0)
            //        count++;
            //}
            //Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100.", count);

            //var sum = 0;
            //while (true)
            //{
            //    Console.WriteLine("Enter a number or 'ok' to exit.");
            //    var input = Console.ReadLine();
            //
            //    if (input.ToLower() == "ok")
            //        break;
            //
            //    sum += Convert.ToInt32(input);
            //}
            //Console.WriteLine("Sum of all numbers is " + sum);

            //Console.WriteLine("Enter a number.");
            //var number = Convert.ToInt32(Console.ReadLine());
            //
            //var factorial = 1;
            //for (var i = 1; i <= number; i++)
            //    factorial *= i;
            //
            //Console.WriteLine("{0}! = {1}", number, factorial);

            //var number = new Random().Next(1, 10);
            //
            //Console.WriteLine("Secret number is " + number);
            //for (var i = 0; i <= 4; i++)
            //{
            //    Console.WriteLine("Guess a number between 1 and 10.");
            //    var guess = Convert.ToInt32(Console.ReadLine());
            //
            //    if (guess == number)
            //    {
            //        Console.WriteLine("You won!");
            //        return;
            //    }
            //
            //    Console.WriteLine("You lost!");
            //}

            Console.WriteLine("Enter a series of numbers separated by comma.");
            var input = Console.ReadLine();

            var numbers = input.Split(',');

            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }

            Console.WriteLine("Max is " + max);



        }
    }
}
