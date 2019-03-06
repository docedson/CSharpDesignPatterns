using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Visitor
{
    public class WheelDiagnostics : IWheelVisitor
    {
        public void Visit(IWheel wheel)
        {
            Console.WriteLine("Diagnosing the Wheel");
        }

        public void Visit(Spokes spokes)
        {
            Console.WriteLine("Diagnosing the Spokes");
        }

        public void Visit(bearings bearings)
        {
            Console.WriteLine("Diagnosing the bearings");
        }
    }
}
