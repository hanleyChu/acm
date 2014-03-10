using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hoe.Basic.AppLogic.Event
{
    public class ModelChangeEventArg:EventArgs
    {
        public const int REMOVE = 0;
        public const int UPDATE = 1;
        public const int INSERT = 2;
        public const int SELECT = 3;

        public int ChangingType { set; get; }
    }
}
