namespace Reverse_and_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());

            Predicate<int> divisible = i => i % num == 0;
            Func<int[], Predicate<int>, int[]> remove = (ints, predicate) => ints.Where(i => !predicate(i)).ToArray();
            Func<int[], int[]> reverse = ints => ints.Reverse().ToArray();
            array = remove(array, divisible);
            array = reverse(array);
            
            Console.WriteLine(string.Join(" ", array));
        }
    }
}