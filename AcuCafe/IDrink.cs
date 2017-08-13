using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe
{
    public interface IDrink
    {
        //string GetDescription();
        string Description { get; set; }

        double GetCost();
    }
}
