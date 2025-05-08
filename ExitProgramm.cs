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
            string commandExit = "exit";
            string writingInput = "";

            while (commandExit != writingInput)
            {
                Console.WriteLine("Программа всё еще работает");
                Console.WriteLine("Введите exit для выхода из программы");
                writingInput = Console.ReadLine();
            }

            Console.WriteLine("Программа завершена");
        }
    }
}
