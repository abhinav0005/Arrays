using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ArrayEx6
    {
        public void Show(params int[] val)   
        {
            for (int i = 0; i < val.Length; i++)
            {
                Console.WriteLine(val[i]);
            }
        }
         
        static void Main(string[] args)
        {
            ArrayEx6 program = new ArrayEx6();   
            program.Show(2, 4, 6, 8, 10, 12, 14);
            Console.Read(); 
        }
    }
}
