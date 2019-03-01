using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;
using Builder;
using Singleton;
using Adapter;
using Decorator;
using Facade;
using Iterator;
using System.Collections;
using Observer;

namespace CSharpDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ObserverPatternDemo();
            //IteratorPatternDemo2();
            //IteratorPatternDemo();
            //FacadePatternDemo();
            //DecoratorPatternDemo();
            //AdapterPatternDemo();
            //SingletonPatternDemo();
            //BuilderPatternDemo();
            //AbstractFactoryDemo();            
        }

        private static void ObserverPatternDemo()
        {
            Speedometer mySpeedometer = new Speedometer();
            SpeedMonitor monitor = new SpeedMonitor(mySpeedometer);
            GearBox gearbox = new GearBox(mySpeedometer);

            //Set current speed property to a value
            mySpeedometer.CurrentSpeed = 10;
            mySpeedometer.CurrentSpeed = 20;
            mySpeedometer.CurrentSpeed = 25;
            mySpeedometer.CurrentSpeed = 30;
            mySpeedometer.CurrentSpeed = 35;
        }

        private static void IteratorPatternDemo2()
        {   //Same as IteratorPatternDemo, but this is probably preferred
            Console.WriteLine("=== Road Bikes ===");
            RoadBikeRange roadRange = new RoadBikeRange();
            foreach (IBicycle bicycle in roadRange.Range)
            {
                Console.WriteLine(bicycle);
            }

            Console.WriteLine("=== Mountain Bikes ===");
            MountainBikeRange mountainRange = new MountainBikeRange();
            foreach (IBicycle bicycle in mountainRange.Range)
            {
                Console.WriteLine(bicycle);
            }

        }

        private static void IteratorPatternDemo()
        {
            Console.WriteLine("=== Road Bikes ===");
            RoadBikeRange roadRange = new RoadBikeRange();
            PrintIterator(roadRange.GetEnumerator());

            Console.WriteLine("=== Mountain Bikes ===");
            MountainBikeRange mountainRange = new MountainBikeRange();
            PrintIterator(mountainRange.GetEnumerator());
        }

        private static void PrintIterator(IEnumerator iter)
        {
            while (iter.MoveNext())
            {
                Console.WriteLine(iter.Current);
            }
        }

        //Facade Design Pattern Method
        private static void FacadePatternDemo()
        {
            BikeFacade facade = new BikeFacade();
            facade.PrepareForSale(new Downhill(BikeColor.Red, new WideWheel(20)));
        }

        private static void DecoratorPatternDemo()
        {
            //Standard Touring Bike taht displays their result to the console
            IBicycle myTourbike = new Touring(new NarrowWheel(24));
            Console.WriteLine(myTourbike);

            //Touring bike with custom grips added to the total price and their result is 
            myTourbike = new CustomGripOption(myTourbike);
            Console.WriteLine(myTourbike);

            //Touring bike with leather seat
            myTourbike = new LeatherSeatOption(myTourbike);
            Console.WriteLine(myTourbike);
        }

        private static void AdapterPatternDemo()
        {
            IList<IWheel> wheels = new List<IWheel>();
            wheels.Add(new NarrowWheel(24));
            wheels.Add(new WideWheel(20));
            wheels.Add(new NarrowWheel(26));
            wheels.Add(new UltraWheelAdapter(new UltraWheel(28)));

            foreach (IWheel wheel in wheels)
            {
                Console.WriteLine(wheel);
            }
        }

        private static void SingletonPatternDemo()
        {
            SerialNumberGenerator generator = SerialNumberGenerator.Instance;
            //You need the above line to use the below line
            Console.WriteLine("Next serial "+ generator.NextSerial);
            //Above and below do same thing, just different ways to type it - but Sr. Dev would probably say to use below
            Console.WriteLine("Next serial "+ SerialNumberGenerator.Instance.NextSerial);//this combines above 2 lines into 1
            Console.WriteLine("Next serial "+ generator.NextSerial);
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
