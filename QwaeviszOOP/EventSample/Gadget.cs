namespace EventSample
{
    public class Gadget
    {

        private readonly string name;
        private int price;
        private TransactionEvent transactionEvent;

        public Gadget( string name, int price )
        {
            this.name = name;
            this.price = price;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetPrice()
        {
            return this.price;
        }

        public void SetTransactionEvent( TransactionEvent transactionEvent )
        {
            this.transactionEvent = transactionEvent;
        }

        public string Buy( string buyer )
        {
            if ( this.transactionEvent != null )
            {
                this.transactionEvent.Fire(this, buyer);
            } 
            return this.name + " is bought by " + buyer + " (price: "+ this.price+")";
        }
        

    }
}