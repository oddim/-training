using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName, userAge, userProfession, userSex;
            Console.WriteLine("Заполните анкету");
            Console.Write("Ваше имя и фамилию: ");
            userName = Console.ReadLine();
            Console.Write("Ваш возраст: ");
            userAge = Console.ReadLine();
            Console.Write("Ваш пол: ");
            userSex = Console.ReadLine();
            Console.Write("Ваша профессия: ");
            userProfession = Console.ReadLine();

            Console.WriteLine($"Вас зовут {userName}. Вам {userAge} и вы {userSex}. Ваша профессия - {userProfession}");
            Console.ReadKey();
        }
    }
}
