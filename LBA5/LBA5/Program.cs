using System;

namespace LBA5
{
    internal class ArrSum
    {
        static void Main(string[] args)
        {
            Console.Write("Input Array Size = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int [] arr = new int[n];
            int s = 0;            

            for (int i = 0; i < n; i++)
            {
                Console.Write($"ENTER ELEMENT NUMBER {i + 1} = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());              
                s = s + arr[i];
            }
            Console.WriteLine("ARRAY ELEMENTS ARE ");
            for (int i = 0; i < n; i++)
                Console.Write($"{arr[i]}\t");
            Console.WriteLine();
            Console.Write($"SUM OF ALL ELEMENTS IS = {s}");
            Console.ReadLine();
        }
       
    }
}
