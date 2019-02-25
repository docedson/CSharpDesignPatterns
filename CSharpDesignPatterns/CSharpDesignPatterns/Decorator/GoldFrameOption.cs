using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Decorator
{
    public class GoldFrameOption : AbstractBikeOption
    {
        public override decimal Price
        {
            get { return decoratedBike.Price + 300.00m; }
        }

        public GoldFrameOption(IBicycle bicycle)
            : base(bicycle) { }
    }
}
