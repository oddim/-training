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
            int quantityPictures = 52;
            int picturesInRow  = 3;
            int seriesPictures = quantityPictures / picturesInRow ;
            int extraPictures = quantityPictures % picturesInRow ;
            Console.WriteLine($"Вы можете вывести рядов картинок {seriesPictures}, {extraPictures} уже сверх меры ");

        }
    }
}
