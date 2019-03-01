using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Speedometer
    {
        public event EventHandler VChanged;

        private int _currentSpeed;

        public int CurrentSpeed
        {
            set
            {
                this._currentSpeed = value;
                OnValueChanged();
            }
            get
            {
                return _currentSpeed;
            }
        }

        public Speedometer() { _currentSpeed = 0; }

        protected void OnValueChanged()
        {
            if(VChanged != null)
            {
                VChanged(this, EventArgs.Empty);
            }
        }
    }
}
