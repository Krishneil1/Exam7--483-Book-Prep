using System;
using System.Threading;

namespace Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();
            for(int i= 0; i <4; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(0);
            }
            t.Join();
            Console.WriteLine("Press any key to Exit!");
            Console.ReadKey();
        }
        public static void ThreadMethod()
        {
            for(int i = 0; i < 10;i ++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }
    }
}
/*
 * Foreground threads can be used to keep an application alive. Only when all foreground threads end does the 
 * common language runtime (CLR) shut down your application. Background threads are then terminated.
*/
