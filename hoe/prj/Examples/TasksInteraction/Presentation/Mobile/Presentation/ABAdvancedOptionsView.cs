using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MVCSharp.Examples.TasksInteraction.ApplicationLogic;
using MVCSharp.Mobile;
using MVCSharp.Mobile.Configuration;

namespace MVCSharp.Examples.TasksInteraction.Presentation
{
    [MobileformsView(typeof(AwardBonusTask), AwardBonusTask.AdvancedOptionsView, ShowModal = true)]
    public partial class ABAdvancedOptionsView : MobileFormView, IABAdvancedOptionsView
    {
        public ABAdvancedOptionsView()
        {
            InitializeComponent();
        }

        public bool IsWorkerOfTheMonth
        {
            get { return workerOfTheMonthCB.Checked; }
            set { workerOfTheMonthCB.Checked = value; }
        }

        public bool SpecialServices
        {
            get { return specialServicesCB.Checked; }
            set { specialServicesCB.Checked = value; }
        }

        private void OKmenuItem_Click(object sender, EventArgs e)
        {
            Close();
            (Controller as ABAdvancedOptionsController).DoEnterOptions();
        }

        
    }
}