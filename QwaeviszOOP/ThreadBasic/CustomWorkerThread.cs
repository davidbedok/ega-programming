using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadBasic
{
    public class CustomWorkerThread
    {

        private string threadName;

        private ThreadCallback callback;

        public ThreadCallback Callback
        {
            set { this.callback = value; }
        }

        public CustomWorkerThread( string threadName )
        {
            this.threadName = threadName;
        }

        public void Run()
        {
            Console.WriteLine("BEGIN Run()..");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(this.threadName +": " + i);
                Thread.Sleep(1000);
                if (callback != null)
                {
                    this.callback.Invoke("Hello from " + this.threadName + ": " + i);
                }
            }
            Console.WriteLine("END Run()..");
        }

        public void RunWithArgument(object argument)
        {
            Console.WriteLine("BEGIN RunWithArgument()..");
            ThreadParam param = (ThreadParam)argument;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(this.threadName + ": " + i);
                Thread.Sleep(param.SleepMillis);
                if (callback != null)
                {
                    this.callback.Invoke("Hello from " + this.threadName + ": " + i);
                }
            }
            Console.WriteLine("END RunWithArgument()..");
        }

    }
}
