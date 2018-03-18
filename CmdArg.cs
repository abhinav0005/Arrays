using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CmdArg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("argument length is : " + args.Length);
            Console.WriteLine("enter any thing : ");
            foreach (Object obj in args)
            {
                Console.WriteLine(obj);
            }
            Console.Read();
        }
    }
}
