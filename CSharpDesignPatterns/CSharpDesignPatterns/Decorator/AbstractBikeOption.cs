using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Decorator
{
    public abstract class AbstractBikeOption : AbstractBike
    {
        protected internal IBicycle decoratedBike;
        //below this is a constructor
        public AbstractBikeOption(IBicycle bicycle)
            : base(BikeColor.Chrome, bicycle.GetWheel)
        {
            this.decoratedBike = bicycle;
        }
    }
}
