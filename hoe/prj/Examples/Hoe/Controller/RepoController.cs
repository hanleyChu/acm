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
using Hoe.Basic.DAO;
using Hoe.UI.Common;
using System.Windows.Forms;

namespace Hoe.Basic.Controller
{
    public class RepoController : ControllerBase
    {
        public override ITask Task
        {
            get { return base.Task; }
            set
            {
                base.Task = value;
                (Task as SaleTask).CurrentRepoProductChanged += CurrentRepoProductChanged;
            }
        }

        public override IView View
        {
            get {return base.View; }
            set
            {
                base.View = value;
                (Task as SaleTask).RepoProductsChanged += RepoProductsChanged;

                (Task as SaleTask).Products = ProductDao.GetAll();// todo ,load from database
            }
        }

        public void FilterProducts(String name)
        {
            if (String.IsNullOrEmpty(name))
                (Task as SaleTask).Products = ProductDao.GetAll();
            else
                (Task as SaleTask).Products = ProductDao.FindLikeName(name);
        }

        

        public void ShowRepo()
        {
            Task.Navigator.Navigate(SaleTask.RepoView);
        }

        public void SetCurrentRepoProduct(Product product)
        {
            (Task as SaleTask).CurrentRepoProduct = product;
        }

        public void AddCurrentProductToBill(int salesCount)
        {
            Product currentProduct = (Task as SaleTask).CurrentRepoProduct;
            if (currentProduct == null)
            {
                MessageBox.Show("请选择货物");
                return;
            }

            if ((Task as SaleTask).CurrentBill == null)
            {
                MessageBox.Show("请选择当前订单");
                return;
            }

            if (salesCount < 0)
            {
                MessageBox.Show("请输入数量");
                return;
            }

            if (!(Task as SaleTask).CurrentBill.Products.Contains(currentProduct))
            {
                if (DialogTextBox.Show("需求数量") == DialogResult.OK)
                {
                    String numStr = DialogTextBox.textValue;
                    int num;
                    if (!int.TryParse(numStr, out num))
                    {
                        MessageBox.Show("请输入数字！");
                        return;
                    }
                    else
                    {
                        if (num < salesCount)
                        {
                            MessageBox.Show("分配超额");
                            return;
                        }
                        else if (salesCount > currentProduct.Quantity)
                        {
                            MessageBox.Show("货存不足");
                            return;
                        }
                        else
                        {
                            (Task as SaleTask).PreAddCurrentProductToCurrentBill(num, salesCount);
                        }
                    }
                }
                return;
            }
            else
            {
                Product p = (Task as SaleTask).CurrentBill.Products.Find(x => x.Equals(currentProduct));
                if (p.Demand < salesCount + p.Quantity)
                {
                    MessageBox.Show("分配超额");
                    return;
                }
                if (salesCount > currentProduct.Quantity)
                {
                    MessageBox.Show("货存不足");
                    return;
                }
                else
                {
                    (Task as SaleTask).AddCurrentProductToCurrentBill(salesCount);
                    return;
                }
                
            }
        }

        public void ShowBills()
        {
            Task.Navigator.Navigate(SaleTask.BillsView);
        }

        public void ShowProductView()
        {
            Task.TasksManager.StartTask(typeof(ProductTask), Task);
        }


        /*
         * observor events
         */
        private void CurrentRepoProductChanged(object sender, EventArgs e)
        {

        }

        private void RepoProductsChanged(object sender, EventArgs e)
        {
            if (e is ProductChangeEventArg)
            {
                ProductChangeEventArg eventArg = (e as ProductChangeEventArg);
                Product product = eventArg.ChangedProduct;

                if (eventArg.ChangingType != ModelChangeEventArg.UPDATE)
                {
                    (View as IRepoView).ShowProductsList((Task as SaleTask).Products);
                }
                (View as IRepoView).SelectProductInList(product);
                SetCurrentRepoProduct(product);

                //database operation
                DatabaseProductPersist(product, eventArg.ChangingType);
                
            }
            else
            {
                (View as IRepoView).ShowProductsList((Task as SaleTask).Products);
            }
        }

        /*
         * product modify method
         */
        public void DeleteProduct(Product product)
        {
            // since in the form view layer, we called bindingsource.remove method, it will also delete the object of model layer
            // here we just call the event trigger method to notify the observors to take actions
            (Task as SaleTask).TriggerRepoProductsChanged(null, new ProductChangeEventArg(product, ModelChangeEventArg.REMOVE));
        }

        public void UpdateProduct(Product product)
        {
            (Task as SaleTask).TriggerRepoProductsChanged(null, new ProductChangeEventArg(product, ModelChangeEventArg.UPDATE));
        }

        private void DatabaseProductPersist(Product product, int changingType)
        {
            switch (changingType)
            {
                case ModelChangeEventArg.INSERT:
                    ProductDao.Insert(product);
                    break;
                case ModelChangeEventArg.UPDATE:
                    ProductDao.Update(product);
                    break;
                case ModelChangeEventArg.REMOVE:
                    ProductDao.Delete(product);
                    break;
            }
        }
    }
}
