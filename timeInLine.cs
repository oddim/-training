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
            int minutesHour = 60;

            Console.Write("Сколько людей в очереди? :");
            int lineAmountPerson = Convert.ToInt32(Console.ReadLine());

            int lineTime = timePersonClinic * lineAmountPerson;
            int hourWaiting = lineTime / minutesHour;
            int minutesWaiting = lineTime - hourWaiting * minutesHour;

            Console.WriteLine($"Вы будете стоять в очереди {hourWaiting} часа и {minutesWaiting} минут");
        }
    }
}
