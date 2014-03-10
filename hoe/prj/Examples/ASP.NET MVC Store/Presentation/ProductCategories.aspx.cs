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
    public partial class ProductCategories : 
           WebFormView<ProductCategoriesController>, IProductCategoriesView
    {
        public IList CategoriesList
        {
            get { return CategoriesDataList.DataSource as IList; }
            set
            {
                CategoriesDataList.DataSource = value;
                DataBind();
            }
        }

        protected void CategoriesDataList_ItemCommand(object source,
                                    DataListCommandEventArgs e)
        {
            DataRowView rv = CategoriesList[e.Item.ItemIndex] as DataRowView;
            Controller.CategorySelected(rv.Row as NorthwindDataSet.CategoriesRow);
        }
    }
}
