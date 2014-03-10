using System;
using System.Collections.Generic;
using System.Text;
using MVCSharp.Core;
using MVCSharp.Core.Tasks;
using MVCSharp.Core.Views;
using Hoe.Basic.AppLogic;
using Hoe.Basic.View;
using Hoe.Basic.Model;
using Hoe.Basic.AppLogic.Event;
using System.Windows.Forms;
using System.Linq;

namespace Hoe.Basic.Controller
{
    public class ProductController : ControllerBase
    {
        public override ITask Task
        {
            get { return base.Task; }
            set
            {
                base.Task = value;
            }
        }

        public override IView View
        {
            get {return base.View; }
            set
            {
                base.View = value;
            }
        }

        public void NewProduct(Product product)
        {

            List<Product> specificProduct = (from p in (Task as ProductTask).SalesTask.Products
                                             where p.Equals(product)
                                             select p).ToList();

            if (specificProduct.Count > 0)
            {
                MessageBox.Show("已经存在这个货物啦");
                return;
            }

            SaleTask task = (Task as ProductTask).SalesTask;
            task.Products.Add(product);
            task.TriggerRepoProductsChanged(this, new ProductChangeEventArg(product, ModelChangeEventArg.INSERT));
        }
        
    }
}
