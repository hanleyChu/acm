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
    [ViewEx(typeof(MainTask), MainTask.NewMailPropertiesView, "New")]
    public partial class NewMailPropertiesView : WinUserControlView_For_NewMailPropertiesViewController
    {
        public NewMailPropertiesView()
        {
            InitializeComponent();
        }

        private void newMailSenderAddressText_TextChanged(object sender, EventArgs e)
        {
            Controller.SetNewMailSenderAddress(newMailSenderAddressText.Text);
        }
    }

    public class WinUserControlView_For_NewMailPropertiesViewController : WinUserControlView<NewMailPropertiesViewController>
    { }
}
