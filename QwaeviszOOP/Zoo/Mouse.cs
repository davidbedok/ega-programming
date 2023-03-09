using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Mouse : Animal, Attackable
    {
        public Mouse(int code) : base(code)
        {
        }

        public override string Feed()
        {
            throw new NotImplementedException();
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void DieHard()
        {
            throw new NotImplementedException();
        }
    }
}
