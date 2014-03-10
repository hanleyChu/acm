using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MVCSharp.Core.Configuration.Views;
using MVCSharp.Examples.Basics.ApplicationLogic;
using MVCSharp.Examples.Basics.Model;
using MVCSharp.Mobile;

namespace MVCSharp.Examples.Basics.Presentation
{
    [View(typeof(MainTask), MainTask.Customers)]
    public partial class CustomersForm : MobileFormViewForCustomersController, ICustomersView
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        public void SetCustomersList(List<Customer> customers)
        {
            CustomersDataGrid.DataSource = customers;
        }

        public Customer CurrentCustomer
        {
            get
            {

                List<Customer> customers = CustomersDataGrid.DataSource as List<Customer>;
                if (customers != null)
                    return customers[CustomersDataGrid.CurrentRowIndex];
                else
                    return null;
                
            }
            set
            {
                List<Customer> customers = CustomersDataGrid.DataSource as List<Customer>;
                if (customers != null && customers.Count > CustomersDataGrid.CurrentRowIndex)
                {
                    customers[CustomersDataGrid.CurrentRowIndex] = value;
                    CustomersDataGrid.DataSource = customers;
                }
            }
        }

        void CustomersDataGrid_CurrentCellChanged(object sender, System.EventArgs e)
        {
            Controller.CurrentCustomerChanged();
        }

        private void ShowOrdersMenuItem_Click(object sender, EventArgs e)
        {
            Controller.ShowOrders();
        }
    }

    // This intermediate class is used as a workaround for the bug
    // in the VS form designer when inheriting a generic form class.
    public class MobileFormViewForCustomersController : MobileFormView<CustomersController>
    { }
}