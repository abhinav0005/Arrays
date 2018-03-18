using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ArrayEx3
    {
        static void printArray(int[] x)
        {
            Console.WriteLine("Array is :");
            foreach(int i in x)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 5, 6, 7, 8, 9 };
            int[] arr2 = { 9, 87, 6, 5, 4, 3, 2 };
            printArray(arr1);
            printArray(arr2);
            Console.Read();
        }
      
    }
}
