using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ArrayEx1
    {
        static void Main(string[] args)
        {
            int[] x = { 5, 10, 15, 20, 25 };
            for(int i =0; i <x.Length;i++)
            {
                Console.WriteLine(x[i]);
            }
            Console.Read();
        }
    }
}
