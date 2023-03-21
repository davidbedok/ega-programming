using System.Collections.Generic;

namespace EventSample
{
    public class Gadget
    {

        private readonly string name;
        private int price;

        // (A) Simple event handler
        private TransactionEvent transactionEvent;

        // (A)
        public TransactionEvent TransactionEvent
        {
            set { this.transactionEvent = value; }
        }

        // (B) Multiple event handler
        private List<TransactionEvent> transactionEvents;

        // (C) C# solution
        public event TransactionEventHandler TransactionEventCS;

        public Gadget( string name, int price )
        {
            this.name = name;
            this.price = price;

            // (B)
            this.transactionEvents = new List<TransactionEvent>();
        }

        // (B)
        public void Subscribe(TransactionEvent transactionEvent) {
            this.transactionEvents.Add(transactionEvent);
        }

        // (B)
        public void Unsubscribe(TransactionEvent transactionEvent)
        {
            this.transactionEvents.Remove(transactionEvent);
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetPrice()
        {
            return this.price;
        }

        public string Buy( string buyer )
        {
            // (A)
            if ( this.transactionEvent != null )
            {
                this.transactionEvent.OnTransaction(this, buyer);
            }

            // (B)
            foreach ( TransactionEvent transactionEvent in this.transactionEvents )
            {
                transactionEvent.OnTransaction(this, buyer);
            }

            // (C)
            if (TransactionEventCS != null )
            {
                TransactionEventCS.Invoke(this, buyer);
            }

            return this.name + " is bought by " + buyer + " (price: "+ this.price+")";
        }
        

    }
}