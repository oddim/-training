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

            for (int i = 0; beginingNumber <= maxNumber; i++)
            {
                Console.WriteLine(beginingNumber);
                beginingNumber = beginingNumber + stepNumber;
            }
        }
    }
}
