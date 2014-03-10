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
    public class BillController : ControllerBase
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

        public void NewBill(Bill bill)
        {

            List<Bill> specificBill = (from b in (Task as BillTask).SalesTask.Bills
                                             where b.Equals(bill)
                                             select b).ToList();

            if (specificBill.Count > 0)
            {
                MessageBox.Show("已经存在这个订单啦");
                return;
            }

            SaleTask task = (Task as BillTask).SalesTask;
            task.Bills.Add(bill);
            task.TriggerBillsChanged(this, new BillChangeEventArg(bill, ModelChangeEventArg.INSERT));
        }
        
    }
}
