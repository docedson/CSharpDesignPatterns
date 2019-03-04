using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Builder
{
    public class RoadBikeDirector : BikeDirector
    {
        /*Method overriden from BikeDirector. Takes the Builder parameter and uses that parameter to call
         * methods and return Bicycle.*/
        public override IBicycle Build(BikeBuilder builder)
        {
            builder.BuildHandleBars();
            builder.BuildStreetTires();

            return builder.Bicycle;
        }
    }
}
