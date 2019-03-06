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
using Visitor;

namespace CSharpDesignPatterns
{
    //Program Etnry point of the application
    class Program
    {        
        static void Main(string[] args)
        {
            VisitorPatternDemo();
            //ObserverPatternDemo();
            //IteratorPatternDemo2();
            //IteratorPatternDemo();
            //FacadePatternDemo();
            //DecoratorPatternDemo();
            //AdapterPatternDemo();
            //SingletonPatternDemo();
            //BuilderPatternDemo();
            //AbstractFactoryDemo();            
        }

        private static void VisitorPatternDemo()
        {
            IWheel wheel = new NarrowWheel(24);
            wheel.AcceptVisitor(new WheelDiagnostics());
            wheel.AcceptVisitor(new WheelInventory());
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

        //Decorator Design Pattern Method
        private static void DecoratorPatternDemo()
        {
            //Standard Touring Bike taht displays their result to the console
            IBicycle myTourbike = new Touring(new NarrowWheel(24));
            Console.WriteLine(myTourbike);

            //Touring bike with custom grips added to the total price and their result is printed to the console
            myTourbike = new CustomGripOption(myTourbike);
            Console.WriteLine(myTourbike);

            //Touring bike with leather seat added to the existing total and their result is printed to the console
            myTourbike = new LeatherSeatOption(myTourbike);
            Console.WriteLine(myTourbike);
        }

        //Adapter Design Pattern Demo Method

        private static void AdapterPatternDemo()
        {
            /*Collection instance of IList that gets created from the generic List.
             * Adds in 3 base objects and 1 simulated 3rd party object*/
            IList<IWheel> wheels = new List<IWheel>();
            wheels.Add(new NarrowWheel(24));
            wheels.Add(new WideWheel(20));
            wheels.Add(new NarrowWheel(26));
            wheels.Add(new UltraWheelAdapter(new UltraWheel(28)));

            //Iterates through the list and pritns the results to the console

            foreach (IWheel wheel in wheels)
            {
                Console.WriteLine(wheel);
            }
        }

        //Singleton Design Pattern Demo Method
        private static void SingletonPatternDemo()
        {

            /*Object instance of SerialNumberGenerator is created and is assigned an instance.
             * This instance either returns an existing one or creates a new one in its class*/

            SerialNumberGenerator generator = SerialNumberGenerator.Instance;
            //You need the above line to use the below line

            //Print out the serial numbers to the console
            Console.WriteLine("Next serial "+ generator.NextSerial);
            //Above and below do same thing, just different ways to type it - but Sr. Dev would probably say to use below
            Console.WriteLine("Next serial "+ SerialNumberGenerator.Instance.NextSerial);//this combines above 2 lines into 1
            Console.WriteLine("Next serial "+ generator.NextSerial);
        }

        //Builder Design Pattern Demo Method
        private static void BuilderPatternDemo()
        {
            /*Object instance of AbstractMountainBike created using its child class Downhill.
             * Its constructor takes 2 arguments*/
            AbstractMountainBike mountainBike = new
                Downhill(BikeColor.Green, new WideWheel(24));

            /*Both BikeBuilder and BikeDirector object instances are created.
             * Build passes the object above into its constructor*/
            BikeBuilder builder = new MountainBikeBuilder(mountainBike);
            BikeDirector director = new MountainBikeDirector();

            /*Interface object of IBicycle is assigned the value of the Build method called from the
             * BikeDirector object above. Its output is displayed on the console*/
            IBicycle bicycle = director.Build(builder);
            Console.WriteLine(bicycle);
        }

        //Abstract Factory Design Pattern Demo Method
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
