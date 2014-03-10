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
using ASPNET_MVC_Store.Model;
using MVCSharp.Webforms;
using ASPNET_MVC_Store.ApplicationLogic;

namespace ASPNET_MVC_Store.Presentation
{
    public partial class EditProduct : WebFormView<EditProductController>,
                                       IEditProductView
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CategoryDropDownList.DataSource = NorthwindDataSet.Instance.Categories;
            SupplierDropDownList.DataSource = NorthwindDataSet.Instance.Suppliers;
            DataBind();
        }

        public string ProductName
        {
            get { return NameTextBox.Text; }
            set { ProductNameLabel.Text = NameTextBox.Text = value; }
        }

        public NorthwindDataSet.CategoriesRow Category
        {
            get { return NorthwindDataSet.Instance.Categories[
                            CategoryDropDownList.SelectedIndex]; }
            set
            {
                // Drop down list control has a strange feature of ignoring
                // the posted back text after it was assigned. That is why
                // we are not assigning the text if the page was posted back.
                if (!IsPostBack) CategoryDropDownList.Text = value.CategoryName;
            }
        }

        public NorthwindDataSet.SuppliersRow Supplier
        {
            get { return NorthwindDataSet.Instance.Suppliers[
                            SupplierDropDownList.SelectedIndex]; }
            set
            {
                // Drop down list control has a strange feature of ignoring
                // the posted back text after it was assigned. That is why
                // we are not assigning the text if the page was posted back.
                if (!IsPostBack) SupplierDropDownList.Text = value.CompanyName;
            }
        }

        public decimal UnitPrice
        {
            get { return Convert.ToDecimal(UnitPriceTextBox.Text); }
            set { UnitPriceTextBox.Text = value.ToString(); }
        }

        protected void CommitButton_Click(object sender, EventArgs e)
        {
            Controller.Commit();
        }
    }
}
