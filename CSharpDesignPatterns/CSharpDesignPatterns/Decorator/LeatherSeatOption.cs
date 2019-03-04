using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Decorator
{
    //Class for Leather Seats as an option to a base level bicycle
    public class LeatherSeatOption : AbstractBikeOption
    {
        /*Property of Price that takes the active bike and adds the price of the option.
         * Price comes from IBicycle where it is defined*/
        public override decimal Price
        {
            get { return decoratedBike.Price + 40.00m; }
        }

        /*Constructor that takes 1 parameter. Also passes the value to its parent
         * through the base declaration*/
        public LeatherSeatOption(IBicycle bicycle)
            : base(bicycle) { }
    }
}
