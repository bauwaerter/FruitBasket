using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Basket
{
    public class FruitBasket
    {
        private const string APPLE = "an apple";
        private const string ORANGE = "an orange";
        private const string BANANA = "a banana";
        private const string PEAR = "a pear";

        public bool hasApple { get; set; }
        public bool hasOrange { get; set; }
        public bool hasBanana { get; set; }
        public bool hasPear { get; set; }
            
        public string DisplayBasket()
        {
            string basketContents = "The basket is empty.";

            var basketList = GetBasketItems();
            var numItemsInBasket = basketList.Count();

            if (numItemsInBasket > 0)
            {
                basketContents = "There is ";

                for (int i = 0; i < numItemsInBasket; i++)
                {
                    //at the end of the list and have multiple items
                    if ((i + 1) == numItemsInBasket && numItemsInBasket > 1)
                        basketContents += "and ";

                    basketContents += basketList[i];

                    //not at the end of the list and have multiple items add a comma
                    if ((i + 1) != numItemsInBasket && numItemsInBasket > 1)
                        basketContents += ", ";
                    
                }
                
                basketContents += " in the basket.";
            }

            return basketContents;
        }

        public List<string> GetBasketItems()
        {
            var basketItemsList = new List<string>();

            if (this.hasApple)
                basketItemsList.Add(APPLE);
            if (this.hasOrange)
                basketItemsList.Add(ORANGE);
            if (this.hasBanana)
                basketItemsList.Add(BANANA);
            if (this.hasPear)
                basketItemsList.Add(PEAR);
                        
            return basketItemsList;
        }
    }
}
