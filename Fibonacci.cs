using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsDay6
{
    public class Fibonacci
    {
        static int p1 = 0, p2 = 1, p3;
        public static void FibonacciNum(int Count)
        {
            Console.Write(p1 + " " + p2);
            for (int i = 1; i < Count; i++)
            {
                p3 = p1 + p2;
                Console.Write(" " + p3);
                p1 = p2;
                p2 = p3;
            }
        }
    }
}
