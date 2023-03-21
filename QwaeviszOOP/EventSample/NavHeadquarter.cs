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

        public void OnTransaction(Gadget gadget, string buyer)
        {
            Console.WriteLine("NAV (" + this.name + ") is monitoring transaction: " + gadget.GetName() + " --> " + buyer);
        }

    }
}
