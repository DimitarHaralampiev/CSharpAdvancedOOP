using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {

        public int CalculateDate(string date1, string date2)
        {
            var dateArr1 = date1
                .Split()
                .Select(int.Parse)
                .ToArray();

            DateTime dateTime1 = new DateTime(dateArr1[0], dateArr1[1], dateArr1[2]);

            var dateArr2 = date2
                .Split()
                .Select(int.Parse)
                .ToArray();

            DateTime dateTime2 = new DateTime(dateArr2[0], dateArr2[1], dateArr2[2]);

            return Math.Abs((dateTime1 - dateTime2).Days);
        }
    }
}
