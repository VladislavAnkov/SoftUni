using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {
        public static int GetDiffBetweenDates(string firstDate, string secondDate)
        {
            DateTime firstDateTime = DateTime.Parse(firstDate);
            DateTime secondDateTime = DateTime.Parse(secondDate);

            TimeSpan difference = firstDateTime - secondDateTime;

            return Math.Abs(difference.Days);
        }
    }
}
