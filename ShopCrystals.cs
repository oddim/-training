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
            int amountGold = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько кристаллов вы хотите купить?: ");
            int buyQuantityCristals = Convert.ToInt32(Console.ReadLine());
            amountGold = amountGold - (priceCristalsUnit * buyQuantityCristals);
            Console.WriteLine($"Вы купили {buyQuantityCristals} кристаллов. У вас осталось золота {amountGold} ");
          }
    }
}
