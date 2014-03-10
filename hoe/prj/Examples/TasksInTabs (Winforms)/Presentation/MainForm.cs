using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MVCSharp.Winforms;
using MVCSharp.Core.Configuration.Views;
using MVCSharp.Examples.TasksInTabs.ApplicationLogic;

namespace MVCSharp.Examples.TasksInTabs.Presentation
{
    [View(typeof(MainTask), MainTask.MainView)]
    public partial class MainForm : WinFormViewForMainViewController
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public TabPage CurrentTabPage
        {
            get { return tabControl1.SelectedTab; }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            Controller.StartTask(e.TabPage.Text); 
        }
    }

    public class WinFormViewForMainViewController : WinFormView<MainViewController>
    { }
}