﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket
{
    interface IFruitBasket
    {
        string DisplayBasket();

        string DisplayBasket(List<string> basketList);
    }
}
