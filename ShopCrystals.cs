using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopKristalls
{
    internal class ShopCrystals
    {
        static void Main(string[] args)
        {
            int priceCristalsUnit = 4;
            Console.Write("Сколько у вас золото в кошельке?: ");
            int myGold = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько кристаллов вы хотите купить?: ");
            int buyCristals = Convert.ToInt32(Console.ReadLine());
            int myCristals = myGold / priceCristalsUnit;
            myGold = myGold - (priceCristalsUnit * buyCristals);
            Console.WriteLine($"Вы купили {buyCristals} кристаллов. У вас осталось золота {myGold} ");
          }
    }
}
