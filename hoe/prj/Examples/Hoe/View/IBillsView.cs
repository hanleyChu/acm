using System;
using System.Collections.Generic;
using Hoe.Basic.Model;

namespace Hoe.Basic.View
{
    public interface IBillsView
    {
        Bill CurrentBill
        {
            get;
        }

        /*
         * show bills in girdview or listview
         */
        void ShowBillsList(List<Bill> bills);

        /*
         * show specific bill details
         */ 
        void ShowBillInfo(Bill bill);

        /*
         * make given bill selected among all bill list
         */
        void SelectBillInList(Bill bill);

        /*
         * remove given product from specific bill
         */
        void RemoveFromProductsList(Product product);

    }
}
