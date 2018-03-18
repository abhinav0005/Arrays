using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Array2D
    {
        static void Main(string[] args)
        {
            int[,] x = new int[3, 3];
            x[0, 0] = 2;
            x[1, 1] = 4;
            x[2, 2] = 6;
            for(int i=0;i<3;i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(x[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.Read();
         }
    }
}
