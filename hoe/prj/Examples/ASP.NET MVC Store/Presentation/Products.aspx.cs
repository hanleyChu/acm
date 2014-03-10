using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using MVCSharp.Webforms;
using ASPNET_MVC_Store.ApplicationLogic;
using ASPNET_MVC_Store.Model;

namespace ASPNET_MVC_Store.Presentation
{
    public partial class Products : WebFormView<ProductsController>, IProductsView
    {
        private NorthwindDataSet.CategoriesRow category;

        public NorthwindDataSet.CategoriesRow Category
        {
            get { return category; }
            set
            {
                category = value;
                ProductsDataList.DataSource = Category.GetProductsRows();
                CategoryNameLabel.Text = Category.CategoryName;
                DataBind();
            }
        }

        protected void ProductsDataList_ItemCommand(object source,
                                  DataListCommandEventArgs e)
        {
            object itm = (ProductsDataList.DataSource as IList)[e.Item.ItemIndex];
            Controller.EditProduct(itm as NorthwindDataSet.ProductsRow);
        }
    }
}
