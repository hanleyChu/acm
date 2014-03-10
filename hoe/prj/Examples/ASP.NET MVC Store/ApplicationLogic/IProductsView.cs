using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using ASPNET_MVC_Store.Model;

namespace ASPNET_MVC_Store.ApplicationLogic
{
    public interface IProductsView
    {
        NorthwindDataSet.CategoriesRow Category
        {
            get;
            set;
        }
    }
}
