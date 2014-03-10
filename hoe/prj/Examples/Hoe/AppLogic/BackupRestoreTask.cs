using System;
using System.Collections.Generic;
using System.Text;
using MVCSharp.Core.Configuration.Tasks;
using MVCSharp.Core.Tasks;
using Hoe.Basic.Controller;
using Hoe.Basic.Model;

namespace Hoe.Basic.AppLogic
{
    public class BackupRestoreTask : TaskBase
    {
        [InteractionPoint(typeof(BackupRestoreController))]
        public const string BackupRestoreView = "BackupRestore";

        public override void OnStart(object param)
        {
            Navigator.NavigateDirectly(BackupRestoreView);
        }
    }
}
