using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //var fullName = "Hannah Hunter ";
            //Console.WriteLine("Trim: '{0}'", fullName.Trim());
            //Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            //var index = fullName.IndexOf(' ');
            //var firstName = fullName.Substring(0, index);
            //var lastName = fullName.Substring(index + 1);
            //Console.WriteLine("First Name: " + firstName);
            //Console.WriteLine("Last Name: " + lastName);

            //var names = fullName.Split(' ');
            //Console.WriteLine("First Name: " + names[0]);
            //Console.WriteLine("Last Name: " + names[1]);

            //Console.WriteLine(fullName.Replace("Hannah", "Hannah Isabel"));

            //if (String.IsNullOrWhiteSpace(" "))
            //    Console.WriteLine("Invalid");

            //var str = "25";
            //var age = Convert.ToByte(str);
            //Console.WriteLine(age);

            //float price = 29.95f;
            //price.ToString("C0");
            //Console.WriteLine(price.ToString("C0"));

            //Summarizing Text
            //var sentence = "Congrats, you have started reading a super duper, really obnoxious, awfully long run-on sentence with absoluetly no end in sight.";
            //var summary = StringUtility.SummarizeText(sentence);
            //Console.WriteLine(summary);

            //StringBuilder
            //var builder = new StringBuilder();
            //builder
            //    .Append('-', 10)
            //    .AppendLine()
            //    .Append("Header")
            //    .AppendLine()
            //    .Append('-', 10)
            //    .Replace('-', '+')
            //    .Remove(0, 10)
            //    .Insert(0, new string('-', 10));

            //Console.WriteLine(builder);

            //Console.WriteLine("First Char: " + builder[0]);

            //Console.WriteLine("Enter a few numbers, separated by hyphen (e.g. 1-2-3-4):");
            //var input = Console.ReadLine();

            //var numbers = new List<int>();
            //foreach (var number in input.Split('-'))
            //    numbers.Add(Convert.ToInt32(number));

            //numbers.Sort();

            //var isConsecutive = true;
            //for (var i = 1; i < numbers.Count; i++)
            //{
            //    if (numbers[i] != numbers[i - 1] + 1)
            //    {
            //        isConsecutive = false;
            //        break;
            //    }
            //}

            //var message = isConsecutive ? "consecutive" : "not consecutive";
            //Console.WriteLine(message);

            Console.WriteLine("Enter a few numbers, separated by hyphen (e.g. 1-2-3-4):");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
                return;

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            var uniques = new List<int>();
            var includesDupes = false;
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
                else
                {
                    includesDupes = true;
                    break;
                }
            }

            if (includesDupes)
                Console.WriteLine("Duplicate!");

        }

    }
}
