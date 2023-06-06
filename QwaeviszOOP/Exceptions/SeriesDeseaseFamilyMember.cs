using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class SeriesDeseaseFamilyMember : Exception
    {

        private int montlyBaseFee;

        public int MonthlyBaseFee
        {
            get { return this.montlyBaseFee; }
        }

        public SeriesDeseaseFamilyMember(int montlyBaseFee): this(montlyBaseFee, "")
        {
        }

        public SeriesDeseaseFamilyMember(int montlyBaseFee, string message)
            : this(montlyBaseFee, message, null)
        {
        }

        public SeriesDeseaseFamilyMember(int montlyBaseFee, string message, Exception inner)
            : base(message, inner)
        {
            this.montlyBaseFee = montlyBaseFee;
        }

    }
}
