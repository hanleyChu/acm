using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MVCSharp.Core.Configuration.Tasks;
using MVCSharp.Core.Tasks;
using Hoe.Basic.Controller;
using Hoe.Basic.Model;
using Hoe.Basic.DAO;
using Hoe.Basic.AppLogic.Event;


namespace Hoe.Basic.AppLogic
{
    public class SaleTask : TaskBase
    {
        [InteractionPoint(typeof(BillsController), RepoView)]
        public const string BillsView = "Bills";

        [InteractionPoint(typeof(RepoController), BillsView)]
        public const string RepoView = "Repo";

        /*
         * Product 
         */
        private Product currentRepoProduct = null;

        public event EventHandler CurrentRepoProductChanged;

        public void TriggerCurrentRepoProductChanged(Object sender, EventArgs arg)
        {
            if (CurrentRepoProductChanged != null)
                CurrentRepoProductChanged(sender, arg);
        }

        public Product CurrentRepoProduct
        {
            get { return currentRepoProduct; }
            set
            {
                currentRepoProduct = value;
                TriggerCurrentRepoProductChanged(this, new ProductChangeEventArg(value, ModelChangeEventArg.SELECT));
            }
        }

        public event EventHandler RepoProductsChanged;

        public void TriggerRepoProductsChanged(Object sender, EventArgs arg)
        {
            if (RepoProductsChanged != null)
                RepoProductsChanged(sender, arg);
        }


        private List<Product> products = null;

        public List<Product> Products
        {
            set
            {
                products = value;
                TriggerRepoProductsChanged(this, EventArgs.Empty);
            }
            get
            {
                if (products == null)
                {
                    products = new List<Product>();
                }
                return products;
            }
        }

        /*
         * Bill 
         */
        private Bill currentBill = null;

        public event EventHandler CurrentBillChanged;

        public void TriggerCurrentBillChanged(Object sender, EventArgs arg)
        {
            if (CurrentBillChanged != null)
                CurrentBillChanged(sender, arg);
        }

        public void PreAddCurrentProductToCurrentBill(int precount,int count)
        {
            // get the clone of current product
            Product clone = CurrentRepoProduct.Clone() as Product;
            clone.Demand = precount;
            clone.Quantity = count;
            CurrentRepoProduct.Demand += precount - count;
            CurrentRepoProduct.Quantity -= count;

            // trigger the repo products event
            TriggerRepoProductsChanged(this, new ProductChangeEventArg(CurrentRepoProduct, ModelChangeEventArg.UPDATE));

            // set it to the current bill
            // check if products list exist
            if (CurrentBill.Products == null)
                CurrentBill.Products = new List<Product>();

            CurrentBill.Products.Add(clone);

            // check if the bill is ready for assemblage
            if (CurrentBill.Products.Count<Product>(b => b.Quantity < b.Demand) == 0)
            {
                CurrentBill.AssemblageOK = true;
            }
            else
            {
                CurrentBill.AssemblageOK = false;
                CurrentBill.Completed = false;
            }
            // trigger the bills event
            // TriggerBillsChanged(this, EventArgs.Empty);

            // persist current bill object
            BillDao.Update(CurrentBill);

            //  trigger the bill event
            TriggerCurrentBillChanged(this, EventArgs.Empty);
            
        }

        public void AddCurrentProductToCurrentBill(int count)
        {
            // get the clone of current product
            CurrentRepoProduct.Quantity -= count;
            CurrentRepoProduct.Demand -= count;

            // trigger the repo products event
            TriggerRepoProductsChanged(this, new ProductChangeEventArg(CurrentRepoProduct, ModelChangeEventArg.UPDATE));

            // set it to the current bill
            // check if products list exist
            if (CurrentBill.Products == null)
                CurrentBill.Products = new List<Product>();

            // check if the product exist, if exist, then increase by extra products quantities
            List<Product> specificProduct = (from p in CurrentBill.Products
                                             where p.Equals(CurrentRepoProduct)
                                             select p).ToList();
            if (specificProduct.Count > 0)
            {
                specificProduct[0].Quantity += count;
            }

            // check if the bill is ready for assemblage
            if (CurrentBill.Products.Count<Product>(b => b.Quantity < b.Demand) == 0)
            {
                CurrentBill.AssemblageOK = true;
            }
            else
            {
                CurrentBill.AssemblageOK = false;
                CurrentBill.Completed = false;
            }
            // trigger the bills event
            // TriggerBillsChanged(this, EventArgs.Empty);

            // persist current bill object
            BillDao.Update(CurrentBill);

            // trigger the bill event
            TriggerCurrentBillChanged(this, EventArgs.Empty);
        }

        public void CancelProductToRepo(Product product)
        {
            // check if the product exist, if exist, then increase by extra products quantities
            List<Product> specificProduct = (from p in Products
                                             where p.Equals(product)
                                             select p).ToList();
            if (specificProduct.Count > 0)
            {
                specificProduct[0].Quantity += product.Quantity;
                specificProduct[0].Demand -= (product.Demand - product.Quantity);
                product = specificProduct[0];
                TriggerRepoProductsChanged(this, new ProductChangeEventArg(product, ModelChangeEventArg.UPDATE));
            }
            else
            {
                product.Demand -= product.Quantity;
                Products.Add(product);
                TriggerRepoProductsChanged(this, new ProductChangeEventArg(product, ModelChangeEventArg.INSERT));
            }

            // check if the bill is ready for assemblage
            if (CurrentBill.Products.Count == 0 || CurrentBill.Products.Count<Product>(b => b.Quantity < b.Demand) > 0)
            {
                CurrentBill.AssemblageOK = false;
                CurrentBill.Completed = false;

                // trigger the bill event
                //TriggerBillsChanged(this, EventArgs.Empty);
            }

            BillDao.Update(CurrentBill);
            ProductDao.Update(product);

        }

        public Bill CurrentBill
        {
            get { return currentBill; }
            set
            {
                currentBill = value;
                TriggerCurrentBillChanged(this, EventArgs.Empty);
            }
        }

        private List<Bill> bills;

        public List<Bill> Bills
        {
            set
            {
                bills = value;
                TriggerBillsChanged(this, EventArgs.Empty);
            }
            get
            {
                if (bills == null)
                    return new List<Bill>();
                else
                    return bills;
            }
        }

        public event EventHandler BillsChanged;

        public void TriggerBillsChanged(Object sender, EventArgs arg)
        {
            if (BillsChanged != null)
                BillsChanged(sender, arg);
        }

        /*
         * product of specific bill 
         */
        private Product currentBillProduct = null;

        public Product CurrentBillProduct
        {
            get { return currentBillProduct; }
            set
            {
                currentBillProduct = value;
            }
        }

        

        /*
         * start up action
         */
        public override void OnStart(object param)
        {
            Navigator.NavigateDirectly(BillsView);
        }
    }
}
