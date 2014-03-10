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
using MVCSharp.Examples.Basics.ApplicationLogic;
using MVCSharp.Examples.Basics.Model;

namespace MVCSharp.Examples.Basics.Presentation.Silverlight
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
            Customer.AllCustomers.Add(new Customer("John"));
            Customer.AllCustomers.Add(new Customer("Paul"));

            Customer.AllCustomers[0].Orders.Add(new Order());
            Customer.AllCustomers[0].Orders.Add(new Order());
            Customer.AllCustomers[0].Orders.Add(new Order());

            Customer.AllCustomers[1].Orders.Add(new Order());
            Customer.AllCustomers[1].Orders.Add(new Order());
        }
    }
}
