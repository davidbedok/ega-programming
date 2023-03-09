using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace EventSample
{
    public class Market
    {

        private NavHeadquarter navHQ;
        private List<Gadget> gadgets;

        public Market()
        {
            this.gadgets = new List<Gadget>();
            this.navHQ = new NavHeadquarter("Budapest");
        }

        public void AddGadget( Gadget gadget )
        {
            gadget.SetTransactionEvent(this.navHQ.GetTransactionEventHandler());
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
