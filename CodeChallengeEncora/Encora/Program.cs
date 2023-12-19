namespace Encora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lines = new List<string>();
            Console.WriteLine("Write the text to sort");

            string line;
            while (true)
            {
                line = Console.ReadLine();
                
                if (string.IsNullOrEmpty(line))
                {
                    break;
                }

                lines.Add(line);
            }

            foreach (var lineText in lines)
            {
                Console.WriteLine(StringManipulator.SortingOperations(lineText));
            }
        }
    }
}