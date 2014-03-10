using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using MVCSharp.Core.Tasks;
using MVCSharp.Examples.Basics.ApplicationLogic;
using MVCSharp.Examples.Basics.Model;
using MVCSharp.Mobile;

namespace MVCSharp.Examples.Basics.Presentation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            CreateTestData();
            TasksManager tasksManager = new TasksManager(MobileformsViewsManager.GetDefaultConfig());
            ITask task = tasksManager.StartTask(typeof(MainTask));
            Application.Run(MobileformsViewsManager.LastActivatedForm);
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