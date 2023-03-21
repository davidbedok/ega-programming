using System;
using System.Collections.Generic;

namespace EventSample
{
    public class Market
    {

        private NavHeadquarter nav;
        private MarketInspector inspector;

        private List<Gadget> gadgets;

        public Market()
        {
            this.gadgets = new List<Gadget>();
            this.nav = new NavHeadquarter("Budapest");
            this.inspector = new MarketInspector();
        }

        public void AddGadget( Gadget gadget )
        {
            // (A) Simple event handler
            // gadget.TransactionEvent = this.nav;
            // // gadget.TransactionEvent = null; --> unsubscribe

            // (B) Multiple event handler
            // gadget.Subscribe(this.nav);
            // gadget.Subscribe(this.inspector);
            // // gadget.Unsubscribe(this.nav); --> unsubscribe

            // (C) C# solution
            gadget.TransactionEventCS += this.nav.OnTransaction;
            gadget.TransactionEventCS += this.inspector.OnTransaction;
            // // gadget.TransactionEventCS -= this.nav.GadgetOnTransaction; --> unsubscribe

            this.gadgets.Add(gadget);
        }

        public string Buy( string gadgetName, string buyer )
        {
            string result = "";
            Gadget gadget = this.Find(gadgetName);
            if ( gadget != null )
            {
                result = gadget.Buy(buyer);
            } else
            {
                result = "Gadget does not exist. Name: " + gadgetName;
            }
            return result;
        }

        private Gadget Find( string gadgetName )
        {
            Gadget result = null;
            foreach ( Gadget g in this.gadgets )
            {
                if ( g.GetName().Equals(gadgetName, StringComparison.OrdinalIgnoreCase) )
                {
                    result = g;
                    break;
                }
            }
            return result;
        }


    }
}
