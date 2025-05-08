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
            int amountWriting =  Convert.ToInt32(Console.ReadLine());
            
            while (amountWriting > 0)
            {
                Console.WriteLine("Message");
                amountWriting--;
            }
        }
    }
}
