using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ArrayEx5
    {
        static void maxArray(int[] x)
        {
            int max = x[0];
            for (int i = 1; i < x.Length; i++)
            {
                if (max < x[i])
                {
                    max = x[i];
                }
            }
            Console.WriteLine("Max number is : " + max);
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 22, 33, 11, 5, 66, 89 };
            int[] arr2 = { 12, 23, 34, 45, 56, 67, 1 };
            maxArray(arr1);
            maxArray(arr2);
            Console.Read();
        }
    }
}
