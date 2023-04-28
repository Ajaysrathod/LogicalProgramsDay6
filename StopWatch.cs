using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsDay6
{
    public class StopWatch
    {
        public static void Watch()
        {
            Stopwatch stopwatch = new Stopwatch();
        validation1:
            Console.WriteLine("To start the stopwatch enter S or s");
            char start = Convert.ToChar(Console.ReadLine());
            stopwatch.Start();
            if (start == 's' || start == 'S')
            {
            validation2:
                Console.WriteLine("To stop the stopwatch enter Q or q");
                char end = Convert.ToChar(Console.ReadLine());
                if (end == 'Q' || end == 'q')
                {
                    stopwatch.Stop();
                    Console.WriteLine("stopwatch stopped , the time : " + stopwatch.Elapsed);
                }
                else
                {
                    Console.WriteLine("Wrong Input");
                    goto validation2;
                }
            }
            else
            {
                stopwatch.Stop();
                Console.WriteLine("Wong Input");
                goto validation1;
            }
        }
    }
}

