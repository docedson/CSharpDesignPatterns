using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns
{
    public class CrossCountry : AbstractMountainBike
    {
        public override decimal Price { get; } = 850.00m;

        public CrossCountry(IWheel wheel)
           : this(BikeColor.Black, wheel) { }

        public CrossCountry(BikeColor color, IWheel wheel)
            : base(color, wheel) { }
    }
}
