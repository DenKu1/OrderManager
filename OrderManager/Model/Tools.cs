using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Model
{    
    public static class TimeSpanExtension
    {
        /// <summary>
        /// Multiplies a timespan by an integer value
        /// </summary>
        public static TimeSpan Divide(this TimeSpan multiplicand, int multiplier)
        {
            return TimeSpan.FromTicks(multiplicand.Ticks / multiplier);
        }

        /// <summary>
        /// Multiplies a timespan by a double value
        /// </summary>
        public static TimeSpan Divide(this TimeSpan multiplicand, double multiplier)
        {
            return TimeSpan.FromTicks((long)(multiplicand.Ticks / multiplier));
        }        
    
    }
}
