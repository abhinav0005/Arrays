using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ArrayEx
    {
        static void Main(string[] args)
        {
            int[] x = new int[5];
            x[0] = 5;
            x[2] = 10;
            x[4] = 12;
            for(int i =0; i<x.Length;i++)
            {
                Console.WriteLine(x[i]);
            }
            Console.Read();
        }
    }
}
