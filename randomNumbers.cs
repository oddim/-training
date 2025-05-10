using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sumNumbers = 0;
            int firstDivisor = 3;
            int secondDivisor = 5;
            int maxNumber = 100;

            Random rand = new Random();
            number = rand.Next(0,maxNumber);

            for (int i = 0; i <= number; i++)
            {
                if (i % firstDivisor == 0 || i % secondDivisor == 0)
                {
                    sumNumbers = sumNumbers + i;
                }
            }

            Console.WriteLine($"Рандомное число: {sumNumbers}");
        }
    }
}
