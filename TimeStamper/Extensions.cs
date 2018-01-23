using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeStamper
{
    public static class Extensions
    {
        public static DateTime ChangeDate(this DateTime date, int hour, int minutes, int seconds = 0)
        {
            return new DateTime(date.Year, date.Month, date.Day, hour, minutes, seconds); //, DateTimeKind.Local
        }
    }
}
