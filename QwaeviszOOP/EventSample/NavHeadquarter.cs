using System;
using System.Collections.Generic;
using System.Text;

namespace EventSample
{
    public class NavHeadquarter
    {

        private readonly string name;
        private TransactionEventHandler transactionEventHandler;

        public NavHeadquarter( string name )
        {
            this.name = name;
            this.transactionEventHandler = new TransactionEventHandler(this);
        }

        public string GetName()
        {
            return this.name;
        }

        public TransactionEventHandler GetTransactionEventHandler()
        {
            return this.transactionEventHandler;
        }

    }
}
