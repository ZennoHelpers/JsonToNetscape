using System;

namespace JsonToNetscape
{
    public class TimeUtils
    {
        protected static readonly DateTime UtcLinuxStartEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static DateTime FromSecondsSinceEpoch(double time)
        {
            return UtcLinuxStartEpoch.AddSeconds(time).ToLocalTime();
        }

        public static double ToSecondsSinceEpoch(DateTime time)
        {
            return (time.ToUniversalTime() - UtcLinuxStartEpoch).TotalSeconds;
        }
    }
}
