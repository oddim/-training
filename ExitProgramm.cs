using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            string commandExit = "exit";
            string writingInput = "";

            for (int i = 0; writingInput != commandExit; i++)
            {
                Console.WriteLine("Программа работает");
                Console.WriteLine("Введите exit для выхода из программы");
                writingInput = Console.ReadLine();
            }

            Console.WriteLine("Программа завершена");
        }
    }
}
