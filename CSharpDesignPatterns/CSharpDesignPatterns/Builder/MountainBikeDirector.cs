using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Builder
{
    public class MountainBikeDirector : BikeDirector
    {
        /*Method overriden from BikeDirector. Takes the Builder paramet and uses that parameter to call
         * methods and return Bicycle.*/
        public override IBicycle Build(BikeBuilder builder)
        {
            builder.BuildHandleBars();
            builder.BuildWideTires();

            return builder.Bicycle;
        }

    }
}
