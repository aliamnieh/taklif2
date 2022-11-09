using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter an integer as x :");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter an integer as y :");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n############\n");
            Console.WriteLine("hasel ebarat = "+Math.Sqrt(Math.Pow(Math.Abs(x-y),Math.Abs(y))));
            Console.ReadKey();
        }
    }
}