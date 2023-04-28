using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsDay6
{
    public class ReverseNumber
    {
        public static void reverseNumbers(int number)
        {
            int temp = number;  //To store the variable
            int remainder = 0, reverse = 0;     //Initialize the value to 0
            while (number != 0)    //Using while loop to check the required condition.
            {
                remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;
            }
            Console.WriteLine("Reverse number is:" + reverse);  //To print final output
        }
    }
}
