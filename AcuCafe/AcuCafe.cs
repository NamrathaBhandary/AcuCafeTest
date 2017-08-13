using AcuCafe.Enums;
using System;

namespace AcuCafe
{
    public class AcuCafe
    {
        public static IDrink OrderDrink(string type, bool hasMilk, bool hasSugar)
        {
            DrinkType drinkType;
            IDrink drink = null;
            DrinkAddOn addOn = new DrinkAddOn();
            addOn.HasMilk = hasMilk;
            addOn.HasSugar = hasSugar;
            if (Enum.TryParse(type, out drinkType))
            {
                try
                {
                    drink = DrinkFactory.OrderDrink(drinkType, addOn);
                    Console.WriteLine(drink.Description) ;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("We are unable to prepare your drink.");
                    System.IO.File.WriteAllText(@"c:\Error.txt", ex.ToString());
                }
            }

            return drink;
        }
    }
}