using System;

namespace DalesLab.Timespan.BestText
{
    public static class Best
    {
        /// <summary>
        /// Returns the best possible text output for the provided Timespan
        /// </summary>
        /// <param name="timespan">Current <see cref="TimeSpan"/></param>
        /// <returns><see cref="string"/> representation of the timespan</returns>
        public static string BestText(this TimeSpan timespan)
        {
            double ms = Math.Round(timespan.TotalMilliseconds);

            if (ms < 1000)
            {
                return $"{ms} milliseconds";
            } else if (ms == 1000)
            {
                return "1 second";
            } else if (ms > 1000 && ms < (60 * 1000)) // greater than a second but less than a minute
            {
                return $"{ms / 1000} seconds";
            } else if (ms == (60 * 1000))
            {
                return "1 minute";
            } else if (ms > (60 * 1000) && ms < (60 * 60 * 1000)) // greater than one minute but less than an hour
            {
                return $"{ms / (60 * 1000)} minutes";
            } else if (ms == (60 * 60 * 1000)) {
                return $"1 hour";
            } else if (ms > (60 * 60 * 1000) && ms < (24 * 60 * 60 * 1000)) { // greater than 1 hour but less than a day
                return $"{ms / (60 * 60 * 1000)} hours";
            } else if (ms == (24 * 60 * 60 * 1000)) {
                return "1 day";
            } else if (ms > (24 * 60 * 60 * 1000))
            {
                return $"{ms / (24 * 60 * 60 * 1000)} days";
            } else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
