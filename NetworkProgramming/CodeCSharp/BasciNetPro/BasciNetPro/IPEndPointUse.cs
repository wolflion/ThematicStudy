using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;  // using

namespace BasciNetPro
{
    public class IPEndPointUse
    {

        public void IPEndPointExample()
        {
             // 获取本机局域网所有IP地址
             IPAddress[] addr = Dns.GetHostByName(Dns.GetHostName()).AddressList;
            //IPAddress[] addr = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
            foreach (IPAddress ip in addr)  // 不能直接写在类里?
                Console.WriteLine("本机IP地址为：" + ip.ToString());
            // 获得本机主机名
            Console.WriteLine("本机主机名为：" + Dns.GetHostEntry(addr[0]).HostName);
            // 创建本地端口
            IPAddress localIp = IPAddress.Parse("127.0.0.1");
            IPEndPoint iep = new IPEndPoint(localIp, 80);
            Console.WriteLine("IP端点：" + iep.ToString());
            Console.WriteLine("IP端口：" + iep.Port);
            Console.WriteLine("IP地址族：" + iep.AddressFamily);
            Console.WriteLine("可分配端口最大值：" + IPEndPoint.MaxPort);
            Console.WriteLine("可分配端口最小值：" + IPEndPoint.MinPort);
            //Console.ReadLine();
        }
    }
}
