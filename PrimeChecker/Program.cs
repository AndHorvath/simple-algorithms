namespace PrimeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberToCheck;

            Console.WriteLine("Enter a number, please.");
            while (!int.TryParse(Console.ReadLine(), out numberToCheck) || numberToCheck < 0)
            {
                if (numberToCheck < 0)
                {
                    Console.WriteLine("Primes are a subset of the natural numbers.");
                }
                else
                {
                    Console.WriteLine("Incorrect number format.");
                }
            }
            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(numberToCheck)) || numberToCheck < 2; i++)
            {
                if (numberToCheck % i == 0 && numberToCheck != 2 || numberToCheck == 1)
                {
                    Console.WriteLine($"{numberToCheck} is not prime.");
                    return;
                }
            }
            Console.WriteLine($"{numberToCheck} is prime.");
        }
    }
}