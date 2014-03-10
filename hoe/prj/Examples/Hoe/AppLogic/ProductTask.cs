using System;
using System.Collections.Generic;
using System.Text;
using MVCSharp.Core.Configuration.Tasks;
using MVCSharp.Core.Tasks;
using Hoe.Basic.Controller;
using Hoe.Basic.Model;

namespace Hoe.Basic.AppLogic
{
    public class ProductTask : TaskBase
    {
        public SaleTask SalesTask;

        [InteractionPoint(typeof(ProductController))]
        public const string ProductView = "Product";

        public override void OnStart(object param)
        {
            SalesTask = param as SaleTask;

            Navigator.NavigateDirectly(ProductView);
        }
    }
}
