using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SerialNumberGenerator
    {
        /*private - Access modifier that restricts access to the classs only
        static - No instances of this variable are created. It is only 1
        volatile - May be modified by multiple threads that are executing at the same time*/


        //Below is a class object of itself (SerialNumberGenerator)
        private static volatile SerialNumberGenerator instance;
        //object - Root of all objects in .Net. Can be anything (string, bool, etc)
        private static object synchronizationRoot = new object();

        private int _count = 12345;

        //property of the calss SerialNumberGenerator that is read-only
        public static SerialNumberGenerator Instance
        {
            get
            {
                if(instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if(instance == null)
                        {
                            instance = new SerialNumberGenerator();
                        }
                    }
                }
                return instance;
            }
        }
        private SerialNumberGenerator() { }

        public int NextSerial
        {
            get { return ++_count; }
        }

    }
}
