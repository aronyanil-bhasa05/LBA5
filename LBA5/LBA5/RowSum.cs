using System;

namespace LBA5
{
    internal class RowSum
    {
        static void Main ()
        {
            Console.Write("ENTER ROW SIZE = ");
            int m =Convert.ToInt32(Console.ReadLine());
            Console.Write("ENTER COLOUMN SIZE = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int [,] arr=new int[m,n];
            Console.WriteLine("ENTER MATRIX ELEMENTS ");
            for(int i=0;i<m;i++)
            {
                for(int j=0;j<n;j++)
                {
                    Console.Write($"ENTER ELEMENT FOR POS ({i+1},{j+1}) = ");
                    arr[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            int s = 0;
            Console.WriteLine();
            for (int i=0;i<m;i++)
            {
                for (int j=0;j<n;j++)
                {
                    s = s + arr[i, j];
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.Write($"SUM = {s}");
                s = 0;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
