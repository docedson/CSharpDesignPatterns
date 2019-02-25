using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class UltraWheel
    {
        private int _size;

        public int WheelSize
        {
            get { return _size; }
        }

        public UltraWheel(int size)
        {
            this._size = size;
        }

        public override string ToString()
        {
            return "ULTRAWHEEL" + _size;
        }

    }
}
