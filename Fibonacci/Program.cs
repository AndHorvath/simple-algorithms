namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstInitialValue;
            int secondInitialValue;
            int limitIndex;
            List<decimal> fibonacciNumbers = new();
            string incorrectFormatMessage = "Incorrect number format.";

            Console.WriteLine("Enter initial value F(0) of your Fibonacci sequence.");
            while (!int.TryParse(Console.ReadLine(), out firstInitialValue))
            {
                Console.WriteLine(incorrectFormatMessage);
            }
            Console.WriteLine("Enter initial value F(1) of your Fibonacci sequence.");
            while (!int.TryParse(Console.ReadLine(), out secondInitialValue))
            {
                Console.WriteLine(incorrectFormatMessage);
            }
            Console.WriteLine("Up to which index do you need the Fibonacci numbers?");
            while (!int.TryParse(Console.ReadLine(),out limitIndex) || limitIndex < 0)
            {
                Console.WriteLine(incorrectFormatMessage);
            }

            while (fibonacciNumbers.Count - 1 < limitIndex)
            {
                if (fibonacciNumbers.Count == 0)
                {
                    fibonacciNumbers.Add(firstInitialValue);
                }
                else if (fibonacciNumbers.Count == 1)
                {
                    fibonacciNumbers.Add(secondInitialValue);
                }
                else
                {
                    fibonacciNumbers.Add(fibonacciNumbers[^2] + fibonacciNumbers[^1]);
                }
                Console.WriteLine($"F({fibonacciNumbers.Count - 1}): {fibonacciNumbers[^1]}");
            }
        }
    }
}