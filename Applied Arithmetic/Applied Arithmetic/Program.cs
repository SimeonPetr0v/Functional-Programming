namespace Applied_Arithmetic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();
            while (input != "end")
            {
                Func<int, int> convertFunc = null;
                if (input == "add")
                    convertFunc = i => i + 1;
                
                else if (input == "subtract")
                    convertFunc = i => i - 1;
                
                else if (input == "multiply")
                    convertFunc = i => i * 2;
               
                if (input == "print")
                    Console.WriteLine(string.Join(" ", array));
                
                else
                    array = array.Select(convertFunc).ToArray();
                
            }
        }
    }
}