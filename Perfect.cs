using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsDay6
{
    public class Perfect  //Creating class
    {
        public static void PerfectNumber1(int number)       //Creating method
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }

            if (sum == number)
                Console.WriteLine("{0} is perfect number", number);
            else
                Console.WriteLine("{0} is not perfect number", number);
        }
    
    }
}
