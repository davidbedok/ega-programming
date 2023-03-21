using System;

namespace EventSample
{
    public class MarketInspector : TransactionEvent
    {

        public void OnTransaction(Gadget gadget, string buyer)
        {
            Console.WriteLine("INSPECTOR is monitoring transaction: " + gadget.GetName() + " --> " + buyer);
        }

    }
}
