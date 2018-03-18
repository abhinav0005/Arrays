using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ArrayEx4
    {
        static void minArray(int []x)
        {
            int min = x[0];
            for(int i =1; i<x.Length;i++)
            {
                if(min > x[i])
                {
                    min = x[i];
                }
            }
            Console.WriteLine("Min number is : " + min);
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 22, 33, 11, 5, 66, 89 };
            int[] arr2 = { 12, 23, 34, 45, 56, 67, 1 };
            minArray(arr1);
            minArray(arr2);
            Console.Read();
        }
    }
}
