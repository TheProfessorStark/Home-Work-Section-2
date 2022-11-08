using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Do ~ sqrt(pow(abs(x - y), abs(y))) ~ .

            int x, y;
            double num;

            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            num = Math.Abs(x - y);
            num = Math.Pow(num, (Math.Abs(y)));
            num = Math.Sqrt(num);

            Console.WriteLine(num);
        }
    }
}
