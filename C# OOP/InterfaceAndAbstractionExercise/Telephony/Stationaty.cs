using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    class Stationaty : IStationary
    {
        public void Dail(string number)
        {
            Console.WriteLine($"Dialing... {number}");
        }
    }
}
