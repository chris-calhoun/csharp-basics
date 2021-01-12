using System;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Chris";
            char firstLetter = 'N';

            int number = Int32.MaxValue;
            long bigNumber = Int64.MaxValue;
            long littleNumber = Int16.MaxValue;
            Console.WriteLine(number);
            Console.WriteLine(bigNumber);
            Console.WriteLine(littleNumber);

            DateTime today = DateTime.Today;
            Console.WriteLine(today);

            // instantiation
            var bestYear = new DateTime(2020, 1, 1);

            // anonymous type, new object
            var person = new {Name = "Nathan"};

            // everything is or can be an object
            object weirdStuff = 1243;
            weirdStuff = "More craziness";

            Console.WriteLine(weirdStuff);

        }
    }
}
