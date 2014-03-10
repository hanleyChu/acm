using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using MVCSharp.Core.Tasks;
using MVCSharp.Examples.TasksInteraction.ApplicationLogic;
using MVCSharp.Examples.TasksInteraction.Model;
using MVCSharp.Mobile;

namespace MVCSharp.Examples.TasksInteraction.Presentation
{
    static class Program
    {
        [MTAThread]
        static void Main()
        {
            CreateTestData();
            TasksManager tasksManager = new TasksManager(MobileformsViewsManager.GetDefaultConfig());
            tasksManager.StartTask(typeof(MainTask));

            Application.Run(MobileformsViewsManager.LastActivatedForm);
        }

        private static void CreateTestData()
        {
            Employee.AllInstances.Add(new Employee("John", 30000));
            Employee.AllInstances.Add(new Employee("Pete", 20000));
            Employee.AllInstances.Add(new Employee("Andy", 25000));
        }
    }
}