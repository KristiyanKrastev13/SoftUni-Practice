using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {
        public string DateOne { get; set; }

        public string  DateTwo { get; set; }


        public static int TimeDifferenceCalculator(string dateOne, string dateTwo )
        {
            DateTime first = DateTime.Parse(dateOne);
            DateTime second = DateTime.Parse(dateTwo);
            TimeSpan result = first - second;


            return Math.Abs(result.Days);
        }
    }
}
