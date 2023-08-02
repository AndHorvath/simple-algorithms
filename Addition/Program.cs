using System.Numerics;

namespace Addition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int integer;
            int sum = 0;

            Console.WriteLine("Enter an integer, please. If you want to quit, enter zero.");
            do
            {
                while (!int.TryParse(Console.ReadLine(), out integer))
                {
                    Console.WriteLine("Incorrect number entry.");
                }
                sum += integer;
                Console.WriteLine($"Sum of your entries: {sum}");
            } while (integer != 0);
        }
    }
}