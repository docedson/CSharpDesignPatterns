using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Visitor
{
    public interface IWheelVisitor
    {
        void Visit(IWheel wheel);

        void Visit(Spokes spokes);

        void Visit(bearings bearings);
    }
}
