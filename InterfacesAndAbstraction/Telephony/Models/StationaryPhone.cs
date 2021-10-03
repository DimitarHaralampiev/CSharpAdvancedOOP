using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephony.Contracts;

namespace Telephony.Models
{
    public class StationaryPhone : IPhone
    {
        public string Call(string number)
        {
            if (!number.All(x => char.IsDigit(x)))
            {
                throw new ArgumentException("Invalid number!");
            }

            return $"Dialing... {number}";
        }
    }
}
