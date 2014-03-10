using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MVCSharp.Winforms;
using MVCSharp.Core;

namespace MVCSharp.Examples.WindowsFormsExample.Presentation
{
    // Using such base class (instead of WinUserControlView) makes the
    // association to the controller strongly-tyed.
    public partial class UserControlView : WinUserControlView_For_ControllerBase
    {
        public UserControlView()
        {
            InitializeComponent();
        }

        public override void Activate(bool activate)
        {
            textBox.Text = activate ? "Active" : "Inactive";
        }
    }

    // This intermediate class is used as a workaround for the bug
    // in the VS form designer when inheriting a generic user control class.
    public class WinUserControlView_For_ControllerBase : WinUserControlView<ControllerBase>
    { }
}
