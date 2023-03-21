using System;

namespace EventSample
{
    public class MarketInspector : TransactionEvent
    {

        // (A) and (B)
        public void OnTransaction(Gadget gadget, string buyer)
        {
            Console.WriteLine("INSPECTOR is monitoring transaction: " + gadget.GetName() + " --> " + buyer);
        }

        // (C)
        public void GadgetOnTransaction(object sender, TransactionEventArgs eventArgs)
        {
            Gadget gadget = (Gadget)sender;
            Console.WriteLine("INSPECTOR is monitoring transaction: " + gadget.GetName() + " --> " + eventArgs.Buyer);
        }


    }
}
