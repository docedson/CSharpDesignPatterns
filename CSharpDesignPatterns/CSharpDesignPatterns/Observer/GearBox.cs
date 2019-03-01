using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class GearBox : ISpeedChanged
    {
        public GearBox(Speedometer speed)
        {
            speed.VChanged += ValueHasChanged;
        }

        public void ValueHasChanged(object sender, EventArgs args)
        {
            Speedometer mySpeedometer = (Speedometer)sender;
            if(mySpeedometer.CurrentSpeed <= 10)
            {
                Console.WriteLine("Now in easy gear.");
            } else if(mySpeedometer.CurrentSpeed <= 20)
            {
                Console.WriteLine("Now in second gear.");
            } else if(mySpeedometer.CurrentSpeed <= 25)
            {
                Console.WriteLine("Now in third gear.");
            } else if(mySpeedometer.CurrentSpeed <= 30)
            {
                Console.WriteLine("Now in fourth gear.");
            }

        }
    }
}
