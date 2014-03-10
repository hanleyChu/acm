using System;
using System.ComponentModel;
using MVCSharp.Core;
using ASPNET_MVC_Store.Model;

namespace ASPNET_MVC_Store.ApplicationLogic
{
    public class ProductCategoriesController : ControllerBase<MainTask,
                                                IProductCategoriesView>
    {
        public void CategorySelected(NorthwindDataSet.CategoriesRow selectedCat)
        {
            Task.SelectedCategory = selectedCat;
            Task.Navigator.Navigate(MainTask.Products);
        }

        public override IProductCategoriesView View
        {
            get { return base.View; }
            set
            {
                base.View = value;
                View.CategoriesList = (NorthwindDataSet.Instance.Categories
                                                        as IListSource).GetList();
            }
        }
    }
}