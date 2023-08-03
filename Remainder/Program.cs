namespace Remainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dividend;
            int divisor;
            bool isIncorrectDivisor;
            string incorrectFormatMessage = "Incorrect number format.";
            string divisionByZeroMessage = "No division by zero.";
            
            Console.WriteLine("Enter dividend.");
            while (!int.TryParse(Console.ReadLine(), out dividend))
            {
                Console.WriteLine(incorrectFormatMessage);
            }
            Console.WriteLine("Enter divisor.");
            while ((isIncorrectDivisor = !int.TryParse(Console.ReadLine(), out divisor)) || divisor == 0)
            {
                if (isIncorrectDivisor)
                {
                    Console.WriteLine(incorrectFormatMessage);
                }
                else
                {
                    Console.WriteLine(divisionByZeroMessage);
                }
            }
            Console.WriteLine($"The division's remainder is {dividend % divisor}");
        }
    }
}