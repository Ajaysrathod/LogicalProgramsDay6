namespace LogicalProgramsDay6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Programs!");
            Console.WriteLine("please enter below option ");
            Console.WriteLine("1:Fibonacci");
            int options = Convert.ToInt32(Console.ReadLine());
            switch (options)
            {
                case 1:
                    Console.WriteLine("Please enter input value");
                    int count = Convert.ToInt32(Console.ReadLine());
                    Fibonacci.FibonacciNum(count);
                    break;
                default:
                    Console.WriteLine("Plaese choose correct option");
                    break;
            }
        }
    }
}