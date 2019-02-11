using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns
{
    public abstract class AbstractWheel : IWheel
    {
        private int _size;
        private bool _isWide;

        public int Size
        {
            get
            {
                return _size;
            }
        }
        public bool IsWide
        {
            get
            {
                return _isWide;
            }
        }

        public AbstractWheel(int size, bool isWide)
        {
            this._size = size;
            this._isWide = isWide;
        }
    }
}
