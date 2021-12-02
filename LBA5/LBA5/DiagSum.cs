using System;

namespace LBA5
{
    internal class DiagSum
    {
        static void Main()
        {
            Console.Write("Enter 2D Array Size (Square Matrix) = ");
            int n=Convert.ToInt32(Console.ReadLine()); 
            int[,] arr = new int[n, n];

            for(int i=0;i<n;i++)
            {
               for(int j=0;j<n;j++)
                {
                    Console.Write($"Enter Element for pos ({i+1},{j+1}) = ");
                    arr [i,j]=Convert.ToInt32(Console.ReadLine()); 
                }
            }
            Console.WriteLine();
            Console.Write("2D Array \n");
            int s=0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{arr[i,j]}\t");
                    if (i == j)
                        s = s + arr[i, j];
                }
                Console.WriteLine();
            }
            Console.Write($"Sum of Diagonal is = {s}");
            Console.ReadLine();
        }
    }
}
