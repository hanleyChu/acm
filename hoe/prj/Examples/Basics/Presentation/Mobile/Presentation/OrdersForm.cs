using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using MVCSharp.Core.Configuration.Views;
using System.Windows.Forms;
using MVCSharp.Examples.Basics.ApplicationLogic;
using MVCSharp.Examples.Basics.Model;
using MVCSharp.Mobile;

namespace MVCSharp.Examples.Basics.Presentation
{
    [View(typeof(MainTask), MainTask.Orders)]
    public partial class OrdersForm : MobileFormView, IOrdersView
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        public void SetOrdersList(List<Order> orders)
        {
            OrdersDataGrid.DataSource = orders;
        }

        public Order CurrentOrder
        {
            get
            {
                List<Order> orders = OrdersDataGrid.DataSource as List<Order>;
                if (orders != null)
                    return orders[OrdersDataGrid.CurrentRowIndex];
                else
                    return null;
            }
        }

        public void SetOperationsEnabling(bool AcceptIsEnabled, bool ShipIsEnabled, bool CancelIsEnabled)
        {
            AcceptMenuItem.Enabled = AcceptIsEnabled;
            ShipMenuItem.Enabled = ShipIsEnabled;
            CancelMenuItem.Enabled = CancelIsEnabled;
        }

        private void CancelMenuItem_Click(object sender, EventArgs e)
        {
            (Controller as OrdersController).CancelOrder();
        }

        private void AcceptMenuItem_Click(object sender, EventArgs e)
        {
            (Controller as OrdersController).AcceptOrder();
        }

        private void ShowMenuItem_Click(object sender, EventArgs e)
        {
            (Controller as OrdersController).ShowCustomers();
        }

        private void ShipMenuItem_Click(object sender, EventArgs e)
        {
            (Controller as OrdersController).ShipOrder();
        }

        private void OrdersDataGrid_CurrentCellChanged(object sender, EventArgs e)
        {
            (Controller as OrdersController).CurrentOrderChanged();
        }
    }
}