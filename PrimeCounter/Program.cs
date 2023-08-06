namespace PrimeCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lowerLimit;
            int upperLimit;
            int numberOfCompositeNumbers = 0;

            bool isIncorrectFormat;

            string incorrectFormatMessage = "Incorrect number format.";
            string incorrectLimitsMessage = "Upper limit must be higher than lower limit.";

            Console.WriteLine("Enter lower limit.");
            while (!int.TryParse(Console.ReadLine(), out lowerLimit))
            {
                Console.WriteLine(incorrectFormatMessage);
            }
            Console.WriteLine("Enter upper limit.");
            while ((isIncorrectFormat = !int.TryParse(Console.ReadLine(), out upperLimit)) || upperLimit < lowerLimit)
            {
                if (isIncorrectFormat)
                {
                    Console.WriteLine(incorrectFormatMessage);
                }
                else
                {
                    Console.WriteLine(incorrectLimitsMessage);
                }
            }

            for (int i = Math.Max(lowerLimit, 2); i <= upperLimit; i++)
            {
                for (int j = 2; j <= Math.Ceiling(Math.Sqrt(i)); j++)
                {
                    if (i % j == 0 && i != 2)
                    {
                        numberOfCompositeNumbers++;
                        break;
                    }
                }
            }
            int numberOfPrimes = Math.Max(upperLimit, 1) - Math.Max(lowerLimit, 2) + 1 - numberOfCompositeNumbers;
            string are = numberOfPrimes != 1 ? "are" : "is";
            string numbers = numberOfPrimes != 1 ? "numbers" : "number";

            Console.WriteLine(
                $"Between {lowerLimit} and {upperLimit}, including the limits, " +
                $"there {are} {numberOfPrimes} prime {numbers}.");
        }
    }
}