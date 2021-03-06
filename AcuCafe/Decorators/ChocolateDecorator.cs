﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe.Decorators
{
    /// <summary>
    /// Have used the decorator pattern so if any new add on will need to just add a new decorator class
    /// that implements IDrink and need to update the factory class to return the implementation and DrinkAddon class.
    /// But don't have to change any other classes that already uses these classses non of the existing functionlaity are changed.
    /// decorator class for choclate addon.
    /// </summary>
    /// <seealso cref="AcuCafe.IDrink" />
    public class ChocolateDecorator : IDrink
    {
        /// <summary>
        /// The description
        /// </summary>
        private string _description;

        /// <summary>
        /// The drink
        /// </summary>
        private IDrink _drink;

        /// <summary>
        /// The cost
        /// </summary>
        private const double _cost = 0.5;

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChocolateDecorator"/> class.
        /// </summary>
        /// <param name="drink">The drink.</param>
        public ChocolateDecorator(IDrink drink)
        {
            _drink = drink;
            _description = _drink.Description + " with chocolate"; 
        }

        /// <summary>
        /// Gets the cost.
        /// </summary>
        /// <returns>cost</returns>
        public double GetCost()
        {
            return _drink.GetCost() + _cost;
        }
    }
}
