using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Builder
{
    public class MountainBikeBuilder : BikeBuilder
    {
        /*
         * Class object AbstractMountainBike
         * is assigned by the contructor and
         * retrieved by the property Bicycle
        */
        private AbstractMountainBike _mountainBikeInProgress;

        /*
         * Property of RoadBikeBuilder used to return an
         * object of IBicycle. This object is of type
         * AbstractMountainBike that implements the IBicycle interface
        */

        public override IBicycle Bicycle
        {
            get
            {
                return _mountainBikeInProgress;
            }
        }

        /*
         * Constructor of the class MountainBikeBuilder that
         * takes a parameter of AbstractMountainBike and assigns
         * that parameter to the class field _mountainBikeInProgress
        */
        public MountainBikeBuilder(AbstractMountainBike mountainBike)
        {
            this._mountainBikeInProgress = mountainBike;
        }

        /*
         * Method
         * public - Access Modifier
         * override - Used to define its behavior instead of 
         * the parent class that it extends
         * void - no return type
        */
        public override void BuildWideTires()
        {
            Console.WriteLine("Building Mountain Bike Wide Tires.");
        }

        public override void BuildHandleBars()
        {
            Console.WriteLine("Build Mountain Bike Handlebars");
        }
    }
}
