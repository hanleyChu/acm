using System;
using System.Collections.Generic;
using System.Text;
using MVCSharp.Core;
using MVCSharp.Core.Tasks;
using MVCSharp.Core.Views;

namespace MVCSharp.Examples.TasksInTabs.ApplicationLogic
{
    public class MainViewController : ControllerBase<MainTask, IView>
    {
        private Dictionary<string, ITask> tasks = new Dictionary<string, ITask>();

        public void StartTask(string taskName)
        {
            if (taskName == "No Task") return;
            if (!tasks.ContainsKey(taskName))
                tasks[taskName] = StartNewTask(taskName);
            else
                tasks[taskName].OnStart(null);
        }

        private ITask StartNewTask(string taskName)
        {
            switch (taskName)
            {
                case "Task One": return Task.TasksManager.StartTask(typeof(TabTask1));
                case "Task Two": return Task.TasksManager.StartTask(typeof(TabTask2));
            }
            return null;
        }
    }
}
