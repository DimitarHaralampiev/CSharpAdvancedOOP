using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Contracts
{
    public interface IPhone
    {
        public string Call(string phoneNumber);
    }
}
