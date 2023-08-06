namespace FizzBuzzSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int upperBoundary;
            bool isIncorrectFormat;
            string result;

            Console.WriteLine("Enter upper boundary.");
            while ((isIncorrectFormat = !int.TryParse(Console.ReadLine(), out upperBoundary)) || upperBoundary < 1)
            {
                if (isIncorrectFormat)
                {
                    Console.WriteLine("Incorrect number format.");
                }
                else
                {
                    Console.WriteLine("Fizzbuzz numbers are positive integers.");
                }
            }
            for (int i = 1; i <= upperBoundary; i++)
            {
                result = string.Empty;
                if (i % 3 == 0)
                {
                    result += "Fizz";
                }
                if (i % 5 == 0)
                {
                    result += "Buzz";
                }
                if (i % 3 != 0 && i % 5 != 0)
                {
                    result = i.ToString();
                }
                Console.WriteLine(result);
            }
        }
    }
}