using System;

namespace OrderManager.Model
{    
    public static class TimeSpanExtension
    {
        public static TimeSpan Divide(this TimeSpan multiplicand, int multiplier)
        {
            return TimeSpan.FromTicks(multiplicand.Ticks / multiplier);
        }

        public static TimeSpan Divide(this TimeSpan multiplicand, double multiplier)
        {
            return TimeSpan.FromTicks((long)(multiplicand.Ticks / multiplier));
        }        
    
    }
}
