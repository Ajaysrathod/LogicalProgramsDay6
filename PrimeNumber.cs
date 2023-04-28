using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsDay6
{
    public class PrimeNumber //Creating class
    {
        public static void primeNum(int input)   //Creating method
        {
            int Count = 0;
            for (int i = 2; i <= input / 2; i++)
            {
                if (input % i == 0)
                {
                    Console.WriteLine("Number is not prime");
                    Count = 1;
                    break;
                }
            }
            if (Count == 0)
                Console.WriteLine("The number is prime");
        }

    }
}
