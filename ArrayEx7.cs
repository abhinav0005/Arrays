using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ArrayEx7
    {
        public static void display(params object[] x)
        {
            for(int i=0;i<x.Length;i++)
            {
                Console.WriteLine(x[i]);
            }
        }
        static void Main(string[] args)
        {
            ArrayEx7 a7 = new ArrayEx7();
            display("asdf","addd",1,2,3);
            Console.Read();
        }
    }
}
