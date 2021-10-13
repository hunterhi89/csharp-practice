using System;
using System.Collections.Generic;

namespace Text_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Hannah Hunter ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("First Name: " + names[0]);
            Console.WriteLine("Last Name: " + names[1]);

            Console.WriteLine(fullName.Replace("Hannah", "Hannah Isabel"));

            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            price.ToString("C0");
            Console.WriteLine(price.ToString("C0"));

            //Summarizing Text
            var sentence = "Congrats, you have started reading a super duper, really obnoxious, awfully long run-on sentence with absoluetly no end in sight.";
            var summary = StringUtility.SummarizeText(sentence);
            Console.WriteLine(summary);

        }

    }
}
