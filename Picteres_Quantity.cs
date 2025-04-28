using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cslight
{
    internal class Picteres_Quantity
    {
        static void Main(string[] args)
        {
            int quantityPic = 52;
            int series1Pic = 3;
            int showSeriesPic;
            int extraShowPic;
            showSeriesPic = quantityPic / series1Pic;
            extraShowPic = quantityPic % series1Pic;
            Console.WriteLine($"Вы можете вывести рядов картинок {showSeriesPic}, {extraShowPic} уже сверх меры ");

        }
    }
}
