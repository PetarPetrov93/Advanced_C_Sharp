using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    static class DateModifier
    {
        public static int DaysDifference(DateTime date1, DateTime date2)
        {
            return Math.Abs((int)(date1 - date2).TotalDays);
        }
    }
}
