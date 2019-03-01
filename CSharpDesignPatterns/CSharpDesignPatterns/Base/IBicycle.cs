using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns
{
    public interface IBicycle
    {
        IWheel GetWheel { get; }

        BikeColor ColorType { get; }

        decimal Price { get; }

        void Paint(BikeColor color);

        void CleanFrame();
        void AirTires();
        void TestRide();
    }
}
