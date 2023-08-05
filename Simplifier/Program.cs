namespace Simplifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any text, please.");

            string text = Console.ReadLine();
            string simplifiedText = string.Empty;

            foreach (char character in text.ToLower())
            {
                if (simplifiedText.Length == 0 || character != simplifiedText[^1])
                {
                    simplifiedText += character;
                }
            }
            Console.WriteLine(simplifiedText);
        }
    }
}