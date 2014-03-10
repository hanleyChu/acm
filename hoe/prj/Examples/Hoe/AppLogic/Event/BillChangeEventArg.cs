using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hoe.Basic.Model;

namespace Hoe.Basic.AppLogic.Event
{
    public class BillChangeEventArg : ModelChangeEventArg
    {
        public BillChangeEventArg(Bill changedBill, int changingType)
        {
            this.ChangedBill = changedBill;
            this.ChangingType = changingType;
        }

        public Bill ChangedBill{set;get;}
    }
}
