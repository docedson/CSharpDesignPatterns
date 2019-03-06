using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Visitor
{
    public class WheelInventory : IWheelVisitor
    {
        private int _spokesCount;
        private int _bearingsCount;

        public WheelInventory()
        {
            _spokesCount = 30;
            _bearingsCount = 2;
        }

        public void Visit(IWheel wheel)
        {
            Console.WriteLine("The wheel has: {0} spokes and {1} bearings.", _spokesCount, _bearingsCount);
        }

        public void Visit(Spokes spokes)
        {
            _spokesCount++;
        }

        public void Visit(bearings bearings)
        {
            _bearingsCount++;
        }
    }
}
