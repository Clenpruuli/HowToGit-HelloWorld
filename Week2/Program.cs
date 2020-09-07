using System;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Create an app
           * 1. app asks the user`s name and greets the user´s by it´s name;
           * 2. app asks the user´s age and calculates what year the user was born
           * 3. app displays the result to the user
           */

            Console.WriteLine("good morning");
            Console.WriteLine("what is your name");
            string Name;
            Name = Console.ReadLine();
            Console.WriteLine("Hello, " + Name);
            Console.WriteLine("what is your year of birth?");
            string Userinput;
            Userinput = Console.ReadLine();
            int YearOfBirth;
            //parsing string to interger (number)
            YearOfBirth = Int32.Parse(Userinput);
            int age = 2020 - YearOfBirth;
            Console.WriteLine("You are " + age + "old");
            









        }
    }
}
