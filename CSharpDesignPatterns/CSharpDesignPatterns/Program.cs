using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;
using Builder;

namespace CSharpDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            BuilderPatternDemo();
            //AbstractFactoryDemo();            
        }

        private static void BuilderPatternDemo()
        {
            AbstractMountainBike mountainBike = new
                Downhill(BikeColor.Green, new WideWheel(24));

            BikeBuilder builder = new MountainBikeBuilder(mountainBike);
            BikeDirector director = new MountainBikeDirector();
            IBicycle bicycle = director.Build(builder);
            Console.WriteLine(bicycle);
        }

        private static void AbstractFactoryDemo()  //has to be static to call from main
        {
            /*
             * Parent class object instance is careated by its child
             * class. this parent class can only see methods that it
             * created, that its child uses. Any child types created,
             * cannot be seen unless it was first created by the parent.
             */
            AbstractBikeFactory factory = new RoadBikeFactory();

            /*Create the bike parts
             Interface object is created. The factory objects created
             above calls the method that returns the interface that it
             is assinged to. These Create methods create a new object
             of a Frame or Seat. This object can be of either Road or
             Mountain. In this case the RoadFrame and RoadSeat.
             */

            /*
             * CreateBikeFrame method of factory object
             * @returns IBikeSeat to object bikeSeat
             */ 
            IBikeFrame bikeFrame = factory.CreateBikeFrame(); //"factory" is object, calling the method "CreateBikeFrame"

            /*
             * CreateBikeSeat method of factory object
             * @returns IBikeSeat to object bikeSeat
             */ 
            IBikeSeat bikeSeat = factory.CreateBikeSeat();

            /*Show what we created
             * 
             Interface object bikeFrame calls the property BikeFrameParts
             bikeFrame was created from the class RoadFrame
             The property BikeFrameParts uses the get to return
             the string value from RoadFrame
            */
            Console.WriteLine(bikeFrame.BikeFrameParts);

            /*
             * Interface object bikeSeat calls the preoppty BikeSeatParts
             * bikeSeat was created from the class RoadSeat
             * The property BikeSeatParts uses the get to return
             * the string value from RoadSeat
            */
            Console.WriteLine(bikeSeat.BikeSeatParts);
        }




    }
}
