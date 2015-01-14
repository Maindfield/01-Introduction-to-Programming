using System;

namespace Ageafter10Years

          //Problem 15.* Age after 10 Years
          //Write a program to read your birthday from the console and print
          //how old you are now and how old you will be after 10 years.
{
    class Ageafter10Years
    {
        static void Main()
        {
            Console.WriteLine("Enter your current age:");
            int CurrentAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age after ten years: {0}", CurrentAge + 10);
        }
    }
}
