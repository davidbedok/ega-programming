using System;
using System.Collections.Generic;
using System.Text;

namespace EventSample
{
    public interface TransactionEvent
    {

        void Fire(Gadget gadget, string buyer);

    }
}
