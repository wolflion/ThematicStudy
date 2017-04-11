using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// network
using System.Net;
using System.Net.NetworkInformation;

namespace BasciNetPro
{
    public class PingUse
    {
        public void PingUseExample()
        {
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();
            options.DontFragment = true;

            // data要发送的数据
            string data = "aaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 120;
            // ping的地址
            PingReply reply = pingSender.Send("222.195.149.106", timeout, buffer, options);
            if (reply.Status == IPStatus.Success)
            {
                Console.WriteLine("Address: {0}", reply.Address.ToString());
                Console.WriteLine("RoundTrip time: {0}", reply.RoundtripTime);
                Console.WriteLine("Time to live: {0}", reply.Options.Ttl);
                Console.WriteLine("Don't fragment: {0}", reply.Options.DontFragment);
                Console.WriteLine("Buffer size: {0}", reply.Buffer.Length);
            }
            else
                Console.WriteLine("目标主机Ping失败");
            Console.ReadLine();
        }
    }
}
