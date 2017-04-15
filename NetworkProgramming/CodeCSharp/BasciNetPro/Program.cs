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
            EncoderUse eu = new EncoderUse();
            ThreadingUse tu = new ThreadingUse();
            iepu.IPEndPointExample();
            pu.PingUseExample();
            eu.EncoderUseExample();
            tu.ThreadingUseExample();
        }
    }
}
