using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket
{
    class ApiCall
    {
        public static FruitBasket getFruitBasket()
        {
            FruitBasket result = new FruitBasket();

            Random rand = new Random();

            result.hasApple = rand.Next(2) == 0;
            result.hasOrange = rand.Next(2) == 0;
            result.hasBanana = rand.Next(2) == 0;
            result.hasPear = rand.Next(2) == 0;

            return result;
        }
    }
}
