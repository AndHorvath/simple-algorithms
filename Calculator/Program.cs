namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int integerA;
            int integerB;

            double result;

            string operation;
            string[] operations = { "+", "-", "*", "/" };

            bool isIncorrectFormat;

            string incorrectFormatMessage = "Incorrect number format.";
            string incorrectOperationMessage = "Incorrect operation entry.";
            string divisionByZeroMessage = "No division by zero.";

            Console.WriteLine("Enter first operand, an integer, please.");
            while (!int.TryParse(Console.ReadLine(), out integerA))
            {
                Console.WriteLine(incorrectFormatMessage);
            }
            Console.WriteLine("Select operation: +, -, * or /");
            while (!operations.Contains(operation = Console.ReadLine() ?? string.Empty))
            {
                Console.WriteLine(incorrectOperationMessage);
            }
            Console.WriteLine("Enter second operand, an integer as well, please.");
            while ((isIncorrectFormat = !int.TryParse(Console.ReadLine(), out integerB)) || operation == "/" && integerB == 0)
            {
                if (isIncorrectFormat)
                {
                    Console.WriteLine(incorrectFormatMessage);
                }
                else
                {
                    Console.WriteLine(divisionByZeroMessage);
                }
            }
            switch (operation)
            {
                case "+":
                    result = integerA + integerB;
                    break;
                case "-":
                    result = integerA - integerB;
                    break;
                case "*":
                    result = integerA * integerB;
                    break;
                case "/":
                    result = integerA / (double)integerB;
                    break;
                default:
                    result = double.NaN;
                    break;
            }
            Console.WriteLine($"{integerA} {operation} {integerB} = {result}");
        }
    }
}