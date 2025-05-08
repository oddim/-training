using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class ExitProgramm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите exit для выхода из программы");

            while (true)
            {
                string writingExit = Console.ReadLine();

                if (writingExit == "exit")
                {
                    Console.WriteLine("Вы вышли из программы");
                    break;
                }

                Console.WriteLine("Программа всё еще работает");
            }
        }
    }
}
