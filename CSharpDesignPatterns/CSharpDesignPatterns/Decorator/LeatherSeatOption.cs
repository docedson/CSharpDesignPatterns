using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Decorator
{
    public class LeatherSeatOption : AbstractBikeOption
    {
        public override decimal Price
        {
            get { return decoratedBike.Price + 40.00m; }
        }

        public LeatherSeatOption(IBicycle bicycle)
            : base(bicycle) { }
    }
}
