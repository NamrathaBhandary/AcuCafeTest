using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe
{
    /// <summary>
    /// class for methods of drinktype Expresso.
    /// </summary>
    /// <seealso cref="AcuCafe.IDrink" />
    public class Expresso : IDrink
    {
        /// <summary>
        /// The description
        /// </summary>
        private string _description = "Expresso";

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
        /// Gets the cost.
        /// </summary>
        /// <returns>cost</returns>
        public double GetCost()
        {
            return 1.8;
        }
    }
}
