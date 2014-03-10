using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MVCSharp.Core.Views;
using MVCSharp.Core;
using MVCSharp.Core.Configuration.Views;
using MVCSharp.Winforms;
using MVCSharp.Winforms.Configuration;
using Hoe.Basic.AppLogic;
using Hoe.Basic.Controller;

namespace Hoe.UI.Setting
{
    [WinformsView(typeof(BackupRestoreTask), BackupRestoreTask.BackupRestoreView, ShowModal = true)]
    public partial class BackupRestore : WinFormView
    {
        public BackupRestore()
        {
            InitializeComponent();
        }

        private void backupButton_Click(object sender, EventArgs e)
        {
              this.folderBrowserDialog.Description = "请选择要备份到的目录";

              if (this.folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
              {
                  String path = this.folderBrowserDialog.SelectedPath;
                  this.infoLabel.Text = "备份中，请等待...";
                  if((Controller as BackupRestoreController).BackupDatabaseTo(path))
                    this.infoLabel.Text = "备份完成";
                  else
                    this.infoLabel.Text = "备份失败,数据库服务可能没有启动";
              }

              
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog.Description = "请选择恢复文件的目录";

            if (this.folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                String path = this.folderBrowserDialog.SelectedPath;
                this.infoLabel.Text = "恢复中，请等待...";
                if((Controller as BackupRestoreController).RestoreDatabaseFrom(path))
                    this.infoLabel.Text = "恢复完成，请重启软件...";
                else
                    this.infoLabel.Text = "恢复失败,数据库服务可能没有启动";
            }
        }
    }
}
