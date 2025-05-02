using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class timeInLine
    {
        static void Main(string[] args)
        {
            int timePersonClinic = 10;
            Console.Write("Сколько людей в очереди? :");
            int lineAmountPerson = Convert.ToInt32(Console.ReadLine());
            int hourWainting = timePersonClinic * lineAmountPerson / 60;
            int minutesWaiting = timePersonClinic*lineAmountPerson - hourWainting*60;
            Console.WriteLine($"Вы будете стоять в очереди {hourWainting} часа и {minutesWaiting} минут");
        }
    }
}
