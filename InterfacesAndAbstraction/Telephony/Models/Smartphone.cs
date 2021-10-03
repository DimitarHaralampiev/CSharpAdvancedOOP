using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephony.Contracts;

namespace Telephony.Models
{
    public class Smartphone : IPhone, IBrowsable
    {
        public string Call(string number)
        {
            if (!number.All(x => char.IsDigit(x)))
            {
                throw new ArgumentException("Invalid number!");
            }

            return $"Calling... {number}";
        }

        public string WebSite(string site)
        {
            if (site.Any( x => char.IsDigit(x)))
            {
                throw new ArgumentException("Invalid URL!");
            }

            return $"Browsing: {site}!";
        }
    }
}
