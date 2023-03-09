using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace EventSample
{
    public class TransactionEventHandler : TransactionEvent
    {

        private NavHeadquarter nav;

        public TransactionEventHandler(NavHeadquarter nav )
        {
            this.nav = nav;
        } 

        public void Fire(Gadget gadget, string buyer)
        {
            Console.WriteLine("NAV (" + this.nav.GetName() + ") is monitoring transaction: " + gadget.GetName() + " --> " + buyer);
        }

    }
}
