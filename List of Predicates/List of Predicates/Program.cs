﻿namespace List_of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] divisors = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int, int, bool> isDivisible = (i, d) => i % d == 0;
            for (int i = 1; i <= num; i++)
            {
                bool divisible = true;
                foreach (var divisor in divisors)
                {
                    if (!isDivisible(i, divisor))
                    {
                        divisible = false;
                        break;
                    }
                }

                if (divisible)               
                    Console.Write(i + " ");                
            }
        }
    }
}