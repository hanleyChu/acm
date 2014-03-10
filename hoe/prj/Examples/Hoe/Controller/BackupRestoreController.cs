using System;
using System.Collections.Generic;
using System.Text;
using MVCSharp.Core;
using MVCSharp.Core.Tasks;
using MVCSharp.Core.Views;
using Hoe.Basic.AppLogic;
using Hoe.Basic.View;
using Hoe.Basic.Model;
using Hoe.Basic.AppLogic.Event;
using System.Windows.Forms;
using System.Linq;
using Hoe.Basic.DB;
using System.Diagnostics;
using System.IO;
using System.Configuration;

namespace Hoe.Basic.Controller
{
    public class BackupRestoreController : ControllerBase
    {

        public static string mongoBaseDir = ConfigurationManager.AppSettings["mongoBaseDir"];

        public override ITask Task
        {
            get { return base.Task; }
            set
            {
                base.Task = value;
            }
        }

        public override IView View
        {
            get {return base.View; }
            set
            {
                base.View = value;
            }
        }

        public bool BackupDatabaseTo(String path)
        {
            String basePath = System.AppDomain.CurrentDomain.BaseDirectory;
            String backupExe = Path.Combine(mongoBaseDir, @"mongo\bin\mongodump.exe");

            String result = Execute(backupExe, "-h localhost -d Hoe -o " + path, 0);
            if (String.IsNullOrEmpty(result))
                return false;
            else
                return true;
        }
        
        public bool RestoreDatabaseFrom(String path)
        {
            String basePath = System.AppDomain.CurrentDomain.BaseDirectory;
            String backupExe = Path.Combine(mongoBaseDir, @"mongo\bin\mongorestore.exe");

            String result = Execute(backupExe, "-h localhost -d Hoe -drop -directoryperdb " + path, 0);
            if(result.Contains("couldn't connect"))
                return false;
            else
                return true;
        }

        public static string Execute(string command, string args,int seconds)
        {
            string output = ""; //输出字符串  
            if (command != null && !command.Equals(""))
            {
                Process process = new Process();//创建进程对象  
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = command;//设定需要执行的命令  
                startInfo.Arguments = args; 
                startInfo.UseShellExecute = false;//不使用系统外壳程序启动  
                startInfo.RedirectStandardInput = false;//不重定向输入  
                startInfo.RedirectStandardOutput = true; //重定向输出  
                startInfo.CreateNoWindow = true;//不创建窗口  
                process.StartInfo = startInfo;
                try
                {
                    if (process.Start())//开始进程  
                    {
                        if (seconds == 0)
                        {
                            process.WaitForExit();//这里无限等待进程结束  
                        }
                        else
                        {
                            process.WaitForExit(seconds); //等待进程结束，等待时间为指定的毫秒  
                        }
                        output = process.StandardOutput.ReadToEnd();//读取进程的输出  
                    }
                }
                catch(Exception e)
                {
                    throw e;
                }
                finally
                {
                    if (process != null)
                        process.Close();
                }
            }
            return output;
        }  
        
    }
}
