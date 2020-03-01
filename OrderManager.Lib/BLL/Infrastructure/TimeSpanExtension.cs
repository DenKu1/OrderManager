using System;

namespace OrderManager.Lib.BLL.Infrastructure
{
    public static class TimeSpanExtension
    {
        /// <summary>
        /// Multiplies a timespan by an integer value
        /// </summary>
        public static TimeSpan Multiply(this TimeSpan multiplicand, int multiplier)
        {
            return TimeSpan.FromTicks(multiplicand.Ticks * multiplier);
        }

        /// <summary>
        /// Multiplies a timespan by a double value
        /// </summary>
        public static TimeSpan Multiply(this TimeSpan multiplicand, double multiplier)
        {
            return TimeSpan.FromTicks((long)(multiplicand.Ticks * multiplier));
        }

        /// <summary>
        /// Divides a timespan by an integer value
        /// </summary>
        public static TimeSpan Divide(this TimeSpan v1, int v2)
        {
            return TimeSpan.FromTicks(v1.Ticks / v2);
        }

        /// <summary>
        /// Divides a timespan by a double value
        /// </summary>
        public static TimeSpan Divide(this TimeSpan v1, double v2)
        {
            return TimeSpan.FromTicks((long)(v1.Ticks / v2));
        }
    }
}
