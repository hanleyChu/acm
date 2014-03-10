using System;
using MVCSharp.Core;
using MVCSharp.Core.Tasks;
using MVCSharp.Core.Configuration.Tasks;
using ASPNET_MVC_Store.Model;

namespace ASPNET_MVC_Store.ApplicationLogic
{
    public class MainTask : TaskBase
    {
        [IPoint(typeof(ControllerBase), true)]
        public const string Welcome = "Welcome";

        [IPoint(typeof(ProductCategoriesController), true, Products)]
        public const string ProductCategories = "Product Categories";

        [IPoint(typeof(ProductsController), EditProduct)]
        public const string Products = "Products";

        [IPoint(typeof(EditProductController))]
        public const string EditProduct = "Edit Product";

        private NorthwindDataSet.CategoriesRow selectedCategory =
                                    NorthwindDataSet.Instance.Categories[0];
        private NorthwindDataSet.ProductsRow selectedProduct =
                                    NorthwindDataSet.Instance.Products[0];

        public event EventHandler SelectedCategoryChanged;
        public event EventHandler SelectedProductChanged;

        public NorthwindDataSet.CategoriesRow SelectedCategory
        {
            get { return selectedCategory; }
            set
            {
                selectedCategory = value;
                if (SelectedCategoryChanged != null)
                    SelectedCategoryChanged(this, EventArgs.Empty);
            }
        }

        public NorthwindDataSet.ProductsRow SelectedProduct
        {
            get { return selectedProduct; }
            set
            {
                selectedProduct = value;
                if (SelectedProductChanged != null)
                    SelectedProductChanged(this, EventArgs.Empty);
            }
        }

        public override void OnStart(object param)
        {
            Navigator.NavigateDirectly(Welcome);
        }
    }
}
