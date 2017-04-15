using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading; //using

namespace BasciNetPro
{
    public class ThreadingUse
    {
        public static void ThreadProc()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc:{0}", i);
                Thread.Sleep(50);
            }
        }

        public void ThreadingUseExample()
        {
            Console.WriteLine("Main thread: Start a second thread.");
            Thread t = new Thread(new ThreadStart(ThreadProc));
            t.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(100);
            }
            Console.WriteLine("Main thread: Call Join(), to wait until ThreadProcends.");
            t.Join();
            Console.WriteLine("Main thread: ThreadProc.Join has returned. Press Enter to end program.");
            Console.ReadLine();
        }
    }
}
