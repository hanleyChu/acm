using System;
using System.Collections.Generic;
using System.Text;
using ASPNET_MVC_Store.Model;

namespace ASPNET_MVC_Store.ApplicationLogic
{
    public interface IEditProductView
    {
        string ProductName
        {
            get;
            set;
        }

        NorthwindDataSet.CategoriesRow Category
        {
            get;
            set;
        }

        NorthwindDataSet.SuppliersRow Supplier
        {
            get;
            set;
        }

        decimal UnitPrice
        {
            get;
            set;
        }
    }
}
