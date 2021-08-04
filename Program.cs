using System;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        static void Main()
        {
            var range = Enumerable.Range(1, 100);            

            foreach (var i in range)
            {
                var output = "";

                if (i % 3 == 0)
                {
                    output += "Fizz";
                }

                if (i % 5 == 0)
                {
                    output += "Buzz";
                }

                if (output.Length <= 0)
                {
                    output += i;
                }

                Console.WriteLine(output);
            }
        }
    }
}