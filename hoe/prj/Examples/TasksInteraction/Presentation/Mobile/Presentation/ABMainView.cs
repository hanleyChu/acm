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
    [MobileformsView(typeof(AwardBonusTask), AwardBonusTask.MainView, ShowModal = true)]
    public partial class ABMainView : MobileFormView, IABMainView
    {
        public ABMainView()
        {
            InitializeComponent();
        }

        public int ContractsMade
        {
            get { return (int)contractsNumUpDown.Value; }
            set { contractsNumUpDown.Value = value; }
        }

        public int CustomersAttracted
        {
            get { return (int)customersNumUpDown.Value; }
            set { customersNumUpDown.Value = value; }
        }

        private void advancedLinkLbl_Click(object sender, EventArgs e)
        {
            (Controller as ABMainController).ShowAdvancedOptions();
        }

        private void OKmenuItem_Click(object sender, EventArgs e)
        {
            Close();
            (Controller as ABMainController).DoAwardBonus();
        }
    }
}