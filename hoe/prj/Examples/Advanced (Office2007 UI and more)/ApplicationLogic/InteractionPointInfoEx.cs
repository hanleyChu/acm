using System;
using System.Collections.Generic;
using System.Text;
using MVCSharp.Core.Configuration.Tasks;

namespace MVCSharp.Examples.AdvancedCustomization.ApplicationLogic
{
    public class InteractionPointInfoEx : InteractionPointInfo
    {
        private ViewCategory viewCat;

        public ViewCategory ViewCategory
        {
            get { return viewCat; }
            set { viewCat = value; }
        }
    }
}
