using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns
{
    public class Vintage : AbstractRoadBike
    {
        public override decimal Price { get; } = 600.00m;

        public Vintage(IWheel wheel)
           : this(BikeColor.Red, wheel) { }

        public Vintage(BikeColor color, IWheel wheel)
            : base(color, wheel) { }
    }
}
