using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fix_variables
{
    internal class fix_variables
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c;
            Console.WriteLine($"a = {a}, b = {b}");
            c = a;
            a = b;
            b = c;
            Console.WriteLine($"a = {a}, b = {b}");
        }
    }
}
