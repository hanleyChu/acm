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
using MVCSharp.Core.Configuration.Views;
using MVCSharp.Examples.Basics.ApplicationLogic;
using MVCSharp.Examples.Basics.Model;

namespace MVCSharp.Examples.Basics.Presentation.Silverlight
{
    [View(typeof(MainTask), MainTask.Orders)]
    public partial class OrdersPage : UserControlView, IOrdersView
    {
        public OrdersPage()
        {
            InitializeComponent();
        }

        public void SetOrdersList(List<Order> orders)
        {
            OrdersGrid.ItemsSource = orders;
        }

        public Order CurrentOrder
        {
            get
            {
                return OrdersGrid.SelectedItem as Order;
            }
        }

        public void SetOperationsEnabling(bool acceptIsEnabled, bool shipIsEnabled, bool cancelIsEnabled)
        {
            AcceptOrderBtn.IsEnabled = acceptIsEnabled;
            ShipOrderBtn.IsEnabled = shipIsEnabled;
            CancelOrderBtn.IsEnabled = cancelIsEnabled;
        }

        private void OrdersGrid_CurrentCellChanged(object sender, EventArgs e)
        {
            (Controller as OrdersController).CurrentOrderChanged();
        }

        private void AcceptOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            (Controller as OrdersController).AcceptOrder();
            UpdateGridData();
        }

        private void ShipOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            (Controller as OrdersController).ShipOrder();
            UpdateGridData();
        }

        private void CancelOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            (Controller as OrdersController).CancelOrder();
            UpdateGridData();
        }

        private void UpdateGridData()
        {
            object selItm = OrdersGrid.SelectedItem;
            System.Collections.IEnumerable itms = OrdersGrid.ItemsSource;
            OrdersGrid.ItemsSource = null;
            OrdersGrid.ItemsSource = itms;
            OrdersGrid.SelectedItem = selItm;
        }

        private void ShowCustomersBtn_Click(object sender, RoutedEventArgs e)
        {
            (Controller as OrdersController).ShowCustomers();
        }
    }
}
