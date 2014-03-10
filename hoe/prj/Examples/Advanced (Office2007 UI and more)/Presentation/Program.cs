using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Reflection;
using MVCSharp.Core.Tasks;
using MVCSharp.Examples.AdvancedCustomization.ApplicationLogic;
using MVCSharp.Core.Configuration;

namespace MVCSharp.Examples.AdvancedCustomization.Presentation
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            MVCConfiguration cfg = OutlookLikeViewsManager.GetDefaultConfig();
            cfg.ViewsAssemblies.Add(Assembly.Load(
                    "MVCSharp.Examples.AdvancedCustomization.SeparateViews"));
            cfg.TaskInfoProviderType = typeof(TaskInfoByAttributesProviderEx);
            cfg.ViewInfosProviderType = typeof(ViewInfosPrividerEx);
            (new TasksManager(cfg)).StartTask(typeof(MainTask));
            Application.Run(Application.OpenForms[0]);
        }
    }
}