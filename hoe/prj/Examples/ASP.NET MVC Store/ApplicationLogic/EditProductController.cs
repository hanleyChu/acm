using System;
using MVCSharp.Core;
using ASPNET_MVC_Store.Model;

namespace ASPNET_MVC_Store.ApplicationLogic
{
    public class EditProductController : ControllerBase<MainTask, IEditProductView>
    {
        public void Commit()
        {
            NorthwindDataSet.ProductsRow product = Task.SelectedProduct;
            product.ProductName = View.ProductName;
            product.CategoriesRow = View.Category;
            product.SuppliersRow = View.Supplier;
            product.UnitPrice = View.UnitPrice;
        }

        public override IEditProductView View
        {
            get { return base.View; }
            set
            {
                base.View = value;
                InitViewData();
            }
        }

        public override MainTask Task
        {
            get { return base.Task; }
            set
            {
                base.Task = value;
                Task.SelectedProductChanged += SelectedProductChanged;
            }
        }

        private void SelectedProductChanged(object sender, EventArgs e)
        {
            InitViewData();
        }

        private void InitViewData()
        {
            View.ProductName = Task.SelectedProduct.ProductName;
            View.Category = Task.SelectedProduct.CategoriesRow;
            View.Supplier = Task.SelectedProduct.SuppliersRow;
            View.UnitPrice = Task.SelectedProduct.UnitPrice;
        }
    }
}