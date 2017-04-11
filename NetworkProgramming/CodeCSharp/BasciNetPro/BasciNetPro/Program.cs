using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasciNetPro
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPointUse iepu = new IPEndPointUse();
            PingUse pu = new PingUse();
            iepu.IPEndPointExample();
            pu.PingUseExample();
        }
    }
}
