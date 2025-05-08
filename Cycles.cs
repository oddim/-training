using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Cycles
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество раз вывода сообщения: ");
            int amountIteration =  Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < amountIteration; i++)
            {
                Console.WriteLine("Message");
            }
        }
    }
}
