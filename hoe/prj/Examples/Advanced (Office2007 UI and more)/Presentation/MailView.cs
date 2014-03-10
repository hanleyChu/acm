using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MVCSharp.Winforms;
using MVCSharp.Examples.AdvancedCustomization.ApplicationLogic;

namespace MVCSharp.Examples.AdvancedCustomization.Presentation
{
    public partial class MailView : WinUserControlView_For_MailController, IMailView
    {
        public MailView()
        {
            InitializeComponent();
        }

        public string RecipientAddress
        {
            get { return recipientTextBox.Text; }
        }

        public string SenderAddress
        {
            get { return senderTextBox.Text; }
            set { senderTextBox.Text = value; }
        }

        private void sendMailButton_Click(object sender, EventArgs e)
        {
            Controller.SendMail();
        }
    }

    public class WinUserControlView_For_MailController : WinUserControlView<MailController>
    { }
}
