using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                //Api call that retrieves the contents of the basket
                FruitBasket theBasket = ApiCall.getFruitBasket();
                //Output the contents of the basket that was retrieved from the api call above. For example:
                //There is an apple, orange, banana and pear in the basket.
                System.Console.Out.WriteLine("Basket Contents:\n\n" + theBasket.DisplayBasket());
                System.Console.ReadLine();
            }
            catch (System.Net.WebException ex)
            {
                System.Console.Out.WriteLine(String.Format("WebException occured - getFruitBasket() - {0} {1}", ex.Status, ex.Message));
                System.Console.ReadLine();
            }
            catch (Exception ex)
            {
                System.Console.Out.WriteLine("Exception occured - getFruitBasket() - " + ex.Message);
                System.Console.ReadLine();
            }

            
        }
    }
}
