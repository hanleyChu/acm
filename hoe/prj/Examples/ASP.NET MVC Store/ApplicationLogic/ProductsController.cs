using System;
using MVCSharp.Core;
using ASPNET_MVC_Store.Model;

namespace ASPNET_MVC_Store.ApplicationLogic
{
    public class ProductsController : ControllerBase<MainTask, IProductsView>
    {
        public void EditProduct(NorthwindDataSet.ProductsRow product)
        {
            Task.SelectedProduct = product;
            Task.Navigator.Navigate(MainTask.EditProduct);
        }

        public override MainTask Task
        {
            get { return base.Task; }
            set
            {
                base.Task = value;
                Task.SelectedCategoryChanged += SelectedCategoryChanged;
            }
        }

        private void SelectedCategoryChanged(object sender, EventArgs e)
        {
            View.Category = Task.SelectedCategory;
        }

        public override IProductsView View
        {
            get { return base.View; }
            set
            {
                base.View = value;
                View.Category = Task.SelectedCategory;
            }
        }
    }
}