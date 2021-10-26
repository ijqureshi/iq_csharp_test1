using System;

namespace IQ_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //This is a variable

            string message = "This is a message using a variable";

            Console.WriteLine(message);

            //Concatenation

            string prefix = "Mr";
            string name = "Schweinsteiger";


            Console.WriteLine(prefix + name);

            //Length

            Console.WriteLine(name.Length);

            // Character

            char letter = 'A';
            Console.WriteLine(letter);

            //Booleans

            bool isAdmin = true;
            bool isActive = false;

            Console.WriteLine(isAdmin);
            Console.WriteLine(isActive);


            //Arrays

            int[] numbers = new int[4];
            Console.WriteLine(numbers);

            int[] morenumbers = new int[3];
            Console.WriteLine(morenumbers[0]);
            Console.WriteLine(morenumbers[1]);
            Console.WriteLine(morenumbers[2]);


            int[] values = new int[] { 8, 4, 16, 32 };
            Console.WriteLine(values[0]);
            Console.WriteLine(values[1]);
            Console.WriteLine(values[2]);
            Console.WriteLine(values[3]);







        }
    }
}
