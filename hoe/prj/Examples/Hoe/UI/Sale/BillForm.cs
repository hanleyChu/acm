using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MVCSharp.Core.Views;
using MVCSharp.Core;
using MVCSharp.Core.Configuration.Views;
using MVCSharp.Winforms;
using MVCSharp.Winforms.Configuration;
using Hoe.Basic.AppLogic;
using Hoe.Basic.Model;
using Hoe.Basic.Controller;

namespace Hoe.UI.Sale
{
    [WinformsView(typeof(BillTask), BillTask.BillView, ShowModal = true)]
    public partial class BillForm : WinFormView
    {
        public BillForm()
        {
            InitializeComponent();
        }

        private void newBillButton_Click(object sender, EventArgs e)
        {
            String number = this.numberTextBox.Text;
            String phone = this.phoneTextBox.Text;
            DateTime deliveryDate = this.deliveryDateTimePicker.Value;
            String remark = this.remarkTextBox.Text;

            Bill bill = new Bill()
            {
                Number = number,
                Phone = phone,
                DeliveryDate = deliveryDate,
                Remark = remark,
                Completed = false
            };

            (Controller as BillController).NewBill(bill);
            
        }

    }
}
