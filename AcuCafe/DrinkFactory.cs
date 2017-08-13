using AcuCafe.Decorators;
using AcuCafe.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe
{
    /// <summary>
    /// Added DrinkFactory class abtract the implementation of IDrink.
    /// Only this class needs to be changed when any new Addon or drink type is added
    /// which is easier to maintain.
    /// </summary>
    public static class DrinkFactory
    {
        /// <summary>
        /// Orders the drink.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="addOn">The add on.</param>
        /// <returns>IDrink implementation</returns>
        public static IDrink OrderDrink(DrinkType type, DrinkAddOn addOn)
        {
            IDrink drink = null;
            switch (type)
            {
                case DrinkType.Expresso:
                    drink = new Expresso();
                    break;
                case DrinkType.Tea:
                    drink = new Tea();
                    break;
                case DrinkType.IceTea:
                    drink = new IceTea();
                    break;
                default:
                    break;
            }

            if (drink != null)
            {
                if (type != DrinkType.IceTea)
                {
                    if (addOn.HasMilk)
                    {
                        drink = new MilkDecorator(drink);
                    }
                    else
                    {
                        drink.Description += " without milk";
                    }
                }

                if (addOn.HasSugar)
                {
                    drink = new SugarDecorator(drink);
                }
                else
                {
                    drink.Description += " without sugar";
                }

                if (addOn.HasChocolate && type == DrinkType.Expresso)
                {
                    drink = new ChocolateDecorator(drink);
                }
            }

            drink.Description = $"We are preparing the following drink for you: {drink.Description}";
            return drink;
        }
    }
}
