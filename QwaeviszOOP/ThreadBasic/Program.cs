using System;
using System.Threading;

namespace ThreadBasic
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CustomWorkerThread worker1 = new CustomWorkerThread("Lorem");
            CustomWorkerThread worker2 = new CustomWorkerThread("Ipsum");
            worker2.Callback = new ThreadCallback(Program.MainCallbackEventHandler);

            Thread t1 = new Thread(new ThreadStart(worker1.Run));
            Thread t2 = new Thread(new ParameterizedThreadStart(worker2.RunWithArgument));

            t1.IsBackground = true;
            t2.IsBackground = true;

            t1.Start();
            t2.Start(new ThreadParam(1500));

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work.." + i);
                Thread.Sleep(2000);
            }

            t1.Join();
            t2.Join();

        }

        public static void MainCallbackEventHandler(string message)
        {
            Console.WriteLine(message);
        }

    }
}
