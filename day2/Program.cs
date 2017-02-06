using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class Program1
    {
        public static void Main()
        {
            System.Console.WriteLine("1");

            System.Console.Write("2");
            System.Console.Write("3");
            System.Console.WriteLine("4");
            System.Console.WriteLine(6 + 9);

            int a = 5, b = 10;
            Console.WriteLine(a+b);

            Console.WriteLine("Three Double Quotes \"\"\"");
            Console.WriteLine("*\n**\n***");
            Console.WriteLine("*\t**\t***");

            Console.WriteLine("Name\t\t Age");
            Console.WriteLine("John Smith\t 21");

            Console.WriteLine(a + "+" + b + "=" + a + b);

            double c = 70.8;
            double d = 100.1;

            Console.WriteLine(c + d);
            Console.WriteLine(a + c);

            Console.WriteLine("He weighs {0} kg and is {1} tall", c, d);
            Console.WriteLine("He weighs {0:0.000} kg and is {1:0.000} tall", c, d);

            double balance = 123456.678901387619726;
            Console.WriteLine("${0:0.00}", balance);
            Console.WriteLine("${0:0,000.00}", balance);

            double x = 123;
            double y = 127836498173.0987726354;

            Console.WriteLine("{0:##00}", y);

        }
    }
}
