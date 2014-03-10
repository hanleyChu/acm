using System;
using System.Collections.Generic;
using System.Text;
using MVCSharp.Core;
using MVCSharp.Core.Views;
using MVCSharp.Examples.Basics.Model;

namespace MVCSharp.Examples.Basics.ApplicationLogic
{
    public class CustomersController : ControllerBase<MainTask, ICustomersView>
    {
        public override ICustomersView View
        {
            get { return base.View; }
            set
            {
                base.View = value;
                View.SetCustomersList(Customer.AllCustomers);
                View.CurrentCustomer = Task.CurrentCustomer;
            }
        }

        public void ShowOrders()
        {
            Task.Navigator.Navigate(MainTask.Orders);
        }

        public void CurrentCustomerChanged()
        {
            Task.CurrentCustomer = View.CurrentCustomer;
        }
    }
}
