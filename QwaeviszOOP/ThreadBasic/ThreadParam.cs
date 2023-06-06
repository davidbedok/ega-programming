using System;
using System.Collections.Generic;
using System.Text;

namespace ThreadBasic
{
    public class ThreadParam
    {

        private readonly int sleepMillis;
        
        public int SleepMillis
        {
            get { return this.sleepMillis; }
        }

        public ThreadParam(int sleepMillis)
        {
            this.sleepMillis = sleepMillis;
        }

    }
}
