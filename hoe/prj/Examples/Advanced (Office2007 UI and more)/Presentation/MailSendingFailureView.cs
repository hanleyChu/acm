using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MVCSharp.Examples.AdvancedCustomization.ApplicationLogic;

namespace MVCSharp.Examples.AdvancedCustomization.Presentation
{
    [ViewEx(typeof(MainTask), MainTask.MailSendingFailureView, "")]
    public partial class MailSendingFailureView : MailSendingSuccessView
    {
        public MailSendingFailureView()
        {
            InitializeComponent();
        }
    }
}

