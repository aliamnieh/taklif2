using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter an integer number : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the number you have entered is : " + num);
            Console.ReadKey();
        }
    }
}
