using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class RoadSeat : IBikeSeat
    {
        public string BikeSeatParts
        {
            get { return "Seat parts for Road Bike"; }
        }
    }
}
