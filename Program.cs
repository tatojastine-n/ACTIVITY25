using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalUntilStopWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers to sum (type 'stop' to finish):");

            int sum = 0;
            string input;

            do
            {
                Console.Write("Enter a number: ");
                input = Console.ReadLine();

                if (input.Equals("stop", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                if (int.TryParse(input, out int number))
                {
                    sum += number;
                }
                else
                {
                    Console.WriteLine($"Ignoring invalid input: '{input}'");
                }
            } while (true);

            Console.WriteLine($"\nTotal sum: {sum}");
        }
    }
}
