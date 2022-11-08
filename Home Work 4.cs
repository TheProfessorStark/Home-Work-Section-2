using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Test_App_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get a number and print number + 10.

            int number;
            number = Convert.ToInt32(Console.ReadLine());
            number += 10;
            Console.WriteLine(number);
        }
    }
}
