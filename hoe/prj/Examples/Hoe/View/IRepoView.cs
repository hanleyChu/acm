using System;
using System.Collections.Generic;
using System.Text;
using Hoe.Basic.Model;

namespace Hoe.Basic.View
{
    public interface IRepoView
    {    
        Product CurrentProduct
        {
            get;
        }

        int SalesCount
        {
            get;
        }

        void ShowProductsList(List<Product> products);

        void SelectProductInList(Product product);
    }
}
