using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Decorator
{
    //Abstract class that demonstrates the Decorator pattern
    public abstract class AbstractBikeOption : AbstractBike
    {
        //Variable of IBicycle that is used to get the active bicycle
        protected internal IBicycle decoratedBike;

        /*Constructor that takes 1 parameter. Also passes the value to its parent through the base declaration
         * Below this is a constructor*/
        public AbstractBikeOption(IBicycle bicycle)
            : base(BikeColor.Chrome, bicycle.GetWheel)
        {
            this.decoratedBike = bicycle;
        }
    }
}
