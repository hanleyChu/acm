using System;
using System.Collections.Generic;
using System.Text;
using MVCSharp.Core.Configuration.Tasks;
using MVCSharp.Core.Tasks;
using Hoe.Basic.Controller;
using Hoe.Basic.Model;

namespace Hoe.Basic.AppLogic
{
    public class BillTask : TaskBase
    {
        public SaleTask SalesTask;

        [InteractionPoint(typeof(BillController))]
        public const string BillView = "Bill";

        public override void OnStart(object param)
        {
            SalesTask = param as SaleTask;

            Navigator.NavigateDirectly(BillView);
        }
    }
}
