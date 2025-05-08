using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class SetNumbers
    {
        static void Main(string[] args)
        {
            int beginingNumber = 5;
            int stepNumber = 7;
            int maxNumber = 789;

            for (int i = beginingNumber; i <= maxNumber; i += stepNumber)
            {
                Console.WriteLine(i);
            }
        }
    }
}
