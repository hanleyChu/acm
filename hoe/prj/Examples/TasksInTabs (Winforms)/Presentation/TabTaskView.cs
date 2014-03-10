using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MVCSharp.Winforms;
using MVCSharp.Core.Configuration.Views;
using MVCSharp.Examples.TasksInTabs.ApplicationLogic;

namespace MVCSharp.Examples.TasksInTabs.Presentation
{
    [View(typeof(TabTask1), TabTask1.View2)]
    [View(typeof(TabTask2), TabTask2.View)]
    public partial class TabTaskView : WinUserControlView
    {
        public TabTaskView()
        {
            InitializeComponent();
        }

        public override void Activate(bool activate)
        {
            int taskStartTimes = Controller.Task is TabTask1 ?
                (Controller.Task as TabTask1).TaskStartTimes : (Controller.Task as TabTask2).TaskStartTimes;
            label1.Text = "Task was started " + taskStartTimes.ToString() + " times.";
        }
    }
}
