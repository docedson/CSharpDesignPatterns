using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Decorator
{
    public class CustomGripOption : AbstractBikeOption
    {
        public override decimal Price
        {
            get { return decoratedBike.Price + 20.00m;}
        }

        public CustomGripOption(IBicycle bicycle)
            : base(bicycle) { }
    }
}
