using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ArrayEx8
    {
        static void Main(string[] args)
        {
            int[] x = { 12, 15, 3, 5, 55, 98, 67, 1 };
            Console.WriteLine("The given array are : ");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i]+" ");
            }
            Console.WriteLine();
            int[] y = new int[5];
            Array.Copy(x, y,5);
            for (int i=0; i<y.Length;i++)
            {
                Console.Write(y[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("After sorting array is :");
            Array.Sort(x);
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Reverse array is :");
            Array.Reverse(x);
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i]+ " ");
            }
          
            Console.Read();
        }
    }
}
