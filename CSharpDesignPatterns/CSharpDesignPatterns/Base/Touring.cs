using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns
{
    public class Touring : AbstractRoadBike
    {
        public override decimal Price { get; } = 570.00m;

        public Touring(IWheel wheel)
           : this(BikeColor.Blue, wheel) { }

        public Touring(BikeColor color, IWheel wheel)
            : base(color, wheel) { }
    }
}
