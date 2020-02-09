using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Model
{
    public static class Clock
    {
        private static DateTime _current;

        public static DateTime Current
        {
            get
            {
                return _current;
            }
            set
            {
                if (value <= _current)
                    throw new Exception("New value must be bigger then previous;");

                _current = value;
            }
        }

        static Clock()
        {
            _current = DateTime.Now;
        }
    }

}
