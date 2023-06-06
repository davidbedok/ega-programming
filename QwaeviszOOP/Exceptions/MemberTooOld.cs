using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class MemberTooOld : SeriesDeseaseFamilyMember
    {

        public MemberTooOld(int montlyBaseFee) : base(montlyBaseFee)
        {
        }

        public MemberTooOld(int montlyBaseFee, string message)
            : base(montlyBaseFee, message)
        {
        }

        public MemberTooOld(int montlyBaseFee, string message, Exception inner)
            : base(montlyBaseFee, message, inner)
        {
            
        }

    }
}
