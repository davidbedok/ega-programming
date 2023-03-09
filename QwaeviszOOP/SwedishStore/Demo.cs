using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace SwedishStore
{
    public class Demo
    {

        public int Height; // !!!!

        private int length;
        private Room room;

        public int Length {
            get { return this.length; }
            set {
                if (length > 0)
                {
                    this.length = value;
                }
            }
        }

        public Room Room
        {
            get { return this.room; }
            set { this.room = value; }
        }

        public int GetLength()
        {
            return this.length;
        }

        public void SetLength( int value)
        {
            if (length > 0)
            {
                this.length = value;
            }
        }

        public Room GetRoom()
        {
            return this.room;
        }

        public void SetRoom( Room value )
        {
            this.room = value;
        }


    }
}
