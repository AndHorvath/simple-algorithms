namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entry;
            string entryType;
            char[] characters;
            char[] charactersReversed;
            
            Console.WriteLine("Enter any text or a number, please.");
            entry = Console.ReadLine();

            if (float.TryParse(entry, out float number))
            {
                characters = number.ToString().Where(character => char.IsDigit(character)).ToArray();
                entryType = "number";
            }
            else
            {
                characters = entry.ToLower().Where(character => char.IsLetterOrDigit(character)).ToArray();
                entryType = "text";
            }
            charactersReversed = new char[characters.Length];
            Array.Copy(characters, charactersReversed, characters.Length);
            Array.Reverse(charactersReversed);

            if (Enumerable.SequenceEqual(characters, charactersReversed))
            {
                Console.WriteLine($"Entered {entryType} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"Entered {entryType} is not a palindrome.");
            }
        }
    }
}