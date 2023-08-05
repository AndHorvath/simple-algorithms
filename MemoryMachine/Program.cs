namespace MemoryMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = string.Empty;
            string newText;

            Console.WriteLine(
                "Enter a text, please.\n" +
                "If you want to finish, just press Enter without entering anything else.");

            while (!string.IsNullOrEmpty(newText = Console.ReadLine()))
            {
                text += newText;

                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.WriteLine(new string(' ', newText.Length));
                Console.SetCursorPosition(0, Console.CursorTop - 1);
            }
            Console.WriteLine(text);
        }
    }
}