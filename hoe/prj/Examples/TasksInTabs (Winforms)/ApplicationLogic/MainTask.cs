using System;
using System.Collections.Generic;
using System.Text;
using MVCSharp.Core.Tasks;
using MVCSharp.Core.Configuration.Tasks;

namespace MVCSharp.Examples.TasksInTabs.ApplicationLogic
{
    public class MainTask : TaskBase
    {
        [IPoint(typeof(MainViewController))]
        public const string MainView = "Main View";

        public override void OnStart(object param)
        {
            Navigator.NavigateDirectly(MainView);
        }
    }
}
