using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MVCSharp.Core.Configuration;
using MVCSharp.Core.Tasks;
using MVCSharp.Examples.TasksInTabs.ApplicationLogic;

namespace MVCSharp.Examples.TasksInTabs.Presentation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MVCConfiguration config = TasksInTabsViewsManager.GetDefaultConfig();
            (new TasksManager(config)).StartTask(typeof(MainTask));

            Application.Run(Application.OpenForms[0]);
        }
    }
}