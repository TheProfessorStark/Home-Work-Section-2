using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get a, b, c. Then if they make a triangle, print the perimiter.

            int a, b, c;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            // a + b > c
            // a + c > b
            // b + c > a

            if (a + b > c && a + c > b && b + c > a)
            {
                Perimeter(a, b, c);
            }
            else
            {
                Console.WriteLine("ERROR! Your numbers cannot make a triangle! ");
            }
        }
        
        private static void Perimeter(int x, int y, int z)
        {
            int perimeter = x + y + z;
            Console.WriteLine(perimeter);
        }
    }
}
