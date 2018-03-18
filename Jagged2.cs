using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Jagged2
    {
        static void Main(string[] args)
        {
            int[][] x = new int[3][] {
                new int[] { 1, 2, 3, 4 },
                new int [] {1,2},
                new int [] {9,8,7,6}};
            for (int i=0;i<x.Length;i++)
            {
                for(int j=0;j<x[i].Length;j++)
                {
                    Console.Write(x[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
