using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Iterator
{
    public class RoadBikeRange
    {
        private IList<IBicycle> _bicycles;

        public virtual IList<IBicycle> Range
        { get { return _bicycles; } }

        public RoadBikeRange()
        {
            _bicycles = new List<IBicycle>();
            //define the range of models
            _bicycles.Add(new Touring(new NarrowWheel(24)));
            _bicycles.Add(new Touring(BikeColor.Blue, new NarrowWheel(22)));
            _bicycles.Add(new Touring(BikeColor.Green, new NarrowWheel(26)));
            _bicycles.Add(new Vintage(new NarrowWheel(24)));
            _bicycles.Add(new Vintage(BikeColor.Red, new NarrowWheel(22)));
        }

        public virtual IEnumerator<IBicycle> GetEnumerator()
        {
            return ((IEnumerable<IBicycle>)_bicycles).GetEnumerator();
        }
    }
}
