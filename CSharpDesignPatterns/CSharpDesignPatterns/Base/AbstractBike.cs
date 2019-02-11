using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns
{
    public class AbstractBike : IBicycle
    {
        private BikeColor _color;
        private IWheel _wheel;

        public BikeColor ColorType
        {
            get
            {
                return _color;
            }
        }

        public IWheel GetWheel
        {
            get
            {
                return _wheel;
            }
        }

        public AbstractBike(BikeColor color, IWheel wheel)
        {
            this._wheel = wheel;
            this._color = color;
        }

        public virtual void Paint(BikeColor color)
        {
            this._color = color;
        }

        public override string ToString()
        {
            return this.GetType().Name + " Bicycle Color is " + _color;
        }

    }
}
