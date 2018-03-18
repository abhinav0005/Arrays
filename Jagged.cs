using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Jagged
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[2][];
            arr[0] = new int[] { 1, 2, 3, 4, 5 };
            arr[1] = new int[] { 6, 7, 8, 89 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j=0;j<arr[i].Length;j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
