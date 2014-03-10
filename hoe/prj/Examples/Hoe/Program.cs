using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MVCSharp.Core.Configuration;
using MVCSharp.Core.Tasks;
using MVCSharp.Winforms;
using Hoe.Basic.AppLogic;
using Hoe.Basic.View;
using Hoe.Basic.Model;
using Hoe.Basic.DB;

namespace Hoe.App
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            if (!DatabaseHelper.IsDatabaseAlive())
            {
                MessageBox.Show("亲，数据库服务没有启动~,请检查MongoDB服务是否已经正常启动了");

                Application.Exit();
                return;
            }

            TasksManager tasksManager = new TasksManager(WinformsViewsManager.
                                                         GetDefaultConfig());
            tasksManager.StartTask(typeof(SaleTask));

            Application.Run(Application.OpenForms[0]);
        }

    }
}