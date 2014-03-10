using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hoe.Basic.Model;

namespace Hoe.Basic.AppLogic.Event
{
    public class ProductChangeEventArg : ModelChangeEventArg
    {
        public ProductChangeEventArg(Product changedProduct, int changingType)
        {
            this.ChangedProduct = changedProduct;
            this.ChangingType = changingType;
        }

        public Product ChangedProduct{set;get;}
    }
}
