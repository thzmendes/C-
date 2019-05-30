using System.Globalization;

namespace System
{
    internal static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisobj)
        {
            var duration = DateTime.Now - thisobj;

            if (duration.TotalHours < 12)
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " horas";
            return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " dias";
        }
    }
}