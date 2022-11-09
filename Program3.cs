using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b :");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter c :");
            int c = Convert.ToInt32(Console.ReadLine());
            f(a, b, c);
            Console.ReadKey();
        }
        static void f(int a,int b,int c)
        {
            if ((a + b) > c && (a + c) > b && (b + c) > a) Console.WriteLine("mohit is : " + (a + b + c));
            else Console.WriteLine("it is not a triangle!");
        }
    }
}
