using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Quiz2
{
    class Program
    {
        //a) This phenomenon is called as deadlock.
        //c) The solution is by using AutoResetEvent class where it allow two threads interact each other by giving signal to another thread. This will prevent
        //   the threads lock each other while waiting for the first thread finishing their task.

        static object object1 = new object();
        static object object2 = new object();
        static AutoResetEvent signal = new AutoResetEvent(false);

        public static void FirstFunction()
        {
            lock (object1)
            {
                Thread.Sleep(1000);
                lock (object2)
                {
                    Console.WriteLine("FirstFunction gets Lock 2");
                    signal.Set();
                }

                Console.WriteLine("FirstFunction gets Lock 1");
            }
        }

        public static void SecondFunction()
        {
            lock (object2)
            {
                Thread.Sleep(1000);
                lock (object1)
                {
                    Console.WriteLine("SecondFunction gets Lock 1");
                }
                Console.WriteLine("SecondFunction gets Lock 2");
            }
        }

        static void Main(string[] args)
        {
            Thread thread1 = new Thread(FirstFunction);
            Thread thread2 = new Thread(SecondFunction);

            thread1.Start();
            signal.WaitOne();
            thread2.Start();

            Console.ReadLine();
        }
    }
}
