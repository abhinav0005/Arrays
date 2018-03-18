using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ArrayEx3D
    {
        static void Main(string[] args)
        {
            int[,] x = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }};
            for(int i=0;i<3;i++)
            {
                for(int j =0; j<3;j++)
                {
                    Console.Write(x[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
