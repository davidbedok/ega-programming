using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Tiger : Animal, Defensable, Attackable
    {

        private string name;
        private string nickName;

        public Tiger( int code, string name ): base(code)
        {
            this.name = name;
            Console.WriteLine("Tiger ctor(code, name): " + this.name);
        }

        public Tiger(int code, string name, string nickName ) : this(code, name)
        {
            this.nickName = nickName;
            Console.WriteLine("Tiger ctor(code, name, nickName): " + this.nickName);
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void Defense()
        {
            throw new NotImplementedException();
        }

        public void DieHard()
        {
            throw new NotImplementedException();
        }

        public override string Feed()
        {
            throw new NotImplementedException();
        }

    }
}
