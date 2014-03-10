using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MVCSharp.Core;
using MVCSharp.Core.Tasks;
using MVCSharp.Core.Views;
using Hoe.Basic.AppLogic;
using Hoe.Basic.View;
using Hoe.Basic.Model;
using Hoe.Basic.AppLogic.Event;
using Hoe.Basic.DAO;
using System.Windows.Forms;
using Hoe.Basic.DB;

namespace Hoe.Basic.Controller
{
    public class BillsController : ControllerBase
    {
        public override ITask Task
        {
            get { return base.Task; }
            set
            {
                base.Task = value;
                (Task as SaleTask).CurrentBillChanged += CurrentBillChanged;
            }
        }

        public override IView View
        {
            get {return base.View; }
            set
            {
                base.View = value;

                (Task as SaleTask).BillsChanged += BillsChanged;

                (Task as SaleTask).Bills = BillDao.GetAll();// todo ,load from database

                SortBills();
            }
        }

        public void BillsChanged(Object sender, EventArgs arg)
        {
            if (arg is BillChangeEventArg)
            {

                BillChangeEventArg eventArg = (arg as BillChangeEventArg);
                Bill bill = eventArg.ChangedBill;

                //update operation is consistent between db and appearance
                //if reload data and rebind to the control, stupid problem called reentrant setcurrentcelladdresscore method occrurs
                //to avoid that, we are defaut not to reload data when update operation
                if (eventArg.ChangingType != ModelChangeEventArg.UPDATE)
                {
                    // change the view appearance
                    (View as IBillsView).ShowBillsList((Task as SaleTask).Bills);
                }
                (View as IBillsView).SelectBillInList(bill);
                SetCurrentBill(bill);

                //database persistence 
                DatabaseBillPersist(bill, eventArg.ChangingType);
            }
            else
            {
                (View as IBillsView).ShowBillsList((Task as SaleTask).Bills);
            }
        }

        public void SetCurrentBill(Bill bill)
        {
            (Task as SaleTask).CurrentBill = bill;
        }

        public void SetCurrentBillProduct(Product product)
        {
            (Task as SaleTask).CurrentBillProduct = product;
        }

        private void CurrentBillChanged(object sender, EventArgs e)
        {
            (View as IBillsView).ShowBillInfo((Task as SaleTask).CurrentBill);
        }

        public void CancelProductToRepo(Product product)
        {
            SaleTask task = (Task as SaleTask);

            if (task.CurrentBillProduct == null)
            {
                MessageBox.Show("请选择货物");
                return;
            }

            Product removedProduct = task.CurrentBillProduct;
            (View as IBillsView).RemoveFromProductsList(removedProduct);
            task.CancelProductToRepo(removedProduct);
            
        }

        public void ShowRepo()
        {
            Task.Navigator.Navigate(SaleTask.RepoView);
        }

        public void ShowBillView()
        {
            Task.TasksManager.StartTask(typeof(BillTask),Task);
        }

        public void ShowBackupRestoreView()
        {
            Task.TasksManager.StartTask(typeof(BackupRestoreTask), Task);
        }

        public void SortBills()
        {
            List<Bill> bills = (Task as SaleTask).Bills;
            if (bills != null)
            {
                // sort bills by completed descending and deliveryDate ascending
                List<Bill> sortedBills = (from b in bills orderby b.Completed ascending, b.DeliveryDate ascending select b).ToList();

                (Task as SaleTask).Bills = sortedBills;
            }
        }

        public void FilterBillsByPhone(String phone)
        {
            List<Bill> bills = BillDao.FindByPhone(phone);
            if(bills == null)
            {
                MessageBox.Show("找不到哟，亲");
                return;
            }
            else
                (Task as SaleTask).Bills = bills;
        }

        public void FilterBillsByPhone(String phone, bool completed)
        {
            List<Bill> bills = BillDao.FindByPhone(phone, completed);
            if (bills == null)
            {
                MessageBox.Show("找不到哟，亲");
                return;
            }
            else
                (Task as SaleTask).Bills = bills;
        }

        public void AllBills(bool completed)
        {
            List<Bill> bills = BillDao.Find(completed);

            (Task as SaleTask).Bills = bills;
        }

        public void AllBills()
        {
            List<Bill> bills = BillDao.GetAll();

            (Task as SaleTask).Bills = bills;
        }

        public void FilterBillsByProductName(String name, bool? completed)
        {
            List<Bill> bills;
            if(completed==null)
                bills = BillDao.FindByProductName(name);
            else
                bills = BillDao.FindByProductName(name, (bool)completed);

            if (bills == null)
            {
                MessageBox.Show("找不到哟，亲");
                return;
            }
            else
                (Task as SaleTask).Bills = bills;
        }

        public float CalculateTotalPrice()
        {
            
            List<Product> products = (Task as SaleTask).CurrentBill.Products;
            if (products == null)
                return 0;

            float sum = 0;
            foreach (Product p in (Task as SaleTask).CurrentBill.Products)
            {
                sum += p.Quantity * p.UnitPrice;
            }

            return sum;
        }

        public bool TestDatabaseOK()
        {
            return DatabaseHelper.IsDatabaseAlive();
        }

        /*
         * bill modify method
         */
        public void DeleteBill(Bill bill)
        {
            // since in the form view layer, we called bindingsource.remove method, it will also delete the object of model layer
            // here we just call the event trigger method to notify the observors to take actions
            (Task as SaleTask).TriggerBillsChanged(null, new BillChangeEventArg(bill, ModelChangeEventArg.REMOVE));
        }

        public void UpdateBill(Bill bill)
        {
            (Task as SaleTask).TriggerBillsChanged(null, new BillChangeEventArg(bill, ModelChangeEventArg.UPDATE));
        }

        public void DatabaseBillPersist(Bill bill, int changingType)
        {
            //database operation
            switch (changingType)
            {
                case ModelChangeEventArg.INSERT:
                    BillDao.Insert(bill);
                    break;
                case ModelChangeEventArg.UPDATE:
                    BillDao.Update(bill);
                    break;
                case ModelChangeEventArg.REMOVE:
                    BillDao.Delete(bill);
                    break;
            }
        }

    }
}
