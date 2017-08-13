using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe.Decorators
{
    /// <summary>
    /// decorator class for sugar addon.
    /// </summary>
    /// <seealso cref="AcuCafe.IDrink" />
    public class SugarDecorator : IDrink
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
        /// Initializes a new instance of the <see cref="SugarDecorator"/> class.
        /// </summary>
        /// <param name="drink">The drink.</param>
        public SugarDecorator(IDrink drink)
        {
            _drink = drink;
            _description = _drink.Description + " with sugar";
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
