using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Decorator
{
    public class WhiteTireOption : AbstractBikeOption
    {
        public override decimal Price
        {
            get { return decoratedBike.Price + 80.00m; }
        }

        public WhiteTireOption(IBicycle bicycle)
            : base(bicycle) { }
    }
}
