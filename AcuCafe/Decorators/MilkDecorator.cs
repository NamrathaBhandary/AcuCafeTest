using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe.Decorators
{
    /// <summary>
    /// decorator class for milk addon.
    /// </summary>
    /// <seealso cref="AcuCafe.IDrink" />
    public class MilkDecorator : IDrink
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
        /// Initializes a new instance of the <see cref="MilkDecorator"/> class.
        /// </summary>
        /// <param name="drink">The drink.</param>
        public MilkDecorator(IDrink drink)
        {
            _drink = drink;
            _description = _drink.Description + " with milk"; 
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
