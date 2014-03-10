using System;
using System.Collections.Generic;
using System.Text;
using MVCSharp.Core.Tasks;
using MVCSharp.Core;
using MVCSharp.Core.Configuration.Tasks;

namespace MVCSharp.Examples.TasksInTabs.ApplicationLogic
{
    class TabTask2 : TaskBase
    {
        [IPoint(typeof(ControllerBase))]
        public const string View = "View";

        private int taskStartTimes;

        public int TaskStartTimes
        {
            get { return taskStartTimes; }
        }

        public override void OnStart(object param)
        {
            taskStartTimes++;
            Navigator.ActivateView(View);
        }
    }
}
