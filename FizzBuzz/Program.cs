namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool isIncorrectFormat;

            Console.WriteLine("Enter your fizzbuzz number.");
            while ((isIncorrectFormat = !int.TryParse(Console.ReadLine(), out number)) || number < 1)
            {
                if (isIncorrectFormat)
                {
                    Console.WriteLine("Incorrect number format.");
                } else
                {
                    Console.WriteLine("Fizzbuzz numbers are positive integers.");
                }
            }
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine($"{number}");
            }
        }
    }
}