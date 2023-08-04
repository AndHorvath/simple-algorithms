namespace Censor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] vowelsLower = { 'a', 'e', 'i', 'o', 'u' };
            char[] vowelsUpper = Array.ConvertAll(vowelsLower, char.ToUpper);
            IEnumerable<char> vowels = vowelsLower.Union(vowelsUpper);

            Console.WriteLine("Enter a text, please.");
            string text = Console.ReadLine();

            foreach (char vowel in vowels)
            {
                text = text.Replace(vowel, '*');
            }
            Console.WriteLine(text);
        }
    }
}