using System;
using System.Collections.Generic;
using System.Text;

namespace StaticKeyword
{
    public class PersonConfig
    {

        private int factorA;
        private string factorB;

        private PersonConfig()
        {

        }

        public int GetFactorA()
        {
            return this.factorA;
        }

        public void SetFactorA( int factor ) {
            this.factorA = factor;
        }

        public string GetFactorB()
        {
            return this.factorB;
        }

        public void SetFactorB(string factor)
        {
            this.factorB = factor;
        }

        private static PersonConfig instance = null;

        public static PersonConfig GetInstance()
        {
            if ( instance == null )
            {
                instance = new PersonConfig();
            }
            return instance;
        }

    }
}
