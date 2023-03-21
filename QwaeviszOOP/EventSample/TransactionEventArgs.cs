using System;
using System.Collections.Generic;
using System.Text;

namespace EventSample
{
    public class TransactionEventArgs
    {

        private string buyer;

        public TransactionEventArgs(string buyer)
        {
            this.buyer = buyer;
        }   

        public string Buyer
        {
            get { return this.buyer; }
        }

    }
}
