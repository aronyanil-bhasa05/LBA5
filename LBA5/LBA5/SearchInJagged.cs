using System;

namespace LBA5
{
    internal class SearchInJagged
    {
        static void Main()
        {
            
            Console.Write("Enter Row Size = ");
            int rows = Convert.ToInt32(Console.ReadLine());
            int [][] arr = new int[rows][];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"How many elements do you want in row {i + 1} = ");
                int cols = Convert.ToInt32(Console.ReadLine());
                arr[i]=new int [cols];
                Console.WriteLine("ENTER ELEMENTS ");
                for (int j = 0; j < arr[i].Length; j++)
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("YOUR JAGGED ARRAY ");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                    Console.Write($"{arr[i][j]}  ");
                Console.WriteLine();
            }

            Console.Write("ENTER SEARCH ELEMENT = ");
            int s = Convert.ToInt32(Console.ReadLine());
            int f = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                for(int j=0;j< arr[i].Length; j++)
                {
                    if (arr [i][j] == s)
                    {
                        Console.WriteLine($"Element found in row {i + 1} position {j + 1} ");
                        f = 1;
                    }
                }
            }

            if (f == 0)
                Console.WriteLine("Element not found ");
            Console.ReadLine();
            
        }
        
    }
}
