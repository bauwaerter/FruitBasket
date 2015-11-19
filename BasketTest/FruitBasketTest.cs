using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Basket;

namespace BasketTest
{
    [TestClass]
    public class FruitBasketTest
    {
        [TestMethod]
        public void OneItemInBasket()
        {
            FruitBasket theBasket = new FruitBasket
            {
                hasApple = true,
                hasOrange = false, 
                hasBanana = false, 
                hasPear = false 
            };

            var stringToTest = theBasket.DisplayBasket();
            Assert.AreEqual(stringToTest, "There is an apple in the basket.");

            theBasket.hasApple = false;
            theBasket.hasOrange = true;

            stringToTest = theBasket.DisplayBasket();
            Assert.AreEqual(stringToTest, "There is an orange in the basket.");

            theBasket.hasOrange = false;
            theBasket.hasBanana = true;

            stringToTest = theBasket.DisplayBasket();
            Assert.AreEqual(stringToTest, "There is a banana in the basket.");

            theBasket.hasBanana = false;
            theBasket.hasPear = true;

            stringToTest = theBasket.DisplayBasket();
            Assert.AreEqual(stringToTest, "There is a pear in the basket.");

        }

        [TestMethod]
        public void MultipleItemsInBasket()
        {
            FruitBasket theBasket = new FruitBasket
            {
                hasApple = true,
                hasOrange = true,
                hasBanana = false,
                hasPear = false
            };

            var stringToTest = theBasket.DisplayBasket();
            Assert.AreEqual(stringToTest, "There is an apple, and an orange in the basket.");

            theBasket.hasBanana = true;

            stringToTest = theBasket.DisplayBasket();
            Assert.AreEqual(stringToTest, "There is an apple, an orange, and a banana in the basket.");

            theBasket.hasPear = true;

            stringToTest = theBasket.DisplayBasket();
            Assert.AreEqual(stringToTest, "There is an apple, an orange, a banana, and a pear in the basket.");
        }
    }
}
