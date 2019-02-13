using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Builder
{
    public abstract class BikeDirector
    {
        /*
         * public - access modifier
         * abstract - requires child classes to implement
         * IBicycle - return type of the method
         * BikeBuilder - method parameter object
         * builder - method parameter object variable
        */
        public abstract IBicycle Build(BikeBuilder builder);
    }
}
