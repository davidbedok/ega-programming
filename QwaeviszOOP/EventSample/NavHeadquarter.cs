using System;

namespace EventSample
{
    public class NavHeadquarter : TransactionEvent
    {

        private readonly string name;
        
        public NavHeadquarter( string name )
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        // (A) and (B)
        public void OnTransaction(Gadget gadget, string buyer)
        {
            Console.WriteLine("NAV (" + this.name + ") is monitoring transaction: " + gadget.GetName() + " --> " + buyer);
        }

        // (C)
        public void GadgetOnTransaction(object sender, TransactionEventArgs eventArgs)
        {
            Gadget gadget = (Gadget)sender;
            Console.WriteLine("NAV (" + this.name + ") is monitoring transaction: " + gadget.GetName() + " --> " + eventArgs.Buyer);
        }

    }
}
