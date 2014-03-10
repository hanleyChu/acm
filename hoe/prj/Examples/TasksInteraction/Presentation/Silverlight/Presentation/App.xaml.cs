using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using MVCSharp.Core.Tasks;
using MVCSharp.Silverlight;
using MVCSharp.Examples.TasksInteraction.ApplicationLogic;
using MVCSharp.Examples.TasksInteraction.Model;

namespace MVCSharp.Examples.TasksInteraction.Presentation.Silverlight
{
    public partial class App : Application
    {
        public App()
        {
            this.Startup += this.Application_Startup;
            InitializeComponent();
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            CreateTestData();
            TasksManager tasksManager = new TasksManager(SilverlightViewsManager.
                                                         GetDefaultConfig());
            tasksManager.StartTask(typeof(MainTask));
        }

        private static void CreateTestData()
        {
            Employee.AllInstances.Add(new Employee("John", 30000));
            Employee.AllInstances.Add(new Employee("Pete", 20000));
            Employee.AllInstances.Add(new Employee("Andy", 25000));
        }
    }
}
