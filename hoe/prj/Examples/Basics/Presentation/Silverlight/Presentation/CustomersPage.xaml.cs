using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using MVCSharp.Silverlight;
using MVCSharp.Examples.Basics.ApplicationLogic;
using MVCSharp.Examples.Basics.Model;
using MVCSharp.Core.Configuration.Views;

namespace MVCSharp.Examples.Basics.Presentation.Silverlight
{
    [View(typeof(MainTask), MainTask.Customers)]
    public partial class CustomersPage : UserControlView, ICustomersView
    {
        public CustomersPage()
        {
            InitializeComponent();
        }

        public void SetCustomersList(List<Customer> customers)
        {
            CustomersGrid.ItemsSource = customers;
        }

        public Customer CurrentCustomer
        {
            get { return CustomersGrid.SelectedItem as Customer; }
            set { CustomersGrid.SelectedItem = value; }
        }

        private void CustomersGrid_CurrentCellChanged(object sender, EventArgs e)
        {
            (Controller as CustomersController).CurrentCustomerChanged();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (Controller as CustomersController).ShowOrders();
        }
    }
}
