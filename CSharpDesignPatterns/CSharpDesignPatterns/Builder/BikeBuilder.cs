using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns; // We need access to this namespace

namespace Builder
{
    public abstract class BikeBuilder
    {
        //Property of IBicycle called Bicycle
        public abstract IBicycle Bicycle { get; }

        /*
         * For the methods below:
         * Virtual keyword used to optionally override in
         * child class
         * void means no return type
         * public is the access modifier - Everyone can see
        */

        public virtual void BuildStreetTires() { }
        public virtual void BuildWideTires() { }
        public virtual void BuildHandleBars() { }
    }
}
