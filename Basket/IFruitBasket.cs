using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket
{
    public interface IFruitBasket
    {
        string DisplayBasket();

        string DisplayBasket(List<string> basketList);
    }
}
